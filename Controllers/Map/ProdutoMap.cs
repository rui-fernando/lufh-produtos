using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.ToTable("Produto");
            this.HasKey(p => p.IdProduto);
            this.Property(p => p.IdProduto).HasColumnName("ID_PRODUTO");
            this.Property(p => p.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_PRODUTO");
            this.Property(p => p.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_PRODUTO");
            this.Property(p => p.NomeProduto).HasColumnName("NOME_PRODUTO");
            this.Property(p => p.StatusProduto).HasColumnName("STATUS_PRODUTO");
            this.Property(p => p.IdSolicitante).HasColumnName("ID_SOLICITANTE");
            this.Property(p => p.ModeloProduto).HasColumnName("MODELO_PRODUTO");
            this.Property(p => p.PesoProduto).HasColumnName("PESO_PRODUTO");
            this.Property(p => p.TipoProduto).HasColumnName("TIPO_PRODUTO");
        }
    }
}
