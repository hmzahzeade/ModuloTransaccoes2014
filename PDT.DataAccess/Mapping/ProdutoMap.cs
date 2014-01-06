using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.PrdID);

            // Properties
            this.Property(t => t.PrdID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrdNome)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PrdCodLer)
                .HasMaxLength(50);

            this.Property(t => t.PrdServico)
                .HasMaxLength(50);

            this.Property(t => t.PrdFamilia)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PrdGrupo)
                .HasMaxLength(255);

            this.Property(t => t.PrdTipo_Utilizacao)
                .HasMaxLength(255);

            this.Property(t => t.PrdTipo_Transaccao)
                .HasMaxLength(255);

            this.Property(t => t.PrdDescricao)
                .HasMaxLength(255);

            this.Property(t => t.PrdLink_Imagem_Produto)
                .HasMaxLength(255);

            this.Property(t => t.PrdImagem_Produto)
                .HasMaxLength(255);

            this.Property(t => t.PrdTipo_Facturacao_Admitida)
                .HasMaxLength(255);

            this.Property(t => t.PrdCodigo_IVA_Produto)
                .HasMaxLength(255);

            this.Property(t => t.PrdCodigo_IVA_Servico)
                .HasMaxLength(255);

            this.Property(t => t.PrdCodigo_IVA_Utilizacao)
                .HasMaxLength(255);

            this.Property(t => t.PrdCodigoOperacao)
                .HasMaxLength(255);

            this.Property(t => t.PrdCatSPOA)
                .HasMaxLength(255);

            this.Property(t => t.Prdc_digo_CSNC)
                .HasMaxLength(255);

            this.Property(t => t.PrdComissao)
                .HasMaxLength(255);

            this.Property(t => t.PrdDescricao_de_Impressao_para_entrega)
                .HasMaxLength(1000);

            this.Property(t => t.PrdDescricao_para_Relatorios)
                .HasMaxLength(1000);

            this.Property(t => t.PrdRecipiente)
                .HasMaxLength(255);

            this.Property(t => t.PrdRequer_Transacao)
                .HasMaxLength(255);

            this.Property(t => t.PrdProduto_Numero)
                .HasMaxLength(255);

            this.Property(t => t.RefPHCProduto)
                .HasMaxLength(50);

            this.Property(t => t.RefPHCServico)
                .HasMaxLength(50);

            this.Property(t => t.RefPHCUtilizacao)
                .HasMaxLength(50);

            this.Property(t => t.RefPHCTaxaGestaoResiduos)
                .HasMaxLength(50);

            this.Property(t => t.RefPHCExcesso)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Produtos");
            this.Property(t => t.PrdID).HasColumnName("prdID");
            this.Property(t => t.PrdNome).HasColumnName("prdNome");
            this.Property(t => t.PrdCodLer).HasColumnName("prdCodLer");
            this.Property(t => t.PrdServico).HasColumnName("prdServico");
            this.Property(t => t.PrdFamilia).HasColumnName("prdFamilia");
            this.Property(t => t.PrdUltAlteracao).HasColumnName("prdUltAlteracao");
            this.Property(t => t.PrdCod_Int).HasColumnName("prdCod_Int");
            this.Property(t => t.PrdAtivo).HasColumnName("prdAtivo");
            this.Property(t => t.PrdRelevante_Para_Calculo_Objectivos).HasColumnName("prdRelevante_Para_Calculo_Objectivos");
            this.Property(t => t.PrdGrupo).HasColumnName("prdGrupo");
            this.Property(t => t.PrdTipo_Utilizacao).HasColumnName("prdTipo_Utilizacao");
            this.Property(t => t.PrdTipo_Transaccao).HasColumnName("prdTipo_Transaccao");
            this.Property(t => t.PrdVenda_Como_Consumivel_Possivel).HasColumnName("prdVenda_Como_Consumivel_Possivel");
            this.Property(t => t.PrdDescricao).HasColumnName("prdDescricao");
            this.Property(t => t.PrdLink_Imagem_Produto).HasColumnName("prdLink_Imagem_Produto");
            this.Property(t => t.PrdImagem_Produto).HasColumnName("prdImagem_Produto");
            this.Property(t => t.PrdTipo_Facturacao_Admitida).HasColumnName("prdTipo_Facturacao_Admitida");
            this.Property(t => t.PrdTaxa_Getao_Residuos).HasColumnName("prdTaxa_Getao_Residuos");
            this.Property(t => t.PrdObrigatorio_Indicar_Acondicionamento).HasColumnName("prdObrigatorio_Indicar_Acondicionamento");
            this.Property(t => t.PrdCodigo_IVA_Produto).HasColumnName("prdCodigo_IVA_Produto");
            this.Property(t => t.PrdCodigo_IVA_Servico).HasColumnName("prdCodigo_IVA_Servico");
            this.Property(t => t.PrdCodigo_IVA_Utilizacao).HasColumnName("prdCodigo_IVA_Utilizacao");
            this.Property(t => t.PrdExcesso_Peso_Entregue).HasColumnName("prdExcesso_Peso_Entregue");
            this.Property(t => t.PrdExcesso_Peso_Recolhido).HasColumnName("prdExcesso_Peso_Recolhido");
            this.Property(t => t.PrdExcesso_Quantidade_Entregue).HasColumnName("prdExcesso_Quantidade_Entregue");
            this.Property(t => t.PrdExcesso_Quantidade_Recolhida).HasColumnName("prdExcesso_Quantidade_Recolhida");
            this.Property(t => t.PrdPreco_Qtd_Entregue).HasColumnName("prdPreco_Qtd_Entregue");
            this.Property(t => t.PrdPreco_Qtd_Recolhida).HasColumnName("prdPreco_Qtd_Recolhida");
            this.Property(t => t.PrdCodigoOperacao).HasColumnName("prdCodigoOperacao");
            this.Property(t => t.PrdResiduoPerigoso).HasColumnName("prdResiduoPerigoso");
            this.Property(t => t.PrdCatSPOA).HasColumnName("prdCatSPOA");
            this.Property(t => t.PrdCertificado).HasColumnName("prdCertificado");
            this.Property(t => t.Prdc_digo_CSNC).HasColumnName("prdc_digo_CSNC");
            this.Property(t => t.PrdComissao).HasColumnName("prdComissao");
            this.Property(t => t.PrdDescricao_de_Impressao_para_entrega).HasColumnName("prdDescricao_de_Impressao_para_entrega");
            this.Property(t => t.PrdDescricao_para_Relatorios).HasColumnName("prdDescricao_para_Relatorios");
            this.Property(t => t.PrdRecipiente).HasColumnName("prdRecipiente");
            this.Property(t => t.PrdRequer_Transacao).HasColumnName("prdRequer_Transacao");
            this.Property(t => t.PrdTrans_PDA).HasColumnName("prdTrans_PDA");
            this.Property(t => t.PrdVolume).HasColumnName("prdVolume");
            this.Property(t => t.PrdPeso_Sugestao).HasColumnName("prdPeso_Sugestao");
            this.Property(t => t.PrdPeso_tara).HasColumnName("prdPeso_tara");
            this.Property(t => t.PrdProduto_acondiciomamento).HasColumnName("prdProduto_acondiciomamento");
            this.Property(t => t.PrdProduto_Corto_Perfurante).HasColumnName("prdProduto_Corto_Perfurante");
            this.Property(t => t.PrdProduto_Encomenda).HasColumnName("prdProduto_Encomenda");
            this.Property(t => t.PrdProduto_Novo_Servico).HasColumnName("prdProduto_Novo_Servico");
            this.Property(t => t.PrdProduto_Numero).HasColumnName("prdProduto_Numero");
            this.Property(t => t.RefPHCProduto).HasColumnName("RefPHCProduto");
            this.Property(t => t.RefPHCServico).HasColumnName("RefPHCServico");
            this.Property(t => t.RefPHCUtilizacao).HasColumnName("RefPHCUtilizacao");
            this.Property(t => t.RefPHCTaxaGestaoResiduos).HasColumnName("RefPHCTaxaGestaoResiduos");
            this.Property(t => t.RefPHCExcesso).HasColumnName("RefPHCExcesso");
        }
    }
}
