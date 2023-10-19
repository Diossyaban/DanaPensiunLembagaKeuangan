using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerCntrb
    {
        public int CerNmbr { get; set; }
        public int McpNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public double? CntrbAmt { get; set; }
        public double? CntrbRt { get; set; }
        public short UseGrpCd { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual Certificate CerNmbrNavigation { get; set; }
        public virtual MoneyType MoneyTypeNmbrNavigation { get; set; }
    }
}
