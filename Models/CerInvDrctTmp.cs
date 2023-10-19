using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerInvDrctTmp
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public short InvTypeNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double Percentage { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
