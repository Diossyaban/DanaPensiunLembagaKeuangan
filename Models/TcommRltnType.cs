using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcommRltnType
    {
        public int CommRltnTypeNmbr { get; set; }
        public string CommRltnTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
