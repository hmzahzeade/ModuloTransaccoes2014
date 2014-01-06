using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Conta
    {
        public Conta()
        {
            this.CabecalhoTransaccoes = new List<CabecalhoTransacco>();
            this.Contratos = new List<Contrato>();
        }

        public string CCodConta { get; set; }
        public string CProp_Conta { get; set; }
        public string CTlf_G { get; set; }
        public string CDesgn_Com { get; set; }
        public string CCFax_G { get; set; }
        public string CDesgn_Soc { get; set; }
        public string CSite_Web { get; set; }
        public string CTipo { get; set; }
        public string CCConta_Sup { get; set; }
        public string CIcon_Status { get; set; }
        public string CNIF { get; set; }
        public string CStatus { get; set; }
        public string CCod_IVA { get; set; }
        public string CMotivo { get; set; }
        public Nullable<decimal> CDesc_Prot_Act { get; set; }
        public Nullable<System.DateTime> CData_Ult_Susp { get; set; }
        public string CNivel_Aviso { get; set; }
        public Nullable<System.DateTime> CData_Aviso { get; set; }
        public string CTipo_Reg_Conta { get; set; }
        public Nullable<byte> CGrupo_Comercial_CB { get; set; }
        public Nullable<byte> CGrupo_Cobranca_CB { get; set; }
        public string CDescr { get; set; }
        public Nullable<decimal> CConta_Corr { get; set; }
        public Nullable<decimal> CTTL_CC { get; set; }
        public Nullable<decimal> CConta_Corr_Cl_Act { get; set; }
        public Nullable<decimal> CSaldo_Pendente_Por { get; set; }
        public string CSeg_Merc { get; set; }
        public string COrigem { get; set; }
        public string CServicos_Pot { get; set; }
        public string CTipo_Cl { get; set; }
        public string CIdsirapa { get; set; }
        public string CCentro_Op { get; set; }
        public string CCentro_Op_P { get; set; }
        public string CGrupo_Com { get; set; }
        public Nullable<decimal> CReceita_Anual { get; set; }
        public Nullable<int> CFuncionarios { get; set; }
        public string CMF_R { get; set; }
        public string CMF_N { get; set; }
        public string CMF_CP { get; set; }
        public string CMF_L { get; set; }
        public string CMF_C { get; set; }
        public string CMF_D { get; set; }
        public string CMF_P { get; set; }
        public string CMC_R { get; set; }
        public string CMC_N { get; set; }
        public string CMC_CP { get; set; }
        public string CMC_L { get; set; }
        public string CMC_C { get; set; }
        public string CMC_D { get; set; }
        public string CMC_P { get; set; }
        public string CMR_R { get; set; }
        public string CMR_N { get; set; }
        public string CMR_CP { get; set; }
        public string CMR_L { get; set; }
        public string CMR_C { get; set; }
        public string CMR_D { get; set; }
        public string CMR_P { get; set; }
        public Nullable<byte> CMR_TransPDA { get; set; }
        public string CMR_Lat { get; set; }
        public string CMR_Long { get; set; }
        public string CHorario_Cl { get; set; }
        public Nullable<System.DateTime> CFeriado_Mun { get; set; }
        public string CInfo_Op { get; set; }
        public Nullable<byte> CGrupoFactAux { get; set; }
        public Nullable<byte> CPT { get; set; }
        public Nullable<byte> CTransportador { get; set; }
        public Nullable<byte> CUsufruiDescFer { get; set; }
        public Nullable<byte> CExpedidor { get; set; }
        public string CActividade { get; set; }
        public Nullable<byte> CDestinatario { get; set; }
        public Nullable<byte> CACS { get; set; }
        public string CCAE { get; set; }
        public string CCAEParent { get; set; }
        public string CCodigoAcessoCertidaoParent { get; set; }
        public string CCodigoAcessoCertidao { get; set; }
        public string CCodigoInfarmed { get; set; }
        public string CCodigoInfarmedParent { get; set; }
        public Nullable<System.DateTime> CDataSubstituicaoACS { get; set; }
        public string CDescricaoMotivo { get; set; }
        public string CImplementacaoACS { get; set; }
        public string CNISS { get; set; }
        public string CNISSParent { get; set; }
        public string CEmailGeral { get; set; }
        public string CTipoServico { get; set; }
        public string CNifClPrinc { get; set; }
        public Nullable<System.DateTime> CLastMod { get; set; }
        public Nullable<byte> CPersonalizado { get; set; }
        public string CCliAnterior { get; set; }
        public Nullable<bool> CImportedERP { get; set; }
        public Nullable<System.DateTime> CImportedERPDate { get; set; }
        public Nullable<System.DateTime> CCreatedDate { get; set; }
        public string CCreatedBy { get; set; }
        public Nullable<bool> CEntidadePublica { get; set; }
        public Nullable<System.DateTime> CDataReg { get; set; }
        public string CCodigoCRM { get; set; }
        public Nullable<byte> CDebitoDirecto { get; set; }
        public Nullable<bool> CContaConfirmada { get; set; }
        public string CIntegrationCode { get; set; }
        public string CNIBIBAN { get; set; }
        public string CReferencia { get; set; }
        public Nullable<System.DateTime> CDataConfirmacao { get; set; }
        public Nullable<bool> CFactManual { get; set; }
        public Nullable<bool> CHideFromAmbifac { get; set; }
        public Nullable<bool> CIsDeleted { get; set; }
        public string CID { get; set; }
        public virtual ICollection<CabecalhoTransacco> CabecalhoTransaccoes { get; set; }
        public virtual ICollection<Contrato> Contratos { get; set; }
    }
}
