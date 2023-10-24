using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VUnapproveTransaction
    {
        public string TrnsId { get; set; }
        public DateTime TrnsDate { get; set; }
        public string Funds { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrns { get; set; }
        public string Fund { get; set; }
        public string SubTrnsNm { get; set; }
        public int? Bank { get; set; }
    }
}
