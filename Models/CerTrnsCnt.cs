using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerTrnsCnt
    {
        public int CerNmbr { get; set; }
        public int ChargeTypeNmbr { get; set; }
        public short? TrnsCnt { get; set; }

        public virtual Certificate CerNmbrNavigation { get; set; }
        public virtual ChargeType ChargeTypeNmbrNavigation { get; set; }
    }
}
