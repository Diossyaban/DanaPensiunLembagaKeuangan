using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GroupCharge
    {
        public GroupCharge()
        {
            GrpChargeInvRts = new HashSet<GrpChargeInvRt>();
            GrpChargeRts = new HashSet<GrpChargeRt>();
        }

        public int GroupNmbr { get; set; }
        public int ChargeTypeNmbr { get; set; }
        public int MainChrgSeqNmbr { get; set; }
        public DateTime ChargeEfctvDt { get; set; }
        public DateTime? ChargeTrmntnDt { get; set; }
        public DateTime? NextChargeDt { get; set; }
        public int PayRspnNmbr { get; set; }
        public int FreqTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ChargeType ChargeTypeNmbrNavigation { get; set; }
        public virtual FrequencyType FreqTypeNmbrNavigation { get; set; }
        public virtual GroupInfo GroupNmbrNavigation { get; set; }
        public virtual PayRspnType PayRspnNmbrNavigation { get; set; }
        public virtual ICollection<GrpChargeInvRt> GrpChargeInvRts { get; set; }
        public virtual ICollection<GrpChargeRt> GrpChargeRts { get; set; }
    }
}
