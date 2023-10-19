using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class MoneyType
    {
        public MoneyType()
        {
            CerAccumulators = new HashSet<CerAccumulator>();
            CerCntrbs = new HashSet<CerCntrb>();
            CerInvDrcts = new HashSet<CerInvDrct>();
            CerInvs = new HashSet<CerInv>();
            MbrClsPlans = new HashSet<MbrClsPlan>();
        }

        public int MoneyTypeNmbr { get; set; }
        public string MoneyTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<CerAccumulator> CerAccumulators { get; set; }
        public virtual ICollection<CerCntrb> CerCntrbs { get; set; }
        public virtual ICollection<CerInvDrct> CerInvDrcts { get; set; }
        public virtual ICollection<CerInv> CerInvs { get; set; }
        public virtual ICollection<MbrClsPlan> MbrClsPlans { get; set; }
    }
}
