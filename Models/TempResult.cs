using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TempResult
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public string CompanyNm { get; set; }
        public double? AccValue { get; set; }
        public double? EstValue { get; set; }
    }
}
