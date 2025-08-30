using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Servico
    {
        public long IdServico { get; set; }
        public string StatusServico { get; set; }
        public long IdFuncionarioCriador { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public string DetalhesServico { get; set; }
        public long IdTipoServico { get; set; }
    }
}
