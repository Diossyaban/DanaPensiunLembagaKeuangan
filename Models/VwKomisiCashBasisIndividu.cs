using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwKomisiCashBasisIndividu
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public double? ContribAmont { get; set; }
        public int? CntrbSeqNmbr { get; set; }
        public string OldAgentNmbr { get; set; }
        public double? Komisi { get; set; }
        public double? AdminFee { get; set; }
        public int? PersenKomisi { get; set; }
        public int? Flag { get; set; }
    }
}
