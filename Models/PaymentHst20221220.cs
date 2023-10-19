using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PaymentHst20221220
    {
        public long SuspnNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int? PaycenterNmbr { get; set; }
        public short PaymentTrnsNmbr { get; set; }
        public long BillCntrbNmbr { get; set; }
        public short PaymentApprvCd { get; set; }
        public DateTime? PaidDt { get; set; }
        public int PaymentSeqNmbr { get; set; }
        public double SuspnRestAmt { get; set; }
        public double PaidAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Remark { get; set; }
        public string Notes { get; set; }
    }
}
