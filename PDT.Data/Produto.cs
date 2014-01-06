using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Produto
    {
        public Produto()
        {
            this.DetalheTransaccoes = new List<DetalheTransacco>();
            this.ItemContratoes = new List<ItemContrato>();
        }

        public string PrdID { get; set; }
        public string PrdNome { get; set; }
        public string PrdCodLer { get; set; }
        public string PrdServico { get; set; }
        public string PrdFamilia { get; set; }
        public System.DateTime PrdUltAlteracao { get; set; }
        public Nullable<decimal> PrdCod_Int { get; set; }
        public Nullable<bool> PrdAtivo { get; set; }
        public Nullable<bool> PrdRelevante_Para_Calculo_Objectivos { get; set; }
        public string PrdGrupo { get; set; }
        public string PrdTipo_Utilizacao { get; set; }
        public string PrdTipo_Transaccao { get; set; }
        public Nullable<bool> PrdVenda_Como_Consumivel_Possivel { get; set; }
        public string PrdDescricao { get; set; }
        public string PrdLink_Imagem_Produto { get; set; }
        public string PrdImagem_Produto { get; set; }
        public string PrdTipo_Facturacao_Admitida { get; set; }
        public Nullable<bool> PrdTaxa_Getao_Residuos { get; set; }
        public Nullable<bool> PrdObrigatorio_Indicar_Acondicionamento { get; set; }
        public string PrdCodigo_IVA_Produto { get; set; }
        public string PrdCodigo_IVA_Servico { get; set; }
        public string PrdCodigo_IVA_Utilizacao { get; set; }
        public Nullable<decimal> PrdExcesso_Peso_Entregue { get; set; }
        public Nullable<decimal> PrdExcesso_Peso_Recolhido { get; set; }
        public Nullable<decimal> PrdExcesso_Quantidade_Entregue { get; set; }
        public Nullable<decimal> PrdExcesso_Quantidade_Recolhida { get; set; }
        public Nullable<decimal> PrdPreco_Qtd_Entregue { get; set; }
        public Nullable<decimal> PrdPreco_Qtd_Recolhida { get; set; }
        public string PrdCodigoOperacao { get; set; }
        public Nullable<bool> PrdResiduoPerigoso { get; set; }
        public string PrdCatSPOA { get; set; }
        public Nullable<bool> PrdCertificado { get; set; }
        public string Prdc_digo_CSNC { get; set; }
        public string PrdComissao { get; set; }
        public string PrdDescricao_de_Impressao_para_entrega { get; set; }
        public string PrdDescricao_para_Relatorios { get; set; }
        public string PrdRecipiente { get; set; }
        public string PrdRequer_Transacao { get; set; }
        public Nullable<bool> PrdTrans_PDA { get; set; }
        public Nullable<decimal> PrdVolume { get; set; }
        public Nullable<decimal> PrdPeso_Sugestao { get; set; }
        public Nullable<decimal> PrdPeso_tara { get; set; }
        public Nullable<bool> PrdProduto_acondiciomamento { get; set; }
        public Nullable<bool> PrdProduto_Corto_Perfurante { get; set; }
        public Nullable<bool> PrdProduto_Encomenda { get; set; }
        public Nullable<bool> PrdProduto_Novo_Servico { get; set; }
        public string PrdProduto_Numero { get; set; }
        public string RefPHCProduto { get; set; }
        public string RefPHCServico { get; set; }
        public string RefPHCUtilizacao { get; set; }
        public string RefPHCTaxaGestaoResiduos { get; set; }
        public string RefPHCExcesso { get; set; }
        public virtual ICollection<DetalheTransacco> DetalheTransaccoes { get; set; }
        public virtual ICollection<ItemContrato> ItemContratoes { get; set; }
    }
}
