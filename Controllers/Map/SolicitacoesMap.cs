using System;
using Entidades;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Controllers.Map
{
    public class SolicitacoesMap : EntityTypeConfiguration<Solicitacoes>
    {
        public SolicitacoesMap()
        {
            this.ToTable("Solicitacoes");
            this.HasKey(s => s.Id);
            this.Property(s => s.Id).HasColumnName("ID_FUNCIONÁRIO_SOLICITANTE");
            this.Property(e => e.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_SOLICITACOES");
            this.Property(s => s.Nome).HasColumnName("NOME_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.Email).HasColumnName("EMAIL_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.Celular).HasColumnName("CELULAR_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.CPF).HasColumnName("CPF_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.Status).HasColumnName("STATUS_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.Senha).HasColumnName("SENHA_FUNCIONÁRIO_SOLICITANTE");
            this.Property(s => s.Salt).HasColumnName("SALT_FUNCIONÁRIO_SOLICITANTE");
        }
    }
}
