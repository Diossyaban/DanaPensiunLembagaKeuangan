using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIndPesertum
    {
        public int CerNmbr { get; set; }
        public string ClientNm { get; set; }
        public DateTime BirthDt { get; set; }
        public string CompanyNm { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime? RetirementDt { get; set; }
        public int GroupNmbr { get; set; }
        public int CompanyCode { get; set; }
        public string BeneNm { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public short? ProvinceNmbr { get; set; }
        public string ProvinceNm { get; set; }
        public string AddrTypeNm { get; set; }
        public string PostalCd { get; set; }
        public string EmailAddr { get; set; }
        public string IdentityNmbr { get; set; }
        public string TaxIdNmbr { get; set; }
        public string MobilePhoneNmbr { get; set; }
        public string EmployeeNmbr { get; set; }
        public string MaidenNm { get; set; }
    }
}
