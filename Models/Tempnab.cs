using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tempnab
    {
        public DateTime? EfctvDt { get; set; }
        public int? InvTypeNmbr { get; set; }
        public double? Nab { get; set; }
        public double? Unit { get; set; }
        public bool? ApprovalFlg { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public double? UnitSuspense { get; set; }
    }
}
