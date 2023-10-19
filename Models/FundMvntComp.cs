using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class FundMvntComp
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public int InvTypeNmbr { get; set; }
        public double? CurrentAsset { get; set; }
        public double? CompositionPct { get; set; }
        public double? NewAsset { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
