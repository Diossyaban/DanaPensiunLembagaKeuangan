using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public class GroupBenefit
    {
        public int GroupNumber { get; set; }
        public int McpTypeNumber { get; set; }
        public int BenefitTypeNumber { get; set; }
        public int SiCalcTypeNumber { get; set; }
        public float DefaultSumInsured { get; set; }
        public float MaxSumInsured { get; set; }
        public bool? CoiDiscountFlag { get; set; }
        public float CoiDiscountValue { get; set; }
        public bool? CoiLoadingFlag { get; set; }
        public float CoiLoadingValue { get; set; }
        public int MaxEntryAge { get; set; }
        public int MaxCoverageAge { get; set; }
        public int CoiTypeNumber { get; set; }
        public DateTime ChangeDate { get; set; }
        public int SubTransactionNumber { get; set; }
    }

}
