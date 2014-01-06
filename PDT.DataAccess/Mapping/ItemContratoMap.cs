using PDT.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PDT.DataAccess.Models.Mapping
{
    public class ItemContratoMap : EntityTypeConfiguration<ItemContrato>
    {
        public ItemContratoMap()
        {
            // Primary Key
            this.HasKey(t => t.IcNumero);

            // Properties
            this.Property(t => t.IcNumeroContrato)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IcPrdId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Icoferta)
                .HasMaxLength(50);

            this.Property(t => t.IcAcondicionamento)
                .HasMaxLength(1000);

            this.Property(t => t.IcTipoItem)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IcAvenca)
                .HasMaxLength(50);

            this.Property(t => t.IcCodIVA)
                .HasMaxLength(50);

            this.Property(t => t.IcPeriodicidadeServico)
                .HasMaxLength(25);

            this.Property(t => t.IcTransporte)
                .HasMaxLength(50);

            this.Property(t => t.IcTipoFact)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.IcNumero)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IcCod_Int_Produto)
                .HasMaxLength(255);

            this.Property(t => t.IcN_Contrato)
                .HasMaxLength(255);

            this.Property(t => t.IcProduto)
                .HasMaxLength(255);

            this.Property(t => t.IcEnt_Fact)
                .HasMaxLength(255);

            this.Property(t => t.IcPer_Serv)
                .HasMaxLength(255);

            this.Property(t => t.IcServico)
                .HasMaxLength(255);

            this.Property(t => t.IcCod_IVA_Ut)
                .HasMaxLength(255);

            this.Property(t => t.IcTipo_fact_Ut)
                .HasMaxLength(255);

            this.Property(t => t.IcPreco_Unit_Ut)
                .HasMaxLength(255);

            this.Property(t => t.IcPer_Oferta)
                .HasMaxLength(255);

            this.Property(t => t.IcUnidade_Oferta)
                .HasMaxLength(255);

            this.Property(t => t.IcUnidade_Qtd_Min)
                .HasMaxLength(255);

            this.Property(t => t.IcDescricao)
                .HasMaxLength(255);

            this.Property(t => t.IcInformacoesSobreDescontoComercial)
                .HasMaxLength(255);

            this.Property(t => t.IcCategoria_SPOA)
                .HasMaxLength(255);

            this.Property(t => t.IcCodigo_Operacao)
                .HasMaxLength(255);

            this.Property(t => t.IcAcondicionamentoIds)
                .HasMaxLength(1000);

            this.Property(t => t.IcCreatedBy)
                .HasMaxLength(1000);

            this.Property(t => t.IcCodigoCRM)
                .HasMaxLength(100);

            this.Property(t => t.IcCodigoCRMParent)
                .HasMaxLength(100);

            this.Property(t => t.IcPeriodicidadeCalculoExcessos)
                .HasMaxLength(50);

            this.Property(t => t.IcIntegrationCode)
                .HasMaxLength(255);

            this.Property(t => t.IcID)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ItemContrato");
            this.Property(t => t.IcNumeroContrato).HasColumnName("icNumeroContrato");
            this.Property(t => t.IcPrdId).HasColumnName("icPrdId");
            this.Property(t => t.Icoferta).HasColumnName("icoferta");
            this.Property(t => t.IcAcondicionamento).HasColumnName("icAcondicionamento");
            this.Property(t => t.IcQuantidade).HasColumnName("icQuantidade");
            this.Property(t => t.IcTipoItem).HasColumnName("icTipoItem");
            this.Property(t => t.IcAvenca).HasColumnName("icAvenca");
            this.Property(t => t.IcCodIVA).HasColumnName("icCodIVA");
            this.Property(t => t.IcConsumivel).HasColumnName("icConsumivel");
            this.Property(t => t.IcDataInicioOferta).HasColumnName("icDataInicioOferta");
            this.Property(t => t.IcDataFimOferta).HasColumnName("icDataFimOferta");
            this.Property(t => t.IcPrecoUnitExcesso).HasColumnName("icPrecoUnitExcesso");
            this.Property(t => t.IcPrecoUnit).HasColumnName("icPrecoUnit");
            this.Property(t => t.IcPeriodicidadeServico).HasColumnName("icPeriodicidadeServico");
            this.Property(t => t.IcDataInicioPreco).HasColumnName("icDataInicioPreco");
            this.Property(t => t.IcDataFimPreco).HasColumnName("icDataFimPreco");
            this.Property(t => t.IcQtdMinima).HasColumnName("icQtdMinima");
            this.Property(t => t.IcQtdOferta).HasColumnName("icQtdOferta");
            this.Property(t => t.IcTransporte).HasColumnName("icTransporte");
            this.Property(t => t.IcTipoFact).HasColumnName("icTipoFact");
            this.Property(t => t.IcNumero).HasColumnName("icNumero");
            this.Property(t => t.IcDataDeFim).HasColumnName("icDataDeFim");
            this.Property(t => t.IcDataDeIncio).HasColumnName("icDataDeIncio");
            this.Property(t => t.IcQtd1entrega).HasColumnName("icQtd1entrega");
            this.Property(t => t.IcLastMod).HasColumnName("icLastMod");
            this.Property(t => t.IcCod_Int_Produto).HasColumnName("icCod_Int_Produto");
            this.Property(t => t.IcN_Contrato).HasColumnName("icN_Contrato");
            this.Property(t => t.IcProduto).HasColumnName("icProduto");
            this.Property(t => t.IcEnt_Fact).HasColumnName("icEnt_Fact");
            this.Property(t => t.IcData_I).HasColumnName("icData_I");
            this.Property(t => t.IcData_F).HasColumnName("icData_F");
            this.Property(t => t.IcPer_Serv).HasColumnName("icPer_Serv");
            this.Property(t => t.IcServico).HasColumnName("icServico");
            this.Property(t => t.IcPreco_Lista).HasColumnName("icPreco_Lista");
            this.Property(t => t.IcPreco_Unitario).HasColumnName("icPreco_Unitario");
            this.Property(t => t.IcDesc_Campanha).HasColumnName("icDesc_Campanha");
            this.Property(t => t.IcDesc_Protocolo).HasColumnName("icDesc_Protocolo");
            this.Property(t => t.IcDesc_Comercial).HasColumnName("icDesc_Comercial");
            this.Property(t => t.IcValor_Contratado).HasColumnName("icValor_Contratado");
            this.Property(t => t.IcTotal_Contratado).HasColumnName("icTotal_Contratado");
            this.Property(t => t.IcAp_Taxa_Gestao_Res).HasColumnName("icAp_Taxa_Gestao_Res");
            this.Property(t => t.IcCod_IVA_Ut).HasColumnName("icCod_IVA_Ut");
            this.Property(t => t.IcTipo_fact_Ut).HasColumnName("icTipo_fact_Ut");
            this.Property(t => t.IcPreco_Unit_Ut).HasColumnName("icPreco_Unit_Ut");
            this.Property(t => t.IcPer_Oferta).HasColumnName("icPer_Oferta");
            this.Property(t => t.IcUnidade_Oferta).HasColumnName("icUnidade_Oferta");
            this.Property(t => t.IcQtd_Min).HasColumnName("icQtd_Min");
            this.Property(t => t.IcUnidade_Qtd_Min).HasColumnName("icUnidade_Qtd_Min");
            this.Property(t => t.IcActivo).HasColumnName("icActivo");
            this.Property(t => t.IcDataDeInicio).HasColumnName("icDataDeInicio");
            this.Property(t => t.IcDataFimInactividade).HasColumnName("icDataFimInactividade");
            this.Property(t => t.IcPrecoValidoAteQuantidade).HasColumnName("icPrecoValidoAteQuantidade");
            this.Property(t => t.IcDescricao).HasColumnName("icDescricao");
            this.Property(t => t.IcDataInicioInactividade).HasColumnName("icDataInicioInactividade");
            this.Property(t => t.IcTaxaGestaoResiduos).HasColumnName("icTaxaGestaoResiduos");
            this.Property(t => t.IcTaxaGestaoResiduosCliente).HasColumnName("icTaxaGestaoResiduosCliente");
            this.Property(t => t.IcDataInicioTaxa).HasColumnName("icDataInicioTaxa");
            this.Property(t => t.IcDataFimTaxa).HasColumnName("icDataFimTaxa");
            this.Property(t => t.IcInformacoesSobreDescontoComercial).HasColumnName("icInformacoesSobreDescontoComercial");
            this.Property(t => t.IcCategoria_SPOA).HasColumnName("icCategoria_SPOA");
            this.Property(t => t.IcCodigo_Operacao).HasColumnName("icCodigo_Operacao");
            this.Property(t => t.IcAcondicionamentoIds).HasColumnName("icAcondicionamentoIds");
            this.Property(t => t.IcCreatedDate).HasColumnName("icCreatedDate");
            this.Property(t => t.IcCreatedBy).HasColumnName("icCreatedBy");
            this.Property(t => t.IcCodigoCRM).HasColumnName("icCodigoCRM");
            this.Property(t => t.IcCodigoCRMParent).HasColumnName("icCodigoCRMParent");
            this.Property(t => t.UltMod).HasColumnName("ultMod");
            this.Property(t => t.IcPeriodicidadeCalculoExcessos).HasColumnName("icPeriodicidadeCalculoExcessos");
            this.Property(t => t.IcIntegrationCode).HasColumnName("icIntegrationCode");
            this.Property(t => t.AplicarDescontoTGR).HasColumnName("AplicarDescontoTGR");
            this.Property(t => t.AplicarDescontoPrecos).HasColumnName("AplicarDescontoPrecos");
            this.Property(t => t.IcIsDeleted).HasColumnName("icIsDeleted");
            this.Property(t => t.IcID).HasColumnName("icID");

            // Relationships
            this.HasRequired(t => t.Contrato)
                .WithMany(t => t.ItemContratoes)
                .HasForeignKey(d => d.IcNumeroContrato);
            this.HasRequired(t => t.Produto)
                .WithMany(t => t.ItemContratoes)
                .HasForeignKey(d => d.IcPrdId);

        }
    }
}
