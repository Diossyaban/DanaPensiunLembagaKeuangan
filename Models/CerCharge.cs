using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerCharge
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public int ChargeTypeNmbr { get; set; }
        public DateTime NextChargeDt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public double? ChargeAmt { get; set; }

        public virtual ChargeType ChargeTypeNmbrNavigation { get; set; }
    }
}
