using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VestingType
    {
        public int VestTypeNmbr { get; set; }
        public string VestTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
