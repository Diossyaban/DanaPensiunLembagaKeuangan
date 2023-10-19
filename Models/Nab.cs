using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPLK.Models
{
    public partial class Nab
    {
        public DateTime? EfctvDt { get; set; }
        public int? InvTypeNmbr { get; set; }
        public double? Nab1 { get; set; }
        public double? Unit { get; set; }
        public bool? ApprovalFlg { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public double? UnitSuspense { get; set; }

    }
}
