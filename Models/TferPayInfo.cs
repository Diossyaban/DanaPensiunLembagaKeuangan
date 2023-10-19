using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TferPayInfo
    {
        public int TferTypeNmbr { get; set; }
        public int TrnsSeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public double Percentage { get; set; }
        public string BankNm { get; set; }
        public string AcctNmbr { get; set; }
        public string AcctNm { get; set; }
        public string Note { get; set; }
        public int? TaxDctNmbr { get; set; }
        public double? SumInsured { get; set; }
        public double? TferAmt { get; set; }
        public string BranchAddr { get; set; }
        public string BankBiNmbr { get; set; }
        public string BankCentralNm { get; set; }
        public string BankAddr { get; set; }
    }
}
