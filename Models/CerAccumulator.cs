using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerAccumulator
    {
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double CntrbAmt { get; set; }
        public double DstbAmt { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual Certificate CerNmbrNavigation { get; set; }
        public virtual MoneyType MoneyTypeNmbrNavigation { get; set; }
    }
}
