using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class MotoristaMap : EntityTypeConfiguration<Motorista>
    {
        public MotoristaMap()
        {
            // Primary Key
            this.HasKey(t => t.MotID);

            // Properties
            this.Property(t => t.MotNomeCompleto)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Motorista");
            this.Property(t => t.MotID).HasColumnName("motID");
            this.Property(t => t.MotNomeCompleto).HasColumnName("motNomeCompleto");
            this.Property(t => t.MotUnidadeRecolha).HasColumnName("motUnidadeRecolha");
            this.Property(t => t.MotNumPHC).HasColumnName("motNumPHC");
            this.Property(t => t.MotActivo).HasColumnName("motActivo");
            this.Property(t => t.MotAssinatura).HasColumnName("motAssinatura");
            this.Property(t => t.MotTipoFuncao).HasColumnName("motTipoFuncao");
        }
    }
}
