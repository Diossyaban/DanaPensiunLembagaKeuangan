using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdCertificateIuranInvestasiByperson
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int CerNmbr { get; set; }
        public string EmployeeNmbr { get; set; }
        public string ClientNm { get; set; }
        public DateTime BirthDt { get; set; }
        public DateTime EfctvDt { get; set; }
        public string Branch { get; set; }
    }
}
