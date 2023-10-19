using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TempSaldoPesertum
    {
        public DateTime? EfctvDt { get; set; }
        public string EmployeeNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public double? EeCntrb { get; set; }
        public double? ErCntrb { get; set; }
        public double? TuCntb { get; set; }
        public double? FtCntrb { get; set; }
        public double? TaEe { get; set; }
        public double? TaEr { get; set; }
        public double? EeIr { get; set; }
        public double? ErIr { get; set; }
        public double? TuIr { get; set; }
        public double? FtIr { get; set; }
        public double? Wd { get; set; }
        public double? Fee { get; set; }
        public double? AcctVal { get; set; }
        public double? EstTax { get; set; }
        public double? EstFee { get; set; }
    }
}
