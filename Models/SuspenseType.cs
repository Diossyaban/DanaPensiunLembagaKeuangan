using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SuspenseType
    {
        public int SuspnTypeNmbr { get; set; }
        public string SuspnTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
