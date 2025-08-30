using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    public class EquipeLabMap : EntityTypeConfiguration<EquipeLab>
    {
        public EquipeLabMap()
        {
            this.ToTable("Equipe_Lab");
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasColumnName("ID_FUNCIONÁRIO");
            this.Property(e => e.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_EQUIPE");
            this.Property(e => e.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_EQUIPE");
            this.Property(e => e.Nome).HasColumnName("NOME_FUNCIONÁRIO");
            this.Property(e => e.Email).HasColumnName("EMAIL_FUNCIONÁRIO");
            this.Property(e => e.Celular).HasColumnName("CELULAR_FUNCIONÁRIO");
            this.Property(e => e.CPF).HasColumnName("CPF_FUNCIONÁRIO");
            this.Property(e => e.Matricula).HasColumnName("MATRICULA_FUNCIONÁRIO");
            this.Property(e => e.Cargo).HasColumnName("CARGO_FUNCIONÁRIO");
            this.Property(e => e.Senha).HasColumnName("SENHA_FUNCIONÁRIO");
            this.Property(e => e.Salt).HasColumnName("SALT_FUNCIONÁRIO");
        }
    }
}
