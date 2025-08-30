using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Solicitante
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public long IdFuncionarioCriador { get; set; }
        public long IdFuncionarioEditor { get; set; }
        public string StatusSolicitante { get; set; }
        public string Documento { get; set; }
    }
}
