using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GrpChargeInvRt
    {
        public int GroupNmbr { get; set; }
        public int ChargeTypeNmbr { get; set; }
        public int MainChrgSeqNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public double? ChargeRt { get; set; }
        public double? ChargeAmt { get; set; }
        public double? BillPct { get; set; }
        public double? DeductPct { get; set; }
        public DateTime? LastChangeDt { get; set; }

        public virtual GroupCharge GroupCharge { get; set; }
        public virtual InvType InvTypeNmbrNavigation { get; set; }
    }
}
