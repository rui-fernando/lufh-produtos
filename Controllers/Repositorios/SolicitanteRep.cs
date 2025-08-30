using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.repositorios
{
    public class SolicitanteRep
    {
        public void Cadastrar(Solicitante obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Solicitantes.Add(obj);
                ctx.SaveChanges();
            }
        }
        public List<Solicitante> listar()
        {
            using (var ctx = new SistemaContext())
            {
                var solicitantes = (from obj in ctx.Solicitantes select obj).OrderBy(x => x.Id).ToList();
                return solicitantes;
            }

        }
        public Solicitante Buscar(long id)
        {
            Solicitante obj = new Solicitante();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Solicitantes.Find(id);
            }

            return obj;
        }

        public void Editar(Solicitante obj)
        {
            using(var ctx = new SistemaContext())
            {
                Solicitante objAnt = ctx.Solicitantes.Find(obj.Id);

                objAnt.Nome = obj.Nome;
                objAnt.Email = obj.Email;
                objAnt.Celular = obj.Celular;
                objAnt.Documento = obj.Documento;
                objAnt.IdFuncionarioEditor = obj.IdFuncionarioEditor;

                ctx.SaveChanges();
            }
        }
    }


}
