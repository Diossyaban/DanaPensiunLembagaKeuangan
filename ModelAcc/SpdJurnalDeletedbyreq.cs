using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdJurnalDeletedbyreq
    {
        public string TrnsId { get; set; }
        public string GlCode { get; set; }
        public string Slcode { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public string Inv { get; set; }
        public string Company { get; set; }
        public string Grp { get; set; }
        public string CerNmbr { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
        public string Description { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public DateTime DateJurnal { get; set; }
        public string ApprovedBy { get; set; }
        public string PostedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Correction { get; set; }
        public string RequestedBy { get; set; }
        public DateTime RequestedDate { get; set; }
    }
}
