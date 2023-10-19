using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class RoleType
    {
        public int RoleTypeNmbr { get; set; }
        public string RoleTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
