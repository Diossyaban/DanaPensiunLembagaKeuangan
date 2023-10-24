using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VUnapproveTransactionBatch
    {
        public string TrnsId { get; set; }
        public DateTime? TrnsDate { get; set; }
        public string Funds { get; set; }
        public string Batch { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public string SubTrns { get; set; }
        public string GlCode { get; set; }
        public string Dc { get; set; }
        public double? Amount { get; set; }
        public string Fund { get; set; }
        public string SubTrnsNm { get; set; }
        public string Company { get; set; }
    }
}
