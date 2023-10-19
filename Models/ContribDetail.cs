using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ContribDetail
    {
        public int CntrbSeqNmbr { get; set; }
        public int CntrbDtlSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double CntrbAmt { get; set; }
        public double PaidAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? PaycenterNmbr { get; set; }
    }
}
