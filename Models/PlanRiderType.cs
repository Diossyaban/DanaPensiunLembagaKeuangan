using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PlanRiderType
    {
        public short PlanTypeNmbr { get; set; }
        public short? PremiumTypeNmbr { get; set; }
        public short? RiderTypeNmbr { get; set; }
        public string PlanTypeNm { get; set; }
        public decimal? Premium { get; set; }
        public decimal? Contribution { get; set; }
        public decimal? Benefit { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
