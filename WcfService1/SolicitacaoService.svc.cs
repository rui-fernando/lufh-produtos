using Controllers.Repositorios;
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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "SolicitacaoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione SolicitacaoService.svc ou SolicitacaoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class SolicitacaoService : ISolicitacao
    {
        private SolicitacaoRep rep = new SolicitacaoRep();

        public void Cadastrar(Solicitacoes obj)
        {
            rep.Cadastrar(obj);
        }


        public List<Solicitacoes> listar()
        {
            return rep.Listar();
        }

        public Solicitacoes buscar(long id)
        {
            return rep.Buscar(id);
        }

        public void modificarStatus(long id, bool aceito)
        {
            rep.modificarStatus(id, aceito);
        }
    }
}
