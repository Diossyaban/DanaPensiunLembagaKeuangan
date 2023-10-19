using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class HtrnsHst
    {
        public int? CerNmbr { get; set; }
        public string OldCerNmbr { get; set; }
        public DateTime? EfctvDt { get; set; }
        public string TrnsTypeNm { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? FeeAmt { get; set; }
        public double? TaxAmt { get; set; }
        public string Remarks { get; set; }
    }
}
