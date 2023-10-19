using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GroupBeneSetup
    {
        public int? GroupNmbr { get; set; }
        public int? McpTypeNmbr { get; set; }
        public int? BeneTypeNmbr { get; set; }
        public int? SiCalcTypeNmbr { get; set; }
        public double? DefaultSumInsured { get; set; }
        public double? MaxSumInsured { get; set; }
        public bool? CoiDiscontFlg { get; set; }
        public double? CoiDiscontValue { get; set; }
        public bool? CoiLoadingFlg { get; set; }
        public double? CoiLoadingValue { get; set; }
        public int? MaxEntryAge { get; set; }
        public int? MaxCovAge { get; set; }
        public int? CoiTypeNmbr { get; set; }
        public DateTime? ChangeDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public int? SubTrnsNmbr { get; set; }
    }
}
