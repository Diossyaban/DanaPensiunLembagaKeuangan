using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblDbDirectSwitch
    {
        public int? CerNmbr { get; set; }
        public int? BatchId { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public DateTime? TrnsHstEfctvDt { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? ApprovalAmt { get; set; }
        public double? SwitchAmt { get; set; }
        public string SwitchAcctNmbr { get; set; }
        public string SwitchAcctNm { get; set; }
        public string SwitchBankNm { get; set; }
        public string SwitchBankAddr { get; set; }
        public string SwitchBankKey { get; set; }
        public string InvTypeSrc { get; set; }
        public string InvTypeDst { get; set; }
        public string TrnsTypeNm { get; set; }
        public int? SwitchDbdSeqNmbr { get; set; }
        public DateTime? SwitchDbdDate { get; set; }
        public string RequestedNm { get; set; }
        public string ApprvNm { get; set; }
        public string SwitchDbdAcctNmbr { get; set; }
        public string CdvNmbr { get; set; }
        public string SwitchDbdDesc { get; set; }
        public string SwitchDbdRows { get; set; }
    }
}
