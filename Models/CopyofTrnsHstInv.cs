using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CopyofTrnsHstInv
    {
        public int TrnsSeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public double UnitCnt { get; set; }
        public double GrossAmt { get; set; }
        public double NetAmt { get; set; }
    }
}
