using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdIuranInvestasiByperson
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int CerNmbr { get; set; }
        public string EmployeeNmbr { get; set; }
        public string ClientNm { get; set; }
        public DateTime Dob { get; set; }
        public DateTime? RetirementDt { get; set; }
        public DateTime EfctvDt { get; set; }
        public double? EeCntrb { get; set; }
        public double? ErCntrb { get; set; }
        public double? TuCntrb { get; set; }
        public double? FtCntrb { get; set; }
        public double? TaEe { get; set; }
        public double? TaEr { get; set; }
        public double? EeIr { get; set; }
        public double? ErIr { get; set; }
        public double? TuIr { get; set; }
        public double? FtIr { get; set; }
        public double? Wd { get; set; }
        public double? WdTrmnt { get; set; }
        public double? Fee { get; set; }
        public double? AcctVal { get; set; }
        public DateTime CreateDt { get; set; }
    }
}
