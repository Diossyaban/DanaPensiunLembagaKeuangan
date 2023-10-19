using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GrpInvDrct
    {
        public int GroupNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public float MaxPercent { get; set; }
        public float MinPercent { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual InvType InvTypeNmbrNavigation { get; set; }
    }
}
