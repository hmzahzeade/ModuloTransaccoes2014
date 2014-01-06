using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class ItemContrato
    {
        public string IcNumeroContrato { get; set; }
        public string IcPrdId { get; set; }
        public string Icoferta { get; set; }
        public string IcAcondicionamento { get; set; }
        public decimal IcQuantidade { get; set; }
        public string IcTipoItem { get; set; }
        public string IcAvenca { get; set; }
        public string IcCodIVA { get; set; }
        public Nullable<bool> IcConsumivel { get; set; }
        public Nullable<System.DateTime> IcDataInicioOferta { get; set; }
        public Nullable<System.DateTime> IcDataFimOferta { get; set; }
        public Nullable<decimal> IcPrecoUnitExcesso { get; set; }
        public Nullable<decimal> IcPrecoUnit { get; set; }
        public string IcPeriodicidadeServico { get; set; }
        public Nullable<System.DateTime> IcDataInicioPreco { get; set; }
        public Nullable<System.DateTime> IcDataFimPreco { get; set; }
        public Nullable<double> IcQtdMinima { get; set; }
        public Nullable<decimal> IcQtdOferta { get; set; }
        public string IcTransporte { get; set; }
        public string IcTipoFact { get; set; }
        public string IcNumero { get; set; }
        public Nullable<System.DateTime> IcDataDeFim { get; set; }
        public Nullable<System.DateTime> IcDataDeIncio { get; set; }
        public Nullable<decimal> IcQtd1entrega { get; set; }
        public Nullable<System.DateTime> IcLastMod { get; set; }
        public string IcCod_Int_Produto { get; set; }
        public string IcN_Contrato { get; set; }
        public string IcProduto { get; set; }
        public string IcEnt_Fact { get; set; }
        public Nullable<System.DateTime> IcData_I { get; set; }
        public Nullable<System.DateTime> IcData_F { get; set; }
        public string IcPer_Serv { get; set; }
        public string IcServico { get; set; }
        public Nullable<decimal> IcPreco_Lista { get; set; }
        public Nullable<decimal> IcPreco_Unitario { get; set; }
        public Nullable<decimal> IcDesc_Campanha { get; set; }
        public Nullable<decimal> IcDesc_Protocolo { get; set; }
        public Nullable<decimal> IcDesc_Comercial { get; set; }
        public Nullable<decimal> IcValor_Contratado { get; set; }
        public Nullable<decimal> IcTotal_Contratado { get; set; }
        public Nullable<bool> IcAp_Taxa_Gestao_Res { get; set; }
        public string IcCod_IVA_Ut { get; set; }
        public string IcTipo_fact_Ut { get; set; }
        public string IcPreco_Unit_Ut { get; set; }
        public string IcPer_Oferta { get; set; }
        public string IcUnidade_Oferta { get; set; }
        public Nullable<decimal> IcQtd_Min { get; set; }
        public string IcUnidade_Qtd_Min { get; set; }
        public Nullable<bool> IcActivo { get; set; }
        public Nullable<System.DateTime> IcDataDeInicio { get; set; }
        public Nullable<System.DateTime> IcDataFimInactividade { get; set; }
        public Nullable<decimal> IcPrecoValidoAteQuantidade { get; set; }
        public string IcDescricao { get; set; }
        public Nullable<System.DateTime> IcDataInicioInactividade { get; set; }
        public Nullable<decimal> IcTaxaGestaoResiduos { get; set; }
        public Nullable<decimal> IcTaxaGestaoResiduosCliente { get; set; }
        public Nullable<System.DateTime> IcDataInicioTaxa { get; set; }
        public Nullable<System.DateTime> IcDataFimTaxa { get; set; }
        public string IcInformacoesSobreDescontoComercial { get; set; }
        public string IcCategoria_SPOA { get; set; }
        public string IcCodigo_Operacao { get; set; }
        public string IcAcondicionamentoIds { get; set; }
        public Nullable<System.DateTime> IcCreatedDate { get; set; }
        public string IcCreatedBy { get; set; }
        public string IcCodigoCRM { get; set; }
        public string IcCodigoCRMParent { get; set; }
        public Nullable<System.DateTime> UltMod { get; set; }
        public string IcPeriodicidadeCalculoExcessos { get; set; }
        public string IcIntegrationCode { get; set; }
        public Nullable<bool> AplicarDescontoTGR { get; set; }
        public Nullable<bool> AplicarDescontoPrecos { get; set; }
        public Nullable<bool> IcIsDeleted { get; set; }
        public string IcID { get; set; }
        public virtual Contrato Contrato { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
