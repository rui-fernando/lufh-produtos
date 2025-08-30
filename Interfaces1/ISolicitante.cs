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
    public interface ISolicitante
    {
        [OperationContract]
        void Cadastrar(Solicitante obj);

        [OperationContract]
        void Editar(Solicitante obj);

        [OperationContract]
        List<Solicitante> listar();

        [OperationContract]
        Solicitante Buscar(long Id);
    }
}
