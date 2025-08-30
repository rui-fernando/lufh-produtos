using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    [ServiceContract]
    public interface ISolicitacao
    {
        [OperationContract]
        void Cadastrar(Solicitacoes obj);

        [OperationContract]
        List<Solicitacoes> listar();

        [OperationContract]
        Solicitacoes buscar(long id);

        [OperationContract]
        void modificarStatus(long id, bool aceito);
    }
}
