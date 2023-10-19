using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Benchmark
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public double BenchmarkRt { get; set; }
        public double? MandiriRt { get; set; }
        public double? BniRt { get; set; }
        public double? BriRt { get; set; }
        public double? BtnRt { get; set; }
    }
}
