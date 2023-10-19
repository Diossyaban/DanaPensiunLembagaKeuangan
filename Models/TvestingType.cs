using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TvestingType
    {
        public int VestTypeNmbr { get; set; }
        public string VestTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
