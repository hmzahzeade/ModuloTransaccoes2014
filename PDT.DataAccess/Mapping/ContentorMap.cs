using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class ContentorMap : EntityTypeConfiguration<Contentor>
    {
        public ContentorMap()
        {
            // Primary Key
            this.HasKey(t => t.ConID);

            // Properties
            this.Property(t => t.ConContentor)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ConOutros)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Contentor");
            this.Property(t => t.ConID).HasColumnName("conID");
            this.Property(t => t.ConContentor).HasColumnName("conContentor");
            this.Property(t => t.ConOutros).HasColumnName("conOutros");
            this.Property(t => t.ConActivo).HasColumnName("conActivo");
            this.Property(t => t.ConTransPDA).HasColumnName("conTransPDA");
            this.Property(t => t.UltAlteracao).HasColumnName("ultAlteracao");
        }
    }
}
