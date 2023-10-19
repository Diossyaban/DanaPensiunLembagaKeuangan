using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class FrequencyType
    {
        public FrequencyType()
        {
            GroupCharges = new HashSet<GroupCharge>();
        }

        public int FreqTypeNmbr { get; set; }
        public string FreqTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<GroupCharge> GroupCharges { get; set; }
    }
}
