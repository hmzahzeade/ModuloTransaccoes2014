using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PDT.DataAccess.Models.Mapping;
using PDT.Data.Models;
using PDT.Data;

namespace PDT.DataAccess.Models
{
    public partial class AmbimedContext : DbContext
    {
        static AmbimedContext()
        {
            Database.SetInitializer<AmbimedContext>(null);
        }

        public AmbimedContext()
            : base("Name=AmbimedContext")
        {
        }

        public DbSet<CabecalhoTransacco> CabecalhoTransaccoes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Contentor> Contentors { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<DetalheTransacco> DetalheTransaccoes { get; set; }
        public DbSet<ItemContrato> ItemContratoes { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Volume> Volumes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Ignore<CabecalhoBrief>();

            modelBuilder.Configurations.Add(new CabecalhoTransaccoMap());
            modelBuilder.Configurations.Add(new ContaMap());
            modelBuilder.Configurations.Add(new ContentorMap());
            modelBuilder.Configurations.Add(new ContratoMap());
            modelBuilder.Configurations.Add(new DetalheTransaccoMap());
            modelBuilder.Configurations.Add(new ItemContratoMap());
            modelBuilder.Configurations.Add(new MotoristaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new VolumeMap());

        }
    }
}
