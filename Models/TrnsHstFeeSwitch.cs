using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrnsHstFeeSwitch
    {
        public int TrnsSeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double? TaxAmt { get; set; }
        public double? FeeAmt { get; set; }
        public double? ExchgrtAmt { get; set; }
        public double? SurrdrAmt { get; set; }
        public double? Tax23Amt { get; set; }
        public double? OtherFeeAmt { get; set; }
        public double? AdmFeeAmt { get; set; }
        public double? InvFeeAmt { get; set; }
    }
}
