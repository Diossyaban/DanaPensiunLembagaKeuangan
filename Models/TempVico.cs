using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TempVico
    {
        public DateTime? PeriodDt { get; set; }
        public int? GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int? CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public string EfctvDt { get; set; }
        public string BirthDt { get; set; }
        public double? Unit { get; set; }
        public double? UnitPrice { get; set; }
        public double? Asset { get; set; }
        public int? InvTypeNmbr { get; set; }
    }
}
