using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwTransPertamina
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int CerNmbr { get; set; }
        public double Amount { get; set; }
        public DateTime? TrnsHstEfctvDt { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public DateTime? Cycledt { get; set; }
    }
}
