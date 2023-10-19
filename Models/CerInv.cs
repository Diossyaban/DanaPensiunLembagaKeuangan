using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerInv
    {
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public double UnitCount { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual Certificate CerNmbrNavigation { get; set; }
        public virtual MoneyType MoneyTypeNmbrNavigation { get; set; }
    }
}
