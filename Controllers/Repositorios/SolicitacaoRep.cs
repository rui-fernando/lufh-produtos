using Controllers.Context;
using Controllers.util;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controllers.Repositorios
{
    public class SolicitacaoRep
    {
        public void Cadastrar(Solicitacoes obj)
        {
            int saltSize = 16;
            string saltUser = Hash.generateSalt(saltSize);

            obj.Senha = Hash.makeHash(obj.Senha, saltUser);
            obj.Salt = saltUser;
            Console.WriteLine("O salt do novo usuário eh igual a: " + saltUser);

            using (var ctx = new SistemaContext())
            {
                ctx.Solicitacoes.Add(obj);
                ctx.SaveChanges();
            }
        }
        public List<Solicitacoes> Listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Solicitacoes = (from obj in ctx.Solicitacoes select obj).Where(x => x.Status == "Pendente").OrderBy(x => x.Id).ToList();
                return Solicitacoes;
            }

        }

        public Solicitacoes Buscar(long id)
        {

            var ctx = new SistemaContext();
            var solicitacao = ctx.Solicitacoes.FirstOrDefault(c => c.Id == id);
            return solicitacao;


        }

        public void modificarStatus(long id, bool aceito)
        {
            var obj = Buscar(id);

            if (aceito)
            {
                obj.Status = "Aceito";
                var ctx = new SistemaContext();
                ctx.Solicitacoes.AddOrUpdate(obj);
                ctx.SaveChanges();
            }
            else
            {
                obj.Status = "Negado";
                var ctx = new SistemaContext();
                ctx.Solicitacoes.AddOrUpdate(obj);
                ctx.SaveChanges();
            }
        }
    }
}
