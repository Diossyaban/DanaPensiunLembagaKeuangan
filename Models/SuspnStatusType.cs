using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SuspnStatusType
    {
        public int SuspnStatusNmbr { get; set; }
        public string SuspnStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
