using Controllers.repositorios;
using Entidades;
using Interfaces1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ProdutoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ProdutoService.svc ou ProdutoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ProdutoService : IProduto
    {
        private ProdutoRep rep = new ProdutoRep();

        public void Cadastrar(Produto obj)
        {
            rep.Cadastrar(obj);
        }

        public void Editar(Produto obj)
        {
            rep.Editar(obj);
        }

        public List<Produto> listar()
        {
            return rep.listar();
        }

        public Produto Buscar(long id)
        {
            return rep.Buscar(id);
        }

        public List<Produto> listarPorSolicitante(long idSolicitante)
        {
            return rep.listarPorSolicitante(idSolicitante);
        }
    }
}
