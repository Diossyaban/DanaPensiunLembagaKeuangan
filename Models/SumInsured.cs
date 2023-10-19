using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SumInsured
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public double SumInsured1 { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? BeneTypeNmbr { get; set; }
    }
}
