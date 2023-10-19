using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Reconciliation
    {
        public int ReconNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int CntrbSeqNmbr { get; set; }
        public int CntrbDtlSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double? OldAmt { get; set; }
        public double? NewAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
