using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SlryHistory
    {
        public DateTime EfctvDt { get; set; }
        public int CerNmbr { get; set; }
        public double SlryAmt { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
