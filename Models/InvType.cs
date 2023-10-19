using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class InvType
    {
        public InvType()
        {
            CerInvDrcts = new HashSet<CerInvDrct>();
            ExchgRates = new HashSet<ExchgRate>();
            GrpChargeInvRts = new HashSet<GrpChargeInvRt>();
            GrpInvDrcts = new HashSet<GrpInvDrct>();
        }

        public short InvTypeNmbr { get; set; }
        public string InvTypeNm { get; set; }
        public short? Active { get; set; }
        public string OldInvType { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<CerInvDrct> CerInvDrcts { get; set; }
        public virtual ICollection<ExchgRate> ExchgRates { get; set; }
        public virtual ICollection<GrpChargeInvRt> GrpChargeInvRts { get; set; }
        public virtual ICollection<GrpInvDrct> GrpInvDrcts { get; set; }
    }
}
