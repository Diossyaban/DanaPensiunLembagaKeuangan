using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Cycle
    {
        public DateTime CycleDt { get; set; }
        public short CycleFlg { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
