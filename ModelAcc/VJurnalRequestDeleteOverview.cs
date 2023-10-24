using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VJurnalRequestDeleteOverview
    {
        public string TrnsId { get; set; }
        public string Description { get; set; }
        public DateTime DateJurnal { get; set; }
        public string Inv { get; set; }
        public string InvTypeNm { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
        public string ApprovedBy { get; set; }
        public string PostedBy { get; set; }
        public string ApprovedDate { get; set; }
        public string PostedDate { get; set; }
        public string RequestDeleteBy { get; set; }
        public string ApproveDeleteBy { get; set; }
        public DateTime? RequestDeleteDate { get; set; }
        public DateTime? ApproveDeleteDate { get; set; }
        public bool? Correction { get; set; }
    }
}
