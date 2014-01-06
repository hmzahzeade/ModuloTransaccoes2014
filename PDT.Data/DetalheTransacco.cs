using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class DetalheTransacco
    {
        public long DtDetalheId { get; set; }
        public string DtGuiaID { get; set; }
        public string DtPrdID { get; set; }
        public short DtRecipienteID { get; set; }
        public short DtVolumeID { get; set; }
        public Nullable<short> DtQtdEnt { get; set; }
        public Nullable<short> DtQtdRec { get; set; }
        public Nullable<short> DtQtdDevS { get; set; }
        public Nullable<short> DtQtdDevD { get; set; }
        public Nullable<double> DtPesoEnt { get; set; }
        public Nullable<double> DtPesoRec { get; set; }
        public Nullable<double> DtPesoDevS { get; set; }
        public Nullable<double> DtPesoDevD { get; set; }
        public Nullable<short> DtMDID { get; set; }
        public string DtMDObs { get; set; }
        public System.DateTime UltAlteracao { get; set; }
        public Nullable<bool> DtImportedAmbifac { get; set; }
        public Nullable<long> DtNovoProdutoID { get; set; }
        public Nullable<decimal> DtPesoApuradoDestino { get; set; }
        public string DtItemContrato { get; set; }
        public string DtLer { get; set; }
        public string DtCodOperacao { get; set; }
        public string SfItemID { get; set; }
        public string SfProdutoID { get; set; }
        public string SfContractID { get; set; }
        public string DtRefEncomenda { get; set; }
        public Nullable<bool> DtFacturada { get; set; }
        public virtual CabecalhoTransacco CabecalhoTransacco { get; set; }
        public virtual Contentor Contentor { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Volume Volume { get; set; }

    }
}
