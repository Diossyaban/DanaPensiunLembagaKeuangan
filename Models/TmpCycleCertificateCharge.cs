using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmpCycleCertificateCharge
    {
        public DateTime? CycleDt { get; set; }
        public int? GroupNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public int? ChargeTypeNmbr { get; set; }
        public int? PayRspnNmbr { get; set; }
        public double? AssetAmt { get; set; }
        public double? ChargeAmt { get; set; }
        public double? DeductedAmt { get; set; }
        public DateTime? DeductedDt { get; set; }
        public DateTime? LastChargeDt { get; set; }
        public string UserId { get; set; }
    }
}
