using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwSuratPengantarKartuPerusahaan
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public string ContactPerson { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string ClientNm { get; set; }
        public string EmployeeNmbr { get; set; }
        public int CerNmbr { get; set; }
        public string BirthDt { get; set; }
        public string EfctvDt { get; set; }
        public string RetireDt { get; set; }
    }
}
