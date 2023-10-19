using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SiCalcType
    {
        public int? SiCalcTypeNmbr { get; set; }
        public string SiCalcTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
