using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PremiumType
    {
        public short PremiumTypeNmbr { get; set; }
        public string PremiumTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
