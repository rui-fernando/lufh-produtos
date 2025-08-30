using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.map
{
    public class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap() 
        {
            this.ToTable("Pedido");
            this.HasKey(p => p.IdPedido);
            this.Property(p => p.IdPedido).HasColumnName("ID_PEDIDO");
            this.Property(p => p.IdFuncionarioCriador).HasColumnName("ID_FUNCIONARIO_CRIADOR_PEDIDO");
            this.Property(p => p.IdFuncionarioEditor).HasColumnName("ID_FUNCIONARIO_EDITOR_PEDIDO");
            this.Property(p => p.IdSolicitante).HasColumnName("ID_SOLICITANTE");
            this.Property(p => p.IdProduto).HasColumnName("ID_PRODUTO");
            this.Property(p => p.IdTipoServico).HasColumnName("ID_TIPO_SERVICO");
            this.Property(p => p.StatusPedido).HasColumnName("STATUS_PEDIDO");
            this.Property(p => p.DataPedido).HasColumnName("DATA_PEDIDO");
            this.Property(p => p.ObservacaoPedido).HasColumnName("OBSERVACAO_PEDIDO");
            this.Property(p => p.OrdemServico).HasColumnName("ORDEM_SERVICO");
        }
    }
}
