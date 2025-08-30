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
    public interface IServico
    {
        [OperationContract]
        void Cadastrar(Servico obj);

        [OperationContract]
        void Editar(Servico obj);

        [OperationContract]
        List<Servico> listar();

        [OperationContract]
        Servico Buscar(long Id);

    }

}
