using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class RiderType
    {
        public short RiderTypeNmbr { get; set; }
        public string RiderTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
