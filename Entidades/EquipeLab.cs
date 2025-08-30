using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipeLab : Usuario
    {
        public long IdFuncionarioCriador { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public string StatusEquipe { get; set; }
    }
}
