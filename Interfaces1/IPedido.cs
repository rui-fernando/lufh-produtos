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
    public interface IPedido
    {
        [OperationContract]
        void Cadastrar(Pedido obj);

        [OperationContract]
        void Editar(Pedido obj);

        [OperationContract]
        List<Pedido> listar();

        [OperationContract]
        Pedido Buscar(long Id);

    }

}
