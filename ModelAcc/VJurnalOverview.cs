using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VJurnalOverview
    {
        public string TrnsId { get; set; }
        public string Description { get; set; }
        public DateTime DateJurnal { get; set; }
        public string Inv { get; set; }
        public string InvTypeNm { get; set; }
        public int? TrnsType { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
        public string ApprovedBy { get; set; }
        public string PostedBy { get; set; }
        public string ApprovedDate { get; set; }
        public string PostedDate { get; set; }
        public int Bank { get; set; }
        public bool? Correction { get; set; }
    }
}
