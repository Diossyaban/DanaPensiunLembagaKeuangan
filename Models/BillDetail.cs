using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BillDetail
    {
        public int BillSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int BillDtlNmbr { get; set; }
        public int? ChargeTypeNmbr { get; set; }
        public int PayorTypeNmbr { get; set; }
        public double BillDtlAmt { get; set; }
        public double? AdjAmt { get; set; }
        public double? PaidAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? PaycenterNmbr { get; set; }
    }
}
