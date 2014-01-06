using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class ContratoMap : EntityTypeConfiguration<Contrato>
    {
        public ContratoMap()
        {
            // Primary Key
            this.HasKey(t => t.CtsNumeroContrato);

            // Properties
            this.Property(t => t.CtsNumeroContrato)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CtsEstado)
                .HasMaxLength(100);

            this.Property(t => t.CtsCargo_Signatario_Cliente)
                .HasMaxLength(500);

            this.Property(t => t.CtsCod_Int)
                .HasMaxLength(100);

            this.Property(t => t.CtsCodIntCont)
                .HasMaxLength(50);

            this.Property(t => t.CtsCondicoes_Facturacao)
                .IsFixedLength()
                .HasMaxLength(1000);

            this.Property(t => t.CtsCondicoes_Pagamento)
                .HasMaxLength(1000);

            this.Property(t => t.CtsContrato_aberto)
                .HasMaxLength(1000);

            this.Property(t => t.CtsContrato_assinado)
                .HasMaxLength(1000);

            this.Property(t => t.CtsContratoN)
                .HasMaxLength(255);

            this.Property(t => t.CtsDescricao)
                .HasMaxLength(1000);

            this.Property(t => t.CtsDescricaoMotivo)
                .HasMaxLength(1000);

            this.Property(t => t.CtsDesignacao_Comercial)
                .HasMaxLength(500);

            this.Property(t => t.CtsEmpresaIntFact)
                .HasMaxLength(255);

            this.Property(t => t.CtsEntidade_de_Cobranca)
                .HasMaxLength(1000);

            this.Property(t => t.CtsEntidade_de_Facturacao)
                .HasMaxLength(1000);

            this.Property(t => t.CtsEstabelecimento)
                .HasMaxLength(1000);

            this.Property(t => t.CtsGrupoCom)
                .HasMaxLength(1000);

            this.Property(t => t.CtsModalidadePrincipalContrato)
                .HasMaxLength(1000);

            this.Property(t => t.CtsModalidadePrincipalPrestacaoServ)
                .HasMaxLength(1000);

            this.Property(t => t.CtsMotivo)
                .HasMaxLength(1000);

            this.Property(t => t.CtsNotificacao_Vencimento_Proprietario)
                .HasMaxLength(1000);

            this.Property(t => t.CtsOrigem_do_servico)
                .HasMaxLength(1000);

            this.Property(t => t.CtsPontoRecolha)
                .HasMaxLength(1000);

            this.Property(t => t.CtsPrazo_Contrato)
                .HasMaxLength(1000);

            this.Property(t => t.CtsProprietario_Contrato)
                .HasMaxLength(1000);

            this.Property(t => t.CtsSignatario_Cliente)
                .HasMaxLength(1000);

            this.Property(t => t.CtsSignatario_Empresa)
                .HasMaxLength(1000);

            this.Property(t => t.CtsStatus)
                .HasMaxLength(1000);

            this.Property(t => t.CtsTermos_Especiais)
                .HasMaxLength(1000);

            this.Property(t => t.CtsTipoCertificado)
                .HasMaxLength(1000);

            this.Property(t => t.CtsTipoContrato)
                .HasMaxLength(1000);

            this.Property(t => t.CtsTtrans_PDA)
                .HasMaxLength(1000);

            this.Property(t => t.CtsTipoRenovacao)
                .HasMaxLength(1000);

            this.Property(t => t.CtsCreatedBy)
                .HasMaxLength(1000);

            this.Property(t => t.CtsCodigoCRM)
                .HasMaxLength(100);

            this.Property(t => t.CtsCodigoCRMParent)
                .HasMaxLength(100);

            this.Property(t => t.CtsIntegrationCode)
                .HasMaxLength(255);

            this.Property(t => t.CTID)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Contratos");
            this.Property(t => t.CtsNumeroContrato).HasColumnName("ctsNumeroContrato");
            this.Property(t => t.CtsCliente).HasColumnName("ctsCliente");
            this.Property(t => t.CtsDataInicio).HasColumnName("ctsDataInicio");
            this.Property(t => t.CtsDataTermino).HasColumnName("ctsDataTermino");
            this.Property(t => t.CtsEstado).HasColumnName("ctsEstado");
            this.Property(t => t.CtsUltAlteracao).HasColumnName("ctsUltAlteracao");
            this.Property(t => t.CtsRenovacaoAuto).HasColumnName("ctsRenovacaoAuto");
            this.Property(t => t.CtsEmpresaID).HasColumnName("ctsEmpresaID");
            this.Property(t => t.CtsCargo_Signatario_Cliente).HasColumnName("ctsCargo_Signatario_Cliente");
            this.Property(t => t.CtsCertificado).HasColumnName("ctsCertificado");
            this.Property(t => t.CtsCod_Int).HasColumnName("ctsCod_Int");
            this.Property(t => t.CtsCodIntCont).HasColumnName("ctsCodIntCont");
            this.Property(t => t.CtsCondicoes_Facturacao).HasColumnName("ctsCondicoes_Facturacao");
            this.Property(t => t.CtsCondicoes_Pagamento).HasColumnName("ctsCondicoes_Pagamento");
            this.Property(t => t.CtsContrato_aberto).HasColumnName("ctsContrato_aberto");
            this.Property(t => t.CtsContrato_assinado).HasColumnName("ctsContrato_assinado");
            this.Property(t => t.CtsContratoN).HasColumnName("ctsContratoN");
            this.Property(t => t.CtsData_Assinatura_Cliente).HasColumnName("ctsData_Assinatura_Cliente");
            this.Property(t => t.CtsData_Assinatura_Empresa).HasColumnName("ctsData_Assinatura_Empresa");
            this.Property(t => t.CtsDescricao).HasColumnName("ctsDescricao");
            this.Property(t => t.CtsDescricaoMotivo).HasColumnName("ctsDescricaoMotivo");
            this.Property(t => t.CtsDesignacao_Comercial).HasColumnName("ctsDesignacao_Comercial");
            this.Property(t => t.CtsEmpresaIntFact).HasColumnName("ctsEmpresaIntFact");
            this.Property(t => t.CtsEntidade_de_Cobranca).HasColumnName("ctsEntidade_de_Cobranca");
            this.Property(t => t.CtsEntidade_de_Facturacao).HasColumnName("ctsEntidade_de_Facturacao");
            this.Property(t => t.CtsEstabelecimento).HasColumnName("ctsEstabelecimento");
            this.Property(t => t.CtsGrupoCom).HasColumnName("ctsGrupoCom");
            this.Property(t => t.CtsLastMod).HasColumnName("ctsLastMod");
            this.Property(t => t.CtsModalidadePrincipalContrato).HasColumnName("ctsModalidadePrincipalContrato");
            this.Property(t => t.CtsModalidadePrincipalPrestacaoServ).HasColumnName("ctsModalidadePrincipalPrestacaoServ");
            this.Property(t => t.CtsMotivo).HasColumnName("ctsMotivo");
            this.Property(t => t.CtsNotificacao_Vencimento_Proprietario).HasColumnName("ctsNotificacao_Vencimento_Proprietario");
            this.Property(t => t.CtsOrigem_do_servico).HasColumnName("ctsOrigem_do_servico");
            this.Property(t => t.CtsPontoRecolha).HasColumnName("ctsPontoRecolha");
            this.Property(t => t.CtsPrazo_Contrato).HasColumnName("ctsPrazo_Contrato");
            this.Property(t => t.CtsProprietario_Contrato).HasColumnName("ctsProprietario_Contrato");
            this.Property(t => t.CtsSignatario_Cliente).HasColumnName("ctsSignatario_Cliente");
            this.Property(t => t.CtsSignatario_Empresa).HasColumnName("ctsSignatario_Empresa");
            this.Property(t => t.CtsStatus).HasColumnName("ctsStatus");
            this.Property(t => t.CtsTermos_Especiais).HasColumnName("ctsTermos_Especiais");
            this.Property(t => t.CtsTipoCertificado).HasColumnName("ctsTipoCertificado");
            this.Property(t => t.CtsTipoContrato).HasColumnName("ctsTipoContrato");
            this.Property(t => t.CtsTtrans_PDA).HasColumnName("ctsTtrans_PDA");
            this.Property(t => t.CtsTipoRenovacao).HasColumnName("ctsTipoRenovacao");
            this.Property(t => t.CtsDataInicioInactividade).HasColumnName("ctsDataInicioInactividade");
            this.Property(t => t.CtsCreatedDate).HasColumnName("ctsCreatedDate");
            this.Property(t => t.CtsCreatedBy).HasColumnName("ctsCreatedBy");
            this.Property(t => t.CtsCodigoCRM).HasColumnName("ctsCodigoCRM");
            this.Property(t => t.CtsCodigoCRMParent).HasColumnName("ctsCodigoCRMParent");
            this.Property(t => t.CtsIntegrationCode).HasColumnName("ctsIntegrationCode");
            this.Property(t => t.CTIsDeleted).HasColumnName("CTIsDeleted");
            this.Property(t => t.CTID).HasColumnName("CTID");

            // Relationships
            this.HasOptional(t => t.Conta)
                .WithMany(t => t.Contratos)
                .HasForeignKey(d => d.CtsCodIntCont);

        }
    }
}
