using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TboInvRate
    {
        public int? InvTypeNmbr { get; set; }
        public int? SeqNmbr { get; set; }
        public int? BoInvTypeNmbr { get; set; }
        public double? InvPct { get; set; }
        public string FundManagerNm { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
