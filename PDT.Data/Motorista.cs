using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Motorista
    {
        public decimal MotID { get; set; }
        public string MotNomeCompleto { get; set; }
        public Nullable<decimal> MotUnidadeRecolha { get; set; }
        public Nullable<int> MotNumPHC { get; set; }
        public bool MotActivo { get; set; }
        public byte[] MotAssinatura { get; set; }
        public Nullable<int> MotTipoFuncao { get; set; }
    }
}
