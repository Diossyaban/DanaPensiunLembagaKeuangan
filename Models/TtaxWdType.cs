using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtaxWdType
    {
        public int? TaxTypeNmbr { get; set; }
        public int? TaxIdNmbr { get; set; }
        public double? FromAmt { get; set; }
        public double? ToAmt { get; set; }
        public double? NonNpwpPct { get; set; }
        public double? NpwpPct { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
