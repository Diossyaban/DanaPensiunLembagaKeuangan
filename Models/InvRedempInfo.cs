using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class InvRedempInfo
    {
        public short InvTypeNmbr { get; set; }
        public string BankNm { get; set; }
        public string BankAccNm { get; set; }
        public string BankAccNmbr { get; set; }
        public string Pic { get; set; }
        public string PicPost { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
