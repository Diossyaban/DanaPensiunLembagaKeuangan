using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SporadicPmt
    {
        public int SeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int PaycenterNmbr { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? PaidDt { get; set; }
        public DateTime? ReversalDt { get; set; }
        public double PaidAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? SporadicType { get; set; }
        public bool? JoinAccnFlg { get; set; }
        public string Comment { get; set; }
    }
}
