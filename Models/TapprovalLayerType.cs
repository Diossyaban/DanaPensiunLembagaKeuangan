using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TapprovalLayerType
    {
        public int? TrnsId { get; set; }
        public double? MaxAmt { get; set; }
        public string UserApprovalNm { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
