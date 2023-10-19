using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class WithSourceType
    {
        public int WithSrcTypeNmbr { get; set; }
        public string WithSrcTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
