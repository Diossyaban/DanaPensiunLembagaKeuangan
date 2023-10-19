using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdBigledgerV
    {
        public string NoRekening { get; set; }
        public string NamaRekening { get; set; }
        public string Kas { get; set; }
        public string CashCode { get; set; }
        public double? StartBalance { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public double? EndBalance { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
    }
}
