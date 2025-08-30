using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public long IdPedido { get; set; }
        public long IdSolicitante { get; set; }
        public long IdFuncionarioCriador { get; set; }
        public long IdProduto { get; set; }
        public long IdTipoServico { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public DateTime DataPedido { get; set; }
        public string OrdemServico { get; set; }
        public string StatusPedido { get; set; }
        public string ObservacaoPedido { get; set; }
    }
}
