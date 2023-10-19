using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrateTableType
    {
        public int RateTypeNmbr { get; set; }
        public string RateTypeNm { get; set; }
        public string OldTypeNm { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
