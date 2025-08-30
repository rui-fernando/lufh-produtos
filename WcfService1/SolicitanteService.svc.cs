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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "SolicitanteService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione SolicitanteService.svc ou SolicitanteService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class SolicitanteService : ISolicitante
    {
        private SolicitanteRep rep = new SolicitanteRep();
        public void Cadastrar(Solicitante obj)
        {
            rep.Cadastrar(obj);
        }

        public void Editar(Solicitante obj)
        {
            rep.Editar(obj);
        }

        public List<Solicitante> listar()
        {
            return rep.listar();
        }

        public Solicitante Buscar(long Id)
        {
            return rep.Buscar(Id);
        }
    }
}
