using System;

namespace DPLK.Models
{
    public class SuspensePayoutViewModel
    {
        public int SeqNmbr { get; set; }
        public string RegisId { get; set; }
        public int CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public string BankNm { get; set; }
        public string BankAddress { get; set; }
        public string AcctNmbr { get; set; }
        public string AcctNm { get; set; }
        public decimal Amount { get; set; }
        public decimal CheckAmt { get; set; }
        public decimal NetAmt { get; set; }
        public string Remarks { get; set; }
        public int SuspenseNmbr { get; set; }
        public string PrepareBy { get; set; }
        public DateTime? ApprovalDt { get; set; }
    }
}
