using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorios
{
    public class ProdutoRep
    {
        public void Cadastrar(Produto obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Produtos.Add(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Produto obj)
        {
            using (var ctx = new SistemaContext())
            {
                Produto objAnt = ctx.Produtos.Find(obj.IdProduto);

                objAnt.TipoProduto = obj.TipoProduto;
                objAnt.PesoProduto = obj.PesoProduto;
                objAnt.NomeProduto = obj.NomeProduto;
                objAnt.ModeloProduto = obj.ModeloProduto;
                objAnt.IdFuncionarioEditor = obj.IdFuncionarioEditor;

                ctx.SaveChanges();
            }
        }

        public List<Produto> listar()
        {
            using(var ctx = new SistemaContext())
            {
                var produtos = (from obj in ctx.Produtos select obj).OrderBy(x => x.IdProduto).ToList();
                return produtos;
            }
        }

        public Produto Buscar(long Id)
        {
            Produto obj = new Produto();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Produtos.Find(Id);
            }
            return obj;
        }

        public List<Produto> listarPorSolicitante(long idSolicitante) 
            //***********POSSIVEL CORREÇÂO**************
            // O retorno da função pode ser um Iqueryable (nao sei escrever esse nome)
        {
            using (var ctx = new SistemaContext()) 
            {
                var produtos = ctx.Produtos.Where(x =>x.IdSolicitante == idSolicitante).ToList();
                return produtos;
            }
        }
    }
}
