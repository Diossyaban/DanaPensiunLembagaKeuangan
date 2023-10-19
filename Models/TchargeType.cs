using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TchargeType
    {
        public int ChargeTypeNmbr { get; set; }
        public string ChargeTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
