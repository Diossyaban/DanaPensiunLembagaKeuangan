using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ReturInfo
    {
        public int? SeqNmbr { get; set; }
        public string Regisid { get; set; }
        public int? CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public string BankId { get; set; }
        public string BankNm { get; set; }
        public string AcctNmbr { get; set; }
        public string AcctNm { get; set; }
        public string BankAddress { get; set; }
        public double? Amount { get; set; }
        public double? CheckAmt { get; set; }
        public string TransType { get; set; }
        public string TransDate { get; set; }
        public string Remarks { get; set; }
        public long? SuspenseNmbr { get; set; }
        public int? ApprovalFlg { get; set; }
        public DateTime? ReturDt { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public string PrepareBy { get; set; }
        public string ApprovedBy { get; set; }
        public int? InvTypeNmbr { get; set; }
    }
}
