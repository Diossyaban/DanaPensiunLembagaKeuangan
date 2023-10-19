using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblDbDirectBit
    {
        public string TrnsId { get; set; }
        public int? BatchId { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? ApprovalAmt { get; set; }
        public double? BitAmt { get; set; }
        public string BitAcctNmbr { get; set; }
        public string BitAcctNm { get; set; }
        public string BitBankNm { get; set; }
        public string BitBankAddr { get; set; }
        public string BitBankKey { get; set; }
        public string InvTypeSrc { get; set; }
        public string InvTypeDst { get; set; }
        public string TrnsTypeNm { get; set; }
        public int? BitDbdSeqNmbr { get; set; }
        public DateTime? BitDbdDate { get; set; }
        public string RequestedNm { get; set; }
        public string ApprvNm { get; set; }
        public string BitDbdAcctNmbr { get; set; }
        public string CdvNmbr { get; set; }
        public string BitDbdDesc { get; set; }
        public string BitDbdRows { get; set; }
    }
}
