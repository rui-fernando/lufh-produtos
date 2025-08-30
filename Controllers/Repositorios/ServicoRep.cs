using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorios
{
    public class ServicoRep
    {
        public void Cadastrar(Servico obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Servicos.Add(obj);
                ctx.SaveChanges();
            }
        }

        public Servico Buscar(long Id)
        {
            Servico obj = new Servico();
            using( var ctx = new SistemaContext())
            {
                obj = ctx.Servicos.Find(Id);
            }
            return obj;
        }

        public List<Servico> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var servicos = (from obj in ctx.Servicos select obj).OrderBy(x => x.IdServico).ToList();
                return servicos;
            }
        }
        public void Editar(Servico objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Servico objAntigo = ctx.Servicos.Find(objNovo.IdServico);
                objAntigo.StatusServico = objNovo.StatusServico;
                objAntigo.DetalhesServico = objNovo.DetalhesServico;
                objAntigo.IdFuncionarioEditor = objNovo.IdFuncionarioEditor;

                ctx.SaveChanges();
            }
        }
    }
}
