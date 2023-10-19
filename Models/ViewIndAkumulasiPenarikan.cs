using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIndAkumulasiPenarikan
    {
        public DateTime TrnsHstEfctvDt { get; set; }
        public int CerNmbr { get; set; }
        public string SubTrnsNm { get; set; }
        public string MoneyTypeNm { get; set; }
        public double GrossAmt { get; set; }
        public double NetAmt { get; set; }
    }
}
