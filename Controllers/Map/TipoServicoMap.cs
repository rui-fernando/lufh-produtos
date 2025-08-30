using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    public class TipoServicoMap : EntityTypeConfiguration<TipoServico>
    {
        public TipoServicoMap()
        {
            this.ToTable("Tipo_Servico");
            this.HasKey(t => t.IdTipoServico);
            this.Property(t => t.IdTipoServico).HasColumnName("ID_TIPO_SERVICO");
            this.Property(t => t.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_TIPO_SERVICO");
            this.Property(t => t.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_TIPO_SERVICO");
            this.Property(t => t.NomeTipoServico).HasColumnName("NOME_TIPO_SERVICO");
            this.Property(t => t.StatusTipoServico).HasColumnName("STATUS_TIPO_SERVICO");
            this.Property(t => t.DetalheTipoServico).HasColumnName("DETALHE_TIPO_SERVICO");
        }
    }
}
