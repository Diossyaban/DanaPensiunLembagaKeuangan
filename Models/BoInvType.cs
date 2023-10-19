using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BoInvType
    {
        public int BoInvTypeNmbr { get; set; }
        public string BoInvTypeNm { get; set; }
        public string OldIdNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
