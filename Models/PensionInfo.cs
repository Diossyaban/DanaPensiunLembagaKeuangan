using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PensionInfo
    {
        public string DplkNm { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string PelaksanaTugas { get; set; }
        public string LevelJabatan { get; set; }
        public string BillingSignature { get; set; }
        public string ClaimSignature { get; set; }
        public string LetterSignature { get; set; }
        public string BankNm { get; set; }
        public string AccountNmbr { get; set; }
        public string AccountNm { get; set; }
        public string Branch { get; set; }
        public int? ProductTypeNmbr { get; set; }
    }
}
