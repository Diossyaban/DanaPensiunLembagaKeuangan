using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIndPilihanInvestasi
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public string InvTypeNm { get; set; }
        public string MoneyTypeNm { get; set; }
        public double Percentage { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
