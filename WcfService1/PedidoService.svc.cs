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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "PedidoService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione PedidoService.svc ou PedidoService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class PedidoService : IPedido
    {
        private PedidoRep rep = new PedidoRep();
        public void Cadastrar(Pedido obj)
        {
            rep.Cadastrar(obj);
        }

        public void Editar(Pedido obj)
        {
            rep.Editar(obj);
        }

        public Pedido Buscar(long Id)
        {
            return rep.Buscar(Id);
        }

        public List<Pedido> listar()
        {
            return rep.listar();
        }

    }
}
