using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TwithSourceType
    {
        public int WithSrcTypeNmbr { get; set; }
        public string WithSrcTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
