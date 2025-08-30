using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Solicitacoes : Usuario
    {
        public long IdFuncionarioEditor { get; set; }
        public string CPF { get; set; }
        public string Status { get; set; }
    }
}
