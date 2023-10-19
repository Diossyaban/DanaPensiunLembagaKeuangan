using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblDbDirectNotafikasi
    {
        public int? CerNmbr { get; set; }
        public int? BatchId { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public DateTime? TrnsHstEfctvDt { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? ApprovalAmt { get; set; }
        public double? LumpsumAmt { get; set; }
        public string LumpsumAcctNmbr { get; set; }
        public string LumpsumAcctNm { get; set; }
        public string LumpsumBankNm { get; set; }
        public string LumpsumBankAddr { get; set; }
        public string LumpsumBankKey { get; set; }
        public double? AnnutyAmt { get; set; }
        public string AnnutyAcctNmbr { get; set; }
        public string AnnutyAcctNm { get; set; }
        public string AnnutyBankNm { get; set; }
        public string AnnutyBankAddr { get; set; }
        public string AnnutyBankKey { get; set; }
        public int? LumpsumDbdSeqNmbr { get; set; }
        public DateTime? LumpsumDbdDate { get; set; }
        public int? AnnutyDbdSeqNmbr { get; set; }
        public DateTime? AnnutyDbdDate { get; set; }
        public string RequestedNm { get; set; }
        public string ApprvNm { get; set; }
        public string LumpsumDbdAcctNmbr { get; set; }
        public string AnnutyDbdAcctNmbr { get; set; }
        public string CdvNmbr { get; set; }
        public string LumpsumDbdDesc { get; set; }
        public string AnnutyDbdDesc { get; set; }
        public string LumpsumDbdRows { get; set; }
        public string AnnutyDbdRows { get; set; }
        public int? InvTypeNmbr { get; set; }
        public int? Rtgs { get; set; }
        public bool? FlagCm { get; set; }
        public bool? FlagCetak { get; set; }
    }
}
