using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewKlaimPaid
    {
        public int CerNmbr { get; set; }
        public int TrnsSeqNmbr { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public int SubTrnsNmbr { get; set; }
        public string SubTrnsNm { get; set; }
        public double? GrossAmt { get; set; }
        public double? FeeAmt { get; set; }
        public double? TaxAmt { get; set; }
        public string LsBank { get; set; }
        public string LsActno { get; set; }
        public string LsActnm { get; set; }
        public double? LsAmt { get; set; }
        public string AnBank { get; set; }
        public string AnActno { get; set; }
        public string AnActnm { get; set; }
        public double? AnAmt { get; set; }
    }
}
