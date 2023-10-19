using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ChargeType
    {
        public ChargeType()
        {
            CerCharges = new HashSet<CerCharge>();
            CerTrnsCnts = new HashSet<CerTrnsCnt>();
            GroupCharges = new HashSet<GroupCharge>();
        }

        public int ChargeTypeNmbr { get; set; }
        public string ChargeTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<CerCharge> CerCharges { get; set; }
        public virtual ICollection<CerTrnsCnt> CerTrnsCnts { get; set; }
        public virtual ICollection<GroupCharge> GroupCharges { get; set; }
    }
}
