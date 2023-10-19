using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ContribReq
    {
        public int CntrbSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public DateTime CntrbEfctvDt { get; set; }
        public DateTime CntrbRunDt { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? ReversalDt { get; set; }
        public DateTime? ReceivedDt { get; set; }
        public double? CntrbAmt { get; set; }
        public double? PaidAmt { get; set; }
        public short? SuspenseUseCd { get; set; }
        public DateTime? PaidDt { get; set; }
        public string Comment { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? PaycenterNmbr { get; set; }
        public short? LapseSts { get; set; }

        public virtual GroupInfo GroupNmbrNavigation { get; set; }
    }
}
