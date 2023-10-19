using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcoiTypeRate
    {
        public int? CoiTypeNmbr { get; set; }
        public int? CoiAge { get; set; }
        public double? CoiRate { get; set; }
        public double? CoiAmount { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
