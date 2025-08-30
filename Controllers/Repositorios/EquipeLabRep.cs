using Controllers.Context;
using Controllers.util;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class EquipeLabRep
    {
        public void Cadastrar(EquipeLab obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Funcionarios.Add(obj);
                ctx.SaveChanges();
            }
        }

        public void cadastrarSoli(Solicitante obj)
        {
            try
            {
                using (var ctx = new SistemaContext())
                {
                    ctx.Solicitantes.Add(obj);
                    ctx.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Detalhes: {ex.InnerException.Message}");
                }
            }
        }

        public string gerarMatricula(EquipeLab obj)
        {
            String matriculaT;

            if (obj.Cargo == "Admin")
            {
                matriculaT = "001" + (obj.Id);
            }
            else if (obj.Cargo == "Coordenador")
            {
                matriculaT = "002" + (obj.Id);
            }
            else if (obj.Cargo == "Especialista")
            {
                matriculaT = "003" + (obj.Id);
            }
            else
            {
                matriculaT = "004" + (obj.Id);
            }

            return matriculaT;
        }

        public void Editar(EquipeLab objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                EquipeLab objAntigo = ctx.Funcionarios.Find(objNovo.Id);

                objAntigo.Email = objNovo.Email;
                objAntigo.Celular = objNovo.Celular;

                ctx.SaveChanges();
            }
        }

        public void EditarFuncionario(EquipeLab objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                EquipeLab objAntigo = ctx.Funcionarios.Find(objNovo.Id);

                objAntigo.Cargo = objNovo.Cargo;
                objAntigo.Matricula = objNovo.Matricula;
                objAntigo.IdFuncionarioEditor = objNovo.IdFuncionarioEditor;
                objAntigo.StatusEquipe = objNovo.StatusEquipe;

                ctx.SaveChanges();
            }
        }

        public void EditarSenha(EquipeLab objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                EquipeLab objAntigo = ctx.Funcionarios.Find(objNovo.Id);

                int saltSize = 16;
                string saltUser = Hash.generateSalt(saltSize);

                objAntigo.Senha = Hash.makeHash(objNovo.Senha, saltUser);
                objAntigo.Salt = saltUser;

                ctx.SaveChanges();
            }
        }

        public EquipeLab Buscar(long id) // usar CPF como parâmetro no ID
        {
            EquipeLab obj = new EquipeLab();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Funcionarios.Find(id);
            }

            return obj;
        }

        public List<EquipeLab> Listar() // lista os funcionários por nome
        {
            using (var ctx = new SistemaContext())
            {
                var Funcionarios = (from obj in ctx.Funcionarios select obj).OrderBy(x => x.Nome).ToList();

                return Funcionarios;
            }
        }

        public List<EquipeLab> Listar(String cargo) // lista os funcionários pelo cargo e ordena pelo nome
        {
            using (var ctx = new SistemaContext())
            {
                var Funcionarios = (from obj in ctx.Funcionarios
                                    where obj.Cargo == cargo && obj.StatusEquipe == "Cadastrado"
                                    orderby obj.Nome
                                    select obj).ToList();

                return Funcionarios;
            }
        }

        public List<EquipeLab> ListarStatus(String status) // lista os funcionários pelo cargo e ordena pelo nome
        {
            using (var ctx = new SistemaContext())
            {
                var Funcionarios = (from obj in ctx.Funcionarios select obj).Where(x => x.StatusEquipe == status).OrderBy(x => x.Nome).ToList();

                return Funcionarios;
            }
        }

        public Boolean emailExist(string email)
        {
            Boolean emailExiste = false;

            using (var ctx = new SistemaContext())
            {
                EquipeLab obj = new EquipeLab();

                obj = ctx.Funcionarios.FirstOrDefault(u => u.Email.Equals(email));

                if (obj != null)
                {
                    emailExiste = true;

                    UsuarioAtual.UsuarioId = obj.Id;
                }
            }
            return emailExiste;
        }
        public EquipeLab BuscarCPFSenha(string cpf, string senha)
        {
            EquipeLab obj = new EquipeLab();
            using (var ctx = new SistemaContext())
            {
                // Busca o usuário pelo CPF
                obj = ctx.Funcionarios.FirstOrDefault(u => u.CPF.Equals(cpf));
                if (obj != null)
                {
                    // Verificar se a senha fornecida corresponde ao hash armazenado
                    if (Hash.verifyPassword(senha, obj.Salt, obj.Senha))
                    {
                        // Senha correta, retornar o usuário encontrado
                        return obj;
                    }
                }
                return null;
            }
        }
        public EquipeLab BuscarCPF(string cpf)
        {
            EquipeLab obj = new EquipeLab();
            using (var ctx = new SistemaContext())
            {
                // Busca o usuário pelo CPF
                obj = ctx.Funcionarios.FirstOrDefault(u => u.CPF.Equals(cpf));
                return obj;
            }

        }
        public string BuscarId(long id) // usar CPF como parâmetro no ID
        {
            EquipeLab obj = new EquipeLab();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Funcionarios.Find(id);
            }

            return obj.Nome;
        }

    }
}
