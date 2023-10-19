using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpFirBck
    {
        public string InvTypeNm { get; set; }
        public string Unit { get; set; }
        public string Price { get; set; }
        public string AcctVal { get; set; }
        public string MoneyTypeNm { get; set; }
        public double? Percentage { get; set; }
    }
}
