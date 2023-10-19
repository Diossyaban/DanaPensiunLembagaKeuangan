using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TboInvType
    {
        public int BoInvTypeNmbr { get; set; }
        public string BoInvTypeNm { get; set; }
        public string OldIdNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
