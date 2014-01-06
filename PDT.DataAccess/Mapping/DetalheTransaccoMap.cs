using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class DetalheTransaccoMap : EntityTypeConfiguration<DetalheTransacco>
    {
        public DetalheTransaccoMap()
        {
            // Primary Key
            this.HasKey(t => t.DtDetalheId);

            // Properties
            this.Property(t => t.DtGuiaID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DtPrdID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DtMDObs)
                .HasMaxLength(255);

            this.Property(t => t.DtItemContrato)
                .HasMaxLength(100);

            this.Property(t => t.DtLer)
                .HasMaxLength(10);

            this.Property(t => t.DtCodOperacao)
                .HasMaxLength(10);

            this.Property(t => t.SfItemID)
                .HasMaxLength(18);

            this.Property(t => t.SfProdutoID)
                .HasMaxLength(18);

            this.Property(t => t.SfContractID)
                .HasMaxLength(18);

            this.Property(t => t.DtRefEncomenda)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("DetalheTransaccoes");
            this.Property(t => t.DtDetalheId).HasColumnName("dtDetalheId");
            this.Property(t => t.DtGuiaID).HasColumnName("dtGuiaID");
            this.Property(t => t.DtPrdID).HasColumnName("dtPrdID");
            this.Property(t => t.DtRecipienteID).HasColumnName("dtRecipienteID");
            this.Property(t => t.DtVolumeID).HasColumnName("dtVolumeID");
            this.Property(t => t.DtQtdEnt).HasColumnName("dtQtdEnt");
            this.Property(t => t.DtQtdRec).HasColumnName("dtQtdRec");
            this.Property(t => t.DtQtdDevS).HasColumnName("dtQtdDevS");
            this.Property(t => t.DtQtdDevD).HasColumnName("dtQtdDevD");
            this.Property(t => t.DtPesoEnt).HasColumnName("dtPesoEnt");
            this.Property(t => t.DtPesoRec).HasColumnName("dtPesoRec");
            this.Property(t => t.DtPesoDevS).HasColumnName("dtPesoDevS");
            this.Property(t => t.DtPesoDevD).HasColumnName("dtPesoDevD");
            this.Property(t => t.DtMDID).HasColumnName("dtMDID");
            this.Property(t => t.DtMDObs).HasColumnName("dtMDObs");
            this.Property(t => t.UltAlteracao).HasColumnName("UltAlteracao");
            this.Property(t => t.DtImportedAmbifac).HasColumnName("dtImportedAmbifac");
            this.Property(t => t.DtNovoProdutoID).HasColumnName("dtNovoProdutoID");
            this.Property(t => t.DtPesoApuradoDestino).HasColumnName("dtPesoApuradoDestino");
            this.Property(t => t.DtItemContrato).HasColumnName("dtItemContrato");
            this.Property(t => t.DtLer).HasColumnName("dtLer");
            this.Property(t => t.DtCodOperacao).HasColumnName("dtCodOperacao");
            this.Property(t => t.SfItemID).HasColumnName("sfItemID");
            this.Property(t => t.SfProdutoID).HasColumnName("sfProdutoID");
            this.Property(t => t.SfContractID).HasColumnName("sfContractID");
            this.Property(t => t.DtRefEncomenda).HasColumnName("dtRefEncomenda");
            this.Property(t => t.DtFacturada).HasColumnName("dtFacturada");

            // Relationships
            this.HasRequired(t => t.CabecalhoTransacco)
                .WithMany(t => t.DetalheTransaccoes)
                .HasForeignKey(d => d.DtGuiaID);
            this.HasRequired(t => t.Contentor)
                .WithMany(t => t.DetalheTransaccoes)
                .HasForeignKey(d => d.DtRecipienteID);
            this.HasRequired(t => t.Produto)
                .WithMany(t => t.DetalheTransaccoes)
                .HasForeignKey(d => d.DtPrdID);
            this.HasRequired(t => t.Volume)
                .WithMany(t => t.DetalheTransaccoes)
                .HasForeignKey(d => d.DtVolumeID);

        }
    }
}
