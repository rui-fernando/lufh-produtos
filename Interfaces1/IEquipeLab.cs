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
    public interface IEquipeLab
    {
        [OperationContract]
        void Cadastrar(EquipeLab obj);

        [OperationContract]
        void EditarSenha(EquipeLab obj);

        [OperationContract]
        void EditarFuncionario(EquipeLab obj);

        [OperationContract]
        void cadastrarSoli(Solicitante obj);

        [OperationContract]
        string gerarMatricula(EquipeLab obj);

        [OperationContract]
        bool emailExist(string email);

        [OperationContract]
        EquipeLab Buscar(long id);

        [OperationContract]
        string BuscarId(long id);

        [OperationContract]
        List<EquipeLab> Usuario();

        [OperationContract]
        void Editar(EquipeLab objNovo);

        [OperationContract]
        void RedefinirSenha(EquipeLab obj);

        [OperationContract]
        EquipeLab BuscarCPFSenha(string cpf, string senha);

        [OperationContract]
        EquipeLab BuscarCPF(string cpf);

        [OperationContract]
        List<EquipeLab> Listar(String cargo);

        [OperationContract]
        List<EquipeLab> ListarStatus(String status);

    }
}
