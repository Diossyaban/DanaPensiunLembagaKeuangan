using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class IchaPetrochina
    {
        public double? NoPeserta { get; set; }
        public string NoPegawai { get; set; }
        public string NamaPeserta { get; set; }
        public DateTime? TglLahir { get; set; }
        public decimal? JmlGross { get; set; }
        public decimal? JmlFee { get; set; }
        public decimal? JmlTax { get; set; }
        public decimal? JmlNet { get; set; }
        public string LumpsumAccntNmbr { get; set; }
        public string LumpsumAcctNm { get; set; }
        public string LumpsumBankNm { get; set; }
        public decimal? LumpsumAmt { get; set; }
        public string AnuitasAccntNmbr { get; set; }
        public string AnuitasAcctNm { get; set; }
        public string AnuitasBankNm { get; set; }
        public decimal? AnuitasAmt { get; set; }
    }
}
