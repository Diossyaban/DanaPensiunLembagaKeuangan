using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SunGlType
    {
        public int SunTypeNmbr { get; set; }
        public string SunTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
