using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class VolumeMap : EntityTypeConfiguration<Volume>
    {
        public VolumeMap()
        {
            // Primary Key
            this.HasKey(t => t.VlmID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Volume");
            this.Property(t => t.VlmID).HasColumnName("vlmID");
            this.Property(t => t.VlmDescricao).HasColumnName("vlmDescricao");
            this.Property(t => t.VlmActivo).HasColumnName("vlmActivo");
            this.Property(t => t.VlmTransPDA).HasColumnName("vlmTransPDA");
            this.Property(t => t.VlmUltAlteracao).HasColumnName("vlmUltAlteracao");
        }
    }
}
