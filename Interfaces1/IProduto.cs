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
    public interface IProduto
    {
        [OperationContract]
        void Cadastrar(Produto obj);

        [OperationContract]
        void Editar(Produto obj);

        [OperationContract]
        List<Produto> listar();

        [OperationContract]
        Produto Buscar(long Id);

        [OperationContract]
        List<Produto> listarPorSolicitante(long idSolicitante);
    }
}
