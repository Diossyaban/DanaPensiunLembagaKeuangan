using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class IndeksPrice
    {
        public DateTime EfctvDt { get; set; }
        public double? PriceIhsg { get; set; }
        public double? PriceIgbi { get; set; }
        public double? PriceIcbi { get; set; }
        public double? PriceHsbc { get; set; }
    }
}
