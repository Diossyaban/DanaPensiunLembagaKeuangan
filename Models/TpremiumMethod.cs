using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TpremiumMethod
    {
        public short PremiumMtdType { get; set; }
        public string PremiumMtdNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
