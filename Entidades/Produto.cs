using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Produto
    {
        public long IdProduto { get; set; }
        public long IdSolicitante { get; set; }
        public long IdFuncionarioCriador { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public string NomeProduto { get; set; }
        public double PesoProduto { get; set; }
        public string ModeloProduto { get; set; }
        public string StatusProduto { get; set; }
        public string TipoProduto { get; set; }
    }
}
