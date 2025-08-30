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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ServicoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ServicoService.svc ou ServicoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ServicoService : IServico
    {
        private ServicoRep rep = new ServicoRep();
        public void Cadastrar(Servico obj)
        {
            rep.Cadastrar(obj);
        }

        public void Editar(Servico obj)
        {
            rep.Editar(obj);
        }

        public Servico Buscar(long Id)
        {
            return rep.Buscar(Id);
        }

        public List<Servico> listar()
        {
            return rep.listar();
        }
    }
}
