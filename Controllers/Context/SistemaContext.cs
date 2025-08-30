using Controllers.map;
using Controllers.Map;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Context
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=DESKTOP-EKABDE2\\SQLEXPRESS01; Database=lufh_produtos;Integrated Security=True;")
        {

        }

        public DbSet<EquipeLab> Funcionarios { get; set; }
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Solicitacoes> Solicitacoes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<TipoServico> TiposServicos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new EquipeLabMap());
            modelBuilder.Configurations.Add(new SolicitanteMap());
            modelBuilder.Configurations.Add(new SolicitacoesMap());
            modelBuilder.Configurations.Add(new PedidoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ServicoMap());
            modelBuilder.Configurations.Add(new TipoServicoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
