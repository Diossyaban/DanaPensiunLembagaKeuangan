using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrateTableDetail
    {
        public int RateTypeNmbr { get; set; }
        public int RateSeqNmbr { get; set; }
        public double? StartAmt { get; set; }
        public double? EndAmt { get; set; }
        public double? RatePct { get; set; }
        public double? RateAmt { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
