using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    public class ServicoMap : EntityTypeConfiguration<Servico>
    {
        public ServicoMap()
        {
            this.ToTable("Servico");
            this.HasKey(s => s.IdServico);
            this.Property(s => s.IdServico).HasColumnName("ID_SERVICO");
            this.Property(s => s.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_SERVICO");
            this.Property(s => s.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_SERVICO");
            this.Property(s => s.IdTipoServico).HasColumnName("ID_TIPO_SERVICO");
            this.Property(s => s.StatusServico).HasColumnName("STATUS_SERVICO");
            this.Property(s => s.DetalhesServico).HasColumnName("DETALHES_SERVICO");
        }
    }
}
