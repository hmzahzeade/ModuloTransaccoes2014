using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDT.Data.Models
{
  
    public class CabecalhoTransacco
    {
        public CabecalhoTransacco()
        {
            this.DetalheTransaccoes = new List<DetalheTransacco>();
        }

        public string CtGuiaID { get; set; }
        public long CtRotaID { get; set; }
        public int CtMotID { get; set; }
        public string CtMatricula { get; set; }
        public string CtClienteID { get; set; }
        public Nullable<long> CtEmpTransp { get; set; }
        public Nullable<long> CtEmpDest { get; set; }
        public Nullable<long> CtEmpExp { get; set; }
        public short CtLocDesc { get; set; }
        public string CtLocCarga { get; set; }
        public Nullable<System.DateTime> CtDataIni { get; set; }
        public Nullable<System.DateTime> CtDataFim { get; set; }
        public Nullable<short> CtOtrID { get; set; }
        public string CtObs { get; set; }
        public Nullable<short> CtMAID { get; set; }
        public string CtMAObs { get; set; }
        public byte[] CtAssCli { get; set; }
        public string CtCliNome { get; set; }
        public Nullable<byte> CtDocImp { get; set; }
        public string CtDecExp { get; set; }
        public string CtDecDest { get; set; }
        public string CtDecTransp { get; set; }
        public System.DateTime UltAlteracao { get; set; }
        public bool CtTransporte { get; set; }
        public double CtPesoGIII { get; set; }
        public double CtPesoGIV { get; set; }
        public string CtNumContrato { get; set; }
        public Nullable<bool> CtGuiaEliminada { get; set; }
        public Nullable<byte> Facturada { get; set; }
        public string CtGuiaParent { get; set; }
        public string CtModifiedBy { get; set; }
        public Nullable<System.DateTime> CtModifiedDate { get; set; }
        public bool CtGuiaManual { get; set; }
        public Nullable<int> CtAterro { get; set; }
        public Nullable<bool> CtIsClone { get; set; }
        public Nullable<bool> CtTransporteUrgente { get; set; }
        public Nullable<System.DateTime> CtDataFacturacao { get; set; }
        public string CtAnuladoPor { get; set; }
        public Nullable<System.DateTime> CtDataAnulacao { get; set; }
        public Nullable<bool> CtEnviadoCliente { get; set; }
        public Nullable<System.DateTime> CtDataEnvioCliente { get; set; }
        public string CtOrigem { get; set; }
        public string CtGuiaOriginal { get; set; }
        public bool CtExportarLegacy { get; set; }
        public bool CtSyncedRO { get; set; }
        public string CtCreatedBy { get; set; }
        public Nullable<System.DateTime> CtCreatedDate { get; set; }
        public string CtContrato { get; set; }
        public Nullable<bool> CtConfirmada { get; set; }
        public string SfAccountID { get; set; }
        public string SfSourceAccountID { get; set; }
        public string SfTargetAccountID { get; set; }
        public string SfCarrierAccountID { get; set; }
        public string SfContractID { get; set; }
        public Nullable<int> CtUnidade { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual ICollection<DetalheTransacco> DetalheTransaccoes { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string CtTipoTran
        {
            get;
            set;
        }

    }
}
