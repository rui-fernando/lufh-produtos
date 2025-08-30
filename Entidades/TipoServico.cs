using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoServico
    {
        public long IdTipoServico { get; set; }
        public long IdFuncionarioCriador { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public string NomeTipoServico { get; set; }
        public string StatusTipoServico { get; set; }
        public string DetalheTipoServico { get; set; }
    }
}
