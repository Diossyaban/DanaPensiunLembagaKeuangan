using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwCashBasisGroupCommission
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public DateTime EfctvDt { get; set; }
        public int CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public int CntrbSeqNmbr { get; set; }
        public DateTime CntrbEfctvDt { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public double? Iuran { get; set; }
        public string SalesName { get; set; }
        public double? AdminFee { get; set; }
        public double? Komisi1 { get; set; }
        public double? Komisi2 { get; set; }
        public int? PersenKomisi { get; set; }
        public int? TahunKe { get; set; }
    }
}
