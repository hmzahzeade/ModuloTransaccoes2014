using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            // Primary Key
            this.HasKey(t => t.CCodConta);

            // Properties
            this.Property(t => t.CCodConta)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CProp_Conta)
                .HasMaxLength(1000);

            this.Property(t => t.CTlf_G)
                .HasMaxLength(1000);

            this.Property(t => t.CDesgn_Com)
                .HasMaxLength(1000);

            this.Property(t => t.CCFax_G)
                .HasMaxLength(1000);

            this.Property(t => t.CDesgn_Soc)
                .HasMaxLength(1000);

            this.Property(t => t.CSite_Web)
                .HasMaxLength(1000);

            this.Property(t => t.CTipo)
                .HasMaxLength(1000);

            this.Property(t => t.CCConta_Sup)
                .HasMaxLength(1000);

            this.Property(t => t.CIcon_Status)
                .HasMaxLength(1000);

            this.Property(t => t.CNIF)
                .HasMaxLength(1000);

            this.Property(t => t.CStatus)
                .HasMaxLength(1000);

            this.Property(t => t.CCod_IVA)
                .HasMaxLength(1000);

            this.Property(t => t.CMotivo)
                .HasMaxLength(1000);

            this.Property(t => t.CNivel_Aviso)
                .HasMaxLength(1000);

            this.Property(t => t.CTipo_Reg_Conta)
                .HasMaxLength(1000);

            this.Property(t => t.CDescr)
                .HasMaxLength(1000);

            this.Property(t => t.CSeg_Merc)
                .HasMaxLength(1000);

            this.Property(t => t.COrigem)
                .HasMaxLength(1000);

            this.Property(t => t.CServicos_Pot)
                .HasMaxLength(1000);

            this.Property(t => t.CTipo_Cl)
                .HasMaxLength(1000);

            this.Property(t => t.CIdsirapa)
                .HasMaxLength(1000);

            this.Property(t => t.CCentro_Op)
                .HasMaxLength(1000);

            this.Property(t => t.CCentro_Op_P)
                .HasMaxLength(1000);

            this.Property(t => t.CGrupo_Com)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_R)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_N)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_CP)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_L)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_C)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_D)
                .HasMaxLength(1000);

            this.Property(t => t.CMF_P)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_R)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_N)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_CP)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_L)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_C)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_D)
                .HasMaxLength(1000);

            this.Property(t => t.CMC_P)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_R)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_N)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_CP)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_L)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_C)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_D)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_P)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_Lat)
                .HasMaxLength(1000);

            this.Property(t => t.CMR_Long)
                .HasMaxLength(1000);

            this.Property(t => t.CHorario_Cl)
                .HasMaxLength(1000);

            this.Property(t => t.CInfo_Op)
                .HasMaxLength(1000);

            this.Property(t => t.CActividade)
                .HasMaxLength(1000);

            this.Property(t => t.CCAE)
                .HasMaxLength(1000);

            this.Property(t => t.CCAEParent)
                .HasMaxLength(1000);

            this.Property(t => t.CCodigoAcessoCertidaoParent)
                .HasMaxLength(1000);

            this.Property(t => t.CCodigoAcessoCertidao)
                .HasMaxLength(1000);

            this.Property(t => t.CCodigoInfarmed)
                .HasMaxLength(1000);

            this.Property(t => t.CCodigoInfarmedParent)
                .HasMaxLength(1000);

            this.Property(t => t.CDescricaoMotivo)
                .HasMaxLength(1000);

            this.Property(t => t.CImplementacaoACS)
                .HasMaxLength(1000);

            this.Property(t => t.CNISS)
                .HasMaxLength(1000);

            this.Property(t => t.CNISSParent)
                .HasMaxLength(1000);

            this.Property(t => t.CEmailGeral)
                .HasMaxLength(1000);

            this.Property(t => t.CTipoServico)
                .HasMaxLength(1000);

            this.Property(t => t.CNifClPrinc)
                .HasMaxLength(1000);

            this.Property(t => t.CCliAnterior)
                .HasMaxLength(50);

            this.Property(t => t.CCreatedBy)
                .HasMaxLength(1000);

            this.Property(t => t.CCodigoCRM)
                .HasMaxLength(100);

            this.Property(t => t.CIntegrationCode)
                .HasMaxLength(255);

            this.Property(t => t.CNIBIBAN)
                .HasMaxLength(50);

            this.Property(t => t.CReferencia)
                .HasMaxLength(50);

            this.Property(t => t.CID)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Contas");
            this.Property(t => t.CCodConta).HasColumnName("CCodConta");
            this.Property(t => t.CProp_Conta).HasColumnName("CProp_Conta");
            this.Property(t => t.CTlf_G).HasColumnName("CTlf_G");
            this.Property(t => t.CDesgn_Com).HasColumnName("CDesgn_Com");
            this.Property(t => t.CCFax_G).HasColumnName("CCFax_G");
            this.Property(t => t.CDesgn_Soc).HasColumnName("CDesgn_Soc");
            this.Property(t => t.CSite_Web).HasColumnName("CSite_Web");
            this.Property(t => t.CTipo).HasColumnName("CTipo");
            this.Property(t => t.CCConta_Sup).HasColumnName("CCConta_Sup");
            this.Property(t => t.CIcon_Status).HasColumnName("CIcon_Status");
            this.Property(t => t.CNIF).HasColumnName("CNIF");
            this.Property(t => t.CStatus).HasColumnName("CStatus");
            this.Property(t => t.CCod_IVA).HasColumnName("CCod_IVA");
            this.Property(t => t.CMotivo).HasColumnName("CMotivo");
            this.Property(t => t.CDesc_Prot_Act).HasColumnName("CDesc_Prot_Act");
            this.Property(t => t.CData_Ult_Susp).HasColumnName("CData_Ult_Susp");
            this.Property(t => t.CNivel_Aviso).HasColumnName("CNivel_Aviso");
            this.Property(t => t.CData_Aviso).HasColumnName("CData_Aviso");
            this.Property(t => t.CTipo_Reg_Conta).HasColumnName("CTipo_Reg_Conta");
            this.Property(t => t.CGrupo_Comercial_CB).HasColumnName("CGrupo_Comercial_CB");
            this.Property(t => t.CGrupo_Cobranca_CB).HasColumnName("CGrupo_Cobranca_CB");
            this.Property(t => t.CDescr).HasColumnName("CDescr");
            this.Property(t => t.CConta_Corr).HasColumnName("CConta_Corr");
            this.Property(t => t.CTTL_CC).HasColumnName("CTTL_CC");
            this.Property(t => t.CConta_Corr_Cl_Act).HasColumnName("CConta_Corr_Cl_Act");
            this.Property(t => t.CSaldo_Pendente_Por).HasColumnName("CSaldo_Pendente_Por");
            this.Property(t => t.CSeg_Merc).HasColumnName("CSeg_Merc");
            this.Property(t => t.COrigem).HasColumnName("COrigem");
            this.Property(t => t.CServicos_Pot).HasColumnName("CServicos_Pot");
            this.Property(t => t.CTipo_Cl).HasColumnName("CTipo_Cl");
            this.Property(t => t.CIdsirapa).HasColumnName("CIdsirapa");
            this.Property(t => t.CCentro_Op).HasColumnName("CCentro_Op");
            this.Property(t => t.CCentro_Op_P).HasColumnName("CCentro_Op_P");
            this.Property(t => t.CGrupo_Com).HasColumnName("CGrupo_Com");
            this.Property(t => t.CReceita_Anual).HasColumnName("CReceita_Anual");
            this.Property(t => t.CFuncionarios).HasColumnName("CFuncionarios");
            this.Property(t => t.CMF_R).HasColumnName("CMF_R");
            this.Property(t => t.CMF_N).HasColumnName("CMF_N");
            this.Property(t => t.CMF_CP).HasColumnName("CMF_CP");
            this.Property(t => t.CMF_L).HasColumnName("CMF_L");
            this.Property(t => t.CMF_C).HasColumnName("CMF_C");
            this.Property(t => t.CMF_D).HasColumnName("CMF_D");
            this.Property(t => t.CMF_P).HasColumnName("CMF_P");
            this.Property(t => t.CMC_R).HasColumnName("CMC_R");
            this.Property(t => t.CMC_N).HasColumnName("CMC_N");
            this.Property(t => t.CMC_CP).HasColumnName("CMC_CP");
            this.Property(t => t.CMC_L).HasColumnName("CMC_L");
            this.Property(t => t.CMC_C).HasColumnName("CMC_C");
            this.Property(t => t.CMC_D).HasColumnName("CMC_D");
            this.Property(t => t.CMC_P).HasColumnName("CMC_P");
            this.Property(t => t.CMR_R).HasColumnName("CMR_R");
            this.Property(t => t.CMR_N).HasColumnName("CMR_N");
            this.Property(t => t.CMR_CP).HasColumnName("CMR_CP");
            this.Property(t => t.CMR_L).HasColumnName("CMR_L");
            this.Property(t => t.CMR_C).HasColumnName("CMR_C");
            this.Property(t => t.CMR_D).HasColumnName("CMR_D");
            this.Property(t => t.CMR_P).HasColumnName("CMR_P");
            this.Property(t => t.CMR_TransPDA).HasColumnName("CMR_TransPDA");
            this.Property(t => t.CMR_Lat).HasColumnName("CMR_Lat");
            this.Property(t => t.CMR_Long).HasColumnName("CMR_Long");
            this.Property(t => t.CHorario_Cl).HasColumnName("CHorario_Cl");
            this.Property(t => t.CFeriado_Mun).HasColumnName("CFeriado_Mun");
            this.Property(t => t.CInfo_Op).HasColumnName("CInfo_Op");
            this.Property(t => t.CGrupoFactAux).HasColumnName("CGrupoFactAux");
            this.Property(t => t.CPT).HasColumnName("CPT");
            this.Property(t => t.CTransportador).HasColumnName("CTransportador");
            this.Property(t => t.CUsufruiDescFer).HasColumnName("CUsufruiDescFer");
            this.Property(t => t.CExpedidor).HasColumnName("CExpedidor");
            this.Property(t => t.CActividade).HasColumnName("CActividade");
            this.Property(t => t.CDestinatario).HasColumnName("CDestinatario");
            this.Property(t => t.CACS).HasColumnName("CACS");
            this.Property(t => t.CCAE).HasColumnName("CCAE");
            this.Property(t => t.CCAEParent).HasColumnName("CCAEParent");
            this.Property(t => t.CCodigoAcessoCertidaoParent).HasColumnName("CCodigoAcessoCertidaoParent");
            this.Property(t => t.CCodigoAcessoCertidao).HasColumnName("CCodigoAcessoCertidao");
            this.Property(t => t.CCodigoInfarmed).HasColumnName("CCodigoInfarmed");
            this.Property(t => t.CCodigoInfarmedParent).HasColumnName("CCodigoInfarmedParent");
            this.Property(t => t.CDataSubstituicaoACS).HasColumnName("CDataSubstituicaoACS");
            this.Property(t => t.CDescricaoMotivo).HasColumnName("CDescricaoMotivo");
            this.Property(t => t.CImplementacaoACS).HasColumnName("CImplementacaoACS");
            this.Property(t => t.CNISS).HasColumnName("CNISS");
            this.Property(t => t.CNISSParent).HasColumnName("CNISSParent");
            this.Property(t => t.CEmailGeral).HasColumnName("CEmailGeral");
            this.Property(t => t.CTipoServico).HasColumnName("CTipoServico");
            this.Property(t => t.CNifClPrinc).HasColumnName("CNifClPrinc");
            this.Property(t => t.CLastMod).HasColumnName("CLastMod");
            this.Property(t => t.CPersonalizado).HasColumnName("CPersonalizado");
            this.Property(t => t.CCliAnterior).HasColumnName("CCliAnterior");
            this.Property(t => t.CImportedERP).HasColumnName("CImportedERP");
            this.Property(t => t.CImportedERPDate).HasColumnName("CImportedERPDate");
            this.Property(t => t.CCreatedDate).HasColumnName("CCreatedDate");
            this.Property(t => t.CCreatedBy).HasColumnName("CCreatedBy");
            this.Property(t => t.CEntidadePublica).HasColumnName("CEntidadePublica");
            this.Property(t => t.CDataReg).HasColumnName("CDataReg");
            this.Property(t => t.CCodigoCRM).HasColumnName("CCodigoCRM");
            this.Property(t => t.CDebitoDirecto).HasColumnName("CDebitoDirecto");
            this.Property(t => t.CContaConfirmada).HasColumnName("CContaConfirmada");
            this.Property(t => t.CIntegrationCode).HasColumnName("cIntegrationCode");
            this.Property(t => t.CNIBIBAN).HasColumnName("CNIBIBAN");
            this.Property(t => t.CReferencia).HasColumnName("CReferencia");
            this.Property(t => t.CDataConfirmacao).HasColumnName("CDataConfirmacao");
            this.Property(t => t.CFactManual).HasColumnName("CFactManual");
            this.Property(t => t.CHideFromAmbifac).HasColumnName("CHideFromAmbifac");
            this.Property(t => t.CIsDeleted).HasColumnName("CIsDeleted");
            this.Property(t => t.CID).HasColumnName("CID");
        }
    }
}
