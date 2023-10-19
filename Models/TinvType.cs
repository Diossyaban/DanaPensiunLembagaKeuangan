using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TinvType
    {
        public short InvTypeNmbr { get; set; }
        public string InvTypeNm { get; set; }
        public short? Active { get; set; }
        public string OldInvType { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
