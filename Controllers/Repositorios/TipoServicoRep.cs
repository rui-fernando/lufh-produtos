using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorios
{
    public class TipoServicoRep
    {
        public void Cadastrar(TipoServico obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.TiposServicos.Add(obj);
                ctx.SaveChanges();
            }
        }

        public TipoServico Buscar(long Id)
        {
            TipoServico obj = new TipoServico();
            using(var ctx = new SistemaContext())
            {
                obj = ctx.TiposServicos.Find(Id);
            }
            return obj;
        }

        public List<TipoServico> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var servicos = (from obj in ctx.TiposServicos select obj).OrderBy(x => x.IdTipoServico).ToList();
                return servicos;
            }

        }
        public void Editar(TipoServico objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                TipoServico objAntigo = ctx.TiposServicos.Find(objNovo.IdTipoServico);
                objAntigo.NomeTipoServico = objNovo.NomeTipoServico;
                objAntigo.DetalheTipoServico = objNovo.DetalheTipoServico;
                objAntigo.IdFuncionarioEditor = objNovo.IdFuncionarioEditor;

                ctx.SaveChanges();
            }
        }
    }
}
