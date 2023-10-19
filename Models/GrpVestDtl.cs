using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GrpVestDtl
    {
        public int GrpSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int SeqNmbr { get; set; }
        public bool? DeathFlg { get; set; }
        public double? BegYop { get; set; }
        public double? EndYop { get; set; }
        public double? BegYos { get; set; }
        public double? EndYos { get; set; }
        public int? JobLvlNmbr { get; set; }
        public double? VestSchPct { get; set; }
        public DateTime? LastChangeDt { get; set; }

        public virtual GrpVestSch Gr { get; set; }
    }
}
