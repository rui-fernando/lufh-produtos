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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "TipoServicoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione TipoServicoService.svc ou TipoServicoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class TipoServicoService : ITipoServico
    {
        private TipoServicoRep rep = new TipoServicoRep();
        public void Cadastrar(TipoServico obj)
        {
            rep.Cadastrar(obj);
        }

        public void Editar(TipoServico obj)
        {
            rep.Editar(obj);
        }

        public TipoServico Buscar(long Id)
        {
            return rep.Buscar(Id);
        }


        public List<TipoServico> listar()
        {
            return rep.listar();
        }
    }
}
