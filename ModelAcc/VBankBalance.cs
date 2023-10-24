using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VBankBalance
    {
        public string Slcode { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public double? Saldo { get; set; }
        public int Monthperiod { get; set; }
        public int Yearperiod { get; set; }
    }
}
