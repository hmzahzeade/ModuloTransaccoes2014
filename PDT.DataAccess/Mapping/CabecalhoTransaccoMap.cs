using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class CabecalhoTransaccoMap : EntityTypeConfiguration<CabecalhoTransacco>
    {
        public CabecalhoTransaccoMap()
        {

           

            // Primary Key
            this.HasKey(t => t.CtGuiaID);

            // Properties
            this.Property(t => t.CtGuiaID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CtMatricula)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.CtClienteID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CtLocCarga)
                .HasMaxLength(50);

            this.Property(t => t.CtObs)
                .HasMaxLength(255);

            this.Property(t => t.CtMAObs)
                .HasMaxLength(255);

            this.Property(t => t.CtCliNome)
                .HasMaxLength(40);

            this.Property(t => t.CtDecExp)
                .HasMaxLength(100);

            this.Property(t => t.CtDecDest)
                .HasMaxLength(100);

            this.Property(t => t.CtDecTransp)
                .HasMaxLength(100);

            this.Property(t => t.CtNumContrato)
                .HasMaxLength(50);

            this.Property(t => t.CtGuiaParent)
                .HasMaxLength(20);

            this.Property(t => t.CtModifiedBy)
                .HasMaxLength(100);

            this.Property(t => t.CtAnuladoPor)
                .HasMaxLength(100);

            this.Property(t => t.CtOrigem)
                .HasMaxLength(50);

            this.Property(t => t.CtGuiaOriginal)
                .HasMaxLength(50);

            this.Property(t => t.CtCreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.CtContrato)
                .HasMaxLength(50);

            this.Property(t => t.SfAccountID)
                .HasMaxLength(18);

            this.Property(t => t.SfSourceAccountID)
                .HasMaxLength(18);

            this.Property(t => t.SfTargetAccountID)
                .HasMaxLength(18);

            this.Property(t => t.SfCarrierAccountID)
                .HasMaxLength(18);

            this.Property(t => t.SfContractID)
                .HasMaxLength(18);

            this.Property(t => t.CtTipoTran)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("CabecalhoTransaccoes");
            this.Property(t => t.CtGuiaID).HasColumnName("CtGuiaID");
            this.Property(t => t.CtRotaID).HasColumnName("ctRotaID");
            this.Property(t => t.CtMotID).HasColumnName("ctMotID");
            this.Property(t => t.CtMatricula).HasColumnName("ctMatricula");
            this.Property(t => t.CtClienteID).HasColumnName("ctClienteID");
            this.Property(t => t.CtEmpTransp).HasColumnName("ctEmpTransp");
            this.Property(t => t.CtEmpDest).HasColumnName("ctEmpDest");
            this.Property(t => t.CtEmpExp).HasColumnName("ctEmpExp");
            this.Property(t => t.CtLocDesc).HasColumnName("ctLocDesc");
            this.Property(t => t.CtLocCarga).HasColumnName("ctLocCarga");
            this.Property(t => t.CtDataIni).HasColumnName("ctDataIni");
            this.Property(t => t.CtDataFim).HasColumnName("ctDataFim");
            this.Property(t => t.CtOtrID).HasColumnName("ctOtrID");
            this.Property(t => t.CtObs).HasColumnName("ctObs");
            this.Property(t => t.CtMAID).HasColumnName("ctMAID");
            this.Property(t => t.CtMAObs).HasColumnName("ctMAObs");
            this.Property(t => t.CtAssCli).HasColumnName("ctAssCli");
            this.Property(t => t.CtCliNome).HasColumnName("ctCliNome");
            this.Property(t => t.CtDocImp).HasColumnName("ctDocImp");
            this.Property(t => t.CtDecExp).HasColumnName("ctDecExp");
            this.Property(t => t.CtDecDest).HasColumnName("ctDecDest");
            this.Property(t => t.CtDecTransp).HasColumnName("ctDecTransp");
            this.Property(t => t.UltAlteracao).HasColumnName("UltAlteracao");
            this.Property(t => t.CtTransporte).HasColumnName("ctTransporte");
            this.Property(t => t.CtPesoGIII).HasColumnName("ctPesoGIII");
            this.Property(t => t.CtPesoGIV).HasColumnName("ctPesoGIV");
            this.Property(t => t.CtNumContrato).HasColumnName("ctNumContrato");
            this.Property(t => t.CtGuiaEliminada).HasColumnName("ctGuiaEliminada");
            this.Property(t => t.Facturada).HasColumnName("Facturada");
            this.Property(t => t.CtGuiaParent).HasColumnName("ctGuiaParent");
            this.Property(t => t.CtModifiedBy).HasColumnName("ctModifiedBy");
            this.Property(t => t.CtModifiedDate).HasColumnName("ctModifiedDate");
            this.Property(t => t.CtGuiaManual).HasColumnName("ctGuiaManual");
            this.Property(t => t.CtAterro).HasColumnName("ctAterro");
            this.Property(t => t.CtIsClone).HasColumnName("ctIsClone");
            this.Property(t => t.CtTransporteUrgente).HasColumnName("ctTransporteUrgente");
            this.Property(t => t.CtDataFacturacao).HasColumnName("ctDataFacturacao");
            this.Property(t => t.CtAnuladoPor).HasColumnName("ctAnuladoPor");
            this.Property(t => t.CtDataAnulacao).HasColumnName("ctDataAnulacao");
            this.Property(t => t.CtEnviadoCliente).HasColumnName("ctEnviadoCliente");
            this.Property(t => t.CtDataEnvioCliente).HasColumnName("ctDataEnvioCliente");
            this.Property(t => t.CtOrigem).HasColumnName("ctOrigem");
            this.Property(t => t.CtGuiaOriginal).HasColumnName("ctGuiaOriginal");
            this.Property(t => t.CtExportarLegacy).HasColumnName("ctExportarLegacy");
            this.Property(t => t.CtSyncedRO).HasColumnName("ctSyncedRO");
            this.Property(t => t.CtCreatedBy).HasColumnName("ctCreatedBy");
            this.Property(t => t.CtCreatedDate).HasColumnName("ctCreatedDate");
            this.Property(t => t.CtContrato).HasColumnName("ctContrato");
            this.Property(t => t.CtConfirmada).HasColumnName("ctConfirmada");
            this.Property(t => t.SfAccountID).HasColumnName("sfAccountID");
            this.Property(t => t.SfSourceAccountID).HasColumnName("sfSourceAccountID");
            this.Property(t => t.SfTargetAccountID).HasColumnName("sfTargetAccountID");
            this.Property(t => t.SfCarrierAccountID).HasColumnName("sfCarrierAccountID");
            this.Property(t => t.SfContractID).HasColumnName("sfContractID");
            this.Property(t => t.CtUnidade).HasColumnName("ctUnidade");
            this.Property(t => t.CtTipoTran).HasColumnName("ctTipoTran");
            // Relationships
            this.HasRequired(t => t.Conta)
                .WithMany(t => t.CabecalhoTransaccoes)
                .HasForeignKey(d => d.CtClienteID);

            


        }
    }
}
