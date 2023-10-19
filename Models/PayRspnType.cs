using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PayRspnType
    {
        public PayRspnType()
        {
            GroupCharges = new HashSet<GroupCharge>();
        }

        public int PayRspnNmbr { get; set; }
        public string PayRspnNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<GroupCharge> GroupCharges { get; set; }
    }
}
