using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace DPLK.Models
{
    public partial class CycleCertificateChargeAdjustment
    {
        public int InvTypeNmbr { get; set; }

        public DateTime FeePeriodStart { get; set; }

        public DateTime FeePeriodEnd { get; set; }

        public double? AdjAmt { get; set; }

        public double? DeductedAmt { get; set; }

        public DateTime? DeductedDt { get; set; }

        public string UserNm { get; set; }
    }
}
