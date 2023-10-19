using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerMovementSwitch
    {
        public int? CerNmbr { get; set; }
        public DateTime? EfctvDt { get; set; }
        public int? OldGrpNmbr { get; set; }
        public int? NewGrpNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
