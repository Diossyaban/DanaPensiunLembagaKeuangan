using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Bill
    {
        public int BillSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public DateTime BillEfctvDt { get; set; }
        public int BillType { get; set; }
        public int BillFreqNmbr { get; set; }
        public DateTime BillRunDt { get; set; }
        public DateTime BillCreateDt { get; set; }
        public DateTime? ReversalDt { get; set; }
        public DateTime? ReceivedDt { get; set; }
        public double BillAmt { get; set; }
        public double OutstandingAmt { get; set; }
        public double? PaidAmt { get; set; }
        public short? SuspenseUseCd { get; set; }
        public DateTime? PaidDt { get; set; }
        public string Comment { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? PaycenterNmbr { get; set; }
    }
}
