using System;
using System.Collections.Generic;

namespace PDT.Data.Models
{
    public partial class Volume
    {
        public Volume()
        {
            this.DetalheTransaccoes = new List<DetalheTransacco>();
        }

        public short VlmID { get; set; }
        public double VlmDescricao { get; set; }
        public bool VlmActivo { get; set; }
        public bool VlmTransPDA { get; set; }
        public System.DateTime VlmUltAlteracao { get; set; }
        public virtual ICollection<DetalheTransacco> DetalheTransaccoes { get; set; }
    }
}
