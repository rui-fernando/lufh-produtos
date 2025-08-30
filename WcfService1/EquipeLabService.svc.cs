using Controllers.Repositorios;
using Entidades;
using Interfaces1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class EquipeLabService : IEquipeLab
    {
        private EquipeLabRep rep = new EquipeLabRep();

        public void Cadastrar(EquipeLab obj)
        {
            rep.Cadastrar(obj);
        }

        public void EditarSenha(EquipeLab obj)
        {
            rep.EditarSenha(obj);
        }

        public void EditarFuncionario(EquipeLab obj)
        {
            rep.EditarFuncionario(obj);
        }

        public EquipeLab Buscar(long id)
        {
            return rep.Buscar(id);
        }

        public string BuscarId(long id)
        {
            return rep.BuscarId(id);
        }

        public bool emailExist(string email)
        {
            return rep.emailExist(email);
        }

        public void cadastrarSoli(Solicitante obj)
        {
            rep.cadastrarSoli(obj);
        }

        public string gerarMatricula(EquipeLab obj)
        {
            return rep.gerarMatricula(obj);
        }

        public List<EquipeLab> Usuario()
        {
            return rep.Listar();
        }

        public List<EquipeLab> ListarStatus(String status)
        {
            return rep.ListarStatus(status);
        }

        public void Editar(EquipeLab objNovo)
        {
            rep.Editar(objNovo);
        }

        public void RedefinirSenha(EquipeLab obj)
        {

        }

        public EquipeLab BuscarCPFSenha(string cpf, string senha)
        {
            return rep.BuscarCPFSenha(cpf, senha);
        }
        public EquipeLab BuscarCPF(string cpf)
        {
            return rep.BuscarCPF(cpf);
        }

        public List<EquipeLab> Listar(String cargo)
        {
            return rep.Listar(cargo);
        }
    }
}
