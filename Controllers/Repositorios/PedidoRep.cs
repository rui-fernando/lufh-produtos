using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorios
{
    public class PedidoRep
    {
        public void Cadastrar(Pedido obj)
        {
            using( var ctx = new SistemaContext())
            {
                ctx.Pedidos.Add(obj);
                ctx.SaveChanges();
            }
        }

        public Pedido Buscar(long Id)
        {
            Pedido obj = new Pedido();
            using(var ctx = new SistemaContext())
            {
                obj = ctx.Pedidos.Find(Id);
            }
            return obj;
        }

        public void Editar(Pedido objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Pedido objAnt = ctx.Pedidos.Find(objNovo.IdPedido);

                objAnt.StatusPedido = objNovo.StatusPedido;
                objAnt.ObservacaoPedido = objNovo.ObservacaoPedido;
                objAnt.IdFuncionarioEditor = objNovo.IdFuncionarioEditor;
                objAnt.OrdemServico = objNovo.OrdemServico;

                ctx.SaveChanges();
            }

        }

        public List<Pedido> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var pedidos = (from obj in ctx.Pedidos select obj).OrderBy(x => x.IdPedido).ToList();
                return pedidos;
            }
        }
    }
}
