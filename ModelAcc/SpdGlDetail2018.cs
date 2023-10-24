using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdGlDetail2018
    {
        public string Code { get; set; }
        public string Slcode { get; set; }
        public int Monthperiod { get; set; }
        public int Yearperiod { get; set; }
        public double? StartD { get; set; }
        public double? StartC { get; set; }
        public double? MovD { get; set; }
        public double? MovC { get; set; }
        public double? EndD { get; set; }
        public double? EndC { get; set; }
        public string Owner { get; set; }
        public string Curr { get; set; }
    }
}
