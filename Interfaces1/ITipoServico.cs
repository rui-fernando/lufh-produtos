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
    public interface ITipoServico
    {
        [OperationContract]
        void Cadastrar(TipoServico obj);

        [OperationContract]
        void Editar(TipoServico obj);

        [OperationContract]
        TipoServico Buscar(long Id);

        [OperationContract]
        List<TipoServico> listar();

    }
}
