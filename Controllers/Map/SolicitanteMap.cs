using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    public class SolicitanteMap : EntityTypeConfiguration<Solicitante>
    {
        public SolicitanteMap()
        {
            this.ToTable("Solicitante");
            this.HasKey(s => s.Id);
            this.Property(s => s.Id).HasColumnName("ID_SOLICITANTE");
            this.Property(s => s.Nome).HasColumnName("NOME_SOLICITANTE");
            this.Property(s => s.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_SOLICITANTE");
            this.Property(s => s.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_SOLICITANTE");
            this.Property(s => s.StatusSolicitante).HasColumnName("STATUS_SOLICITANTE");
            this.Property(s => s.Email).HasColumnName("EMAIL_SOLICITANTE");
            this.Property(s => s.Celular).HasColumnName("CELULAR_SOLICITADOR");
            this.Property(s => s.Documento).HasColumnName("DOCUMENTO_SOLICITANTE");
        }
    }
}
