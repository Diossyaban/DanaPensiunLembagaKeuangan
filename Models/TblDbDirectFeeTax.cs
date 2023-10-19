using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblDbDirectFeeTax
    {
        public int? CerNmbr { get; set; }
        public int? BatchId { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public DateTime? TrnsHstEfctvDt { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? ApprovalAmt { get; set; }
        public double? FeeAmt { get; set; }
        public string FeeAcctNmbr { get; set; }
        public string FeeAcctNm { get; set; }
        public string FeeBankNm { get; set; }
        public string FeeBankAddr { get; set; }
        public string FeeBankKey { get; set; }
        public double? TaxAmt { get; set; }
        public string TaxAcctNmbr { get; set; }
        public string TaxAcctNm { get; set; }
        public string TaxBankNm { get; set; }
        public string TaxBankAddr { get; set; }
        public string TaxBankKey { get; set; }
        public int? FeeDbdSeqNmbr { get; set; }
        public DateTime? FeeDbdDate { get; set; }
        public int? TaxDbdSeqNmbr { get; set; }
        public DateTime? TaxDbdDate { get; set; }
        public string RequestedNm { get; set; }
        public string ApprvNm { get; set; }
        public string FeeDbdAcctNmbr { get; set; }
        public string TaxDbdAcctNmbr { get; set; }
        public string CdvNmbr { get; set; }
        public string FeeDbdDesc { get; set; }
        public string TaxDbdDesc { get; set; }
        public string FeeDbdRows { get; set; }
        public string TaxDbdRows { get; set; }
        public int? InvTypeNmbr { get; set; }
    }
}
