using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class WdAccumulator
    {
        public int GroupNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public double? WdAmt { get; set; }
        public double? SurrdrAmt { get; set; }
        public double? Rate { get; set; }
        public double? ActVal { get; set; }

        public virtual GroupInfo GroupNmbrNavigation { get; set; }
    }
}
