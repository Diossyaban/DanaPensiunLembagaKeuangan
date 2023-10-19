using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AccType
    {
        public string AccTypeNmbr { get; set; }
        public string AccTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
