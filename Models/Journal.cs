using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Journal
    {
        public int? TrnsType { get; set; }
        public int? Seq { get; set; }
        public double? Debt { get; set; }
        public double? Credit { get; set; }
        public DateTime? TrnsDate { get; set; }
        public string Remark { get; set; }
    }
}
