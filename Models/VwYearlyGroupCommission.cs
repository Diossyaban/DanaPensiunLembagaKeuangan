using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwYearlyGroupCommission
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime? EndDate { get; set; }
        public int TahunKe { get; set; }
        public double? AdminFee { get; set; }
        public double? JumlahIuran { get; set; }
        public double? Komisi { get; set; }
        public string SalesName { get; set; }
        public int? CommisionFlg { get; set; }
    }
}
