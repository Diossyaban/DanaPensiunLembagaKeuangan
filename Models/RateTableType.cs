using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class RateTableType
    {
        public int RateTypeNmbr { get; set; }
        public string RateTypeNm { get; set; }
        public string OldTypeNm { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
