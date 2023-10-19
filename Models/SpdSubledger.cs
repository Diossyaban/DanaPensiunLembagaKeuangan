using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdSubledger
    {
        public string NoRekening { get; set; }
        public string NoRekeningParent { get; set; }
        public string NamaRekening { get; set; }
        public string SubSidiary { get; set; }
        public int MonthPeriod { get; set; }
        public int YearPeriod { get; set; }
        public string CashCode { get; set; }
        public double? StartBalance { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public double? EndBalance { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime LastChangeDate { get; set; }
        public string LastChangeBy { get; set; }
        public byte[] Rowid { get; set; }
    }
}
