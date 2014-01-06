using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Contrato
    {
        public Contrato()
        {
            this.ItemContratoes = new List<ItemContrato>();
        }

        public string CtsNumeroContrato { get; set; }
        public Nullable<decimal> CtsCliente { get; set; }
        public Nullable<System.DateTime> CtsDataInicio { get; set; }
        public Nullable<System.DateTime> CtsDataTermino { get; set; }
        public string CtsEstado { get; set; }
        public Nullable<System.DateTime> CtsUltAlteracao { get; set; }
        public Nullable<bool> CtsRenovacaoAuto { get; set; }
        public Nullable<decimal> CtsEmpresaID { get; set; }
        public string CtsCargo_Signatario_Cliente { get; set; }
        public Nullable<bool> CtsCertificado { get; set; }
        public string CtsCod_Int { get; set; }
        public string CtsCodIntCont { get; set; }
        public string CtsCondicoes_Facturacao { get; set; }
        public string CtsCondicoes_Pagamento { get; set; }
        public string CtsContrato_aberto { get; set; }
        public string CtsContrato_assinado { get; set; }
        public string CtsContratoN { get; set; }
        public Nullable<System.DateTime> CtsData_Assinatura_Cliente { get; set; }
        public Nullable<System.DateTime> CtsData_Assinatura_Empresa { get; set; }
        public string CtsDescricao { get; set; }
        public string CtsDescricaoMotivo { get; set; }
        public string CtsDesignacao_Comercial { get; set; }
        public string CtsEmpresaIntFact { get; set; }
        public string CtsEntidade_de_Cobranca { get; set; }
        public string CtsEntidade_de_Facturacao { get; set; }
        public string CtsEstabelecimento { get; set; }
        public string CtsGrupoCom { get; set; }
        public Nullable<System.DateTime> CtsLastMod { get; set; }
        public string CtsModalidadePrincipalContrato { get; set; }
        public string CtsModalidadePrincipalPrestacaoServ { get; set; }
        public string CtsMotivo { get; set; }
        public string CtsNotificacao_Vencimento_Proprietario { get; set; }
        public string CtsOrigem_do_servico { get; set; }
        public string CtsPontoRecolha { get; set; }
        public string CtsPrazo_Contrato { get; set; }
        public string CtsProprietario_Contrato { get; set; }
        public string CtsSignatario_Cliente { get; set; }
        public string CtsSignatario_Empresa { get; set; }
        public string CtsStatus { get; set; }
        public string CtsTermos_Especiais { get; set; }
        public string CtsTipoCertificado { get; set; }
        public string CtsTipoContrato { get; set; }
        public string CtsTtrans_PDA { get; set; }
        public string CtsTipoRenovacao { get; set; }
        public Nullable<System.DateTime> CtsDataInicioInactividade { get; set; }
        public Nullable<System.DateTime> CtsCreatedDate { get; set; }
        public string CtsCreatedBy { get; set; }
        public string CtsCodigoCRM { get; set; }
        public string CtsCodigoCRMParent { get; set; }
        public string CtsIntegrationCode { get; set; }
        public Nullable<bool> CTIsDeleted { get; set; }
        public string CTID { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual ICollection<ItemContrato> ItemContratoes { get; set; }
    }
}
