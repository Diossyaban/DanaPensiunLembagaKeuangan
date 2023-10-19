using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CycleCertificateCoi
    {
        public int ChargeTypeNmbr { get; set; }
        public int BeneTypeNmbr { get; set; }
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public double? SumInsuredAmt { get; set; }
        public double? CoiAmt { get; set; }
        public double? DiscontAmt { get; set; }
        public double? LoadingAmt { get; set; }
        public double? DeductedAmt { get; set; }
        public DateTime? DeductedDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
