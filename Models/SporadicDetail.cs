using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SporadicDetail
    {
        public int SeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int PaycenterNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public double PaidAmt { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
