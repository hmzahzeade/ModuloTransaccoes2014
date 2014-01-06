using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Contentor
    {
        public Contentor()
        {
            this.DetalheTransaccoes = new List<DetalheTransacco>();
        }

        public short ConID { get; set; }
        public string ConContentor { get; set; }
        public string ConOutros { get; set; }
        public bool ConActivo { get; set; }
        public bool ConTransPDA { get; set; }
        public System.DateTime UltAlteracao { get; set; }
        public virtual ICollection<DetalheTransacco> DetalheTransaccoes { get; set; }
    }
}
