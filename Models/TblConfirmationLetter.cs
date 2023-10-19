using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblConfirmationLetter
    {
        public string IdLetter { get; set; }
        public string DateSurat { get; set; }
        public string CompanyNm { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string ContactPerson { get; set; }
        public int? CerNmbr { get; set; }
        public string Dob { get; set; }
        public string ClientNm { get; set; }
        public string Autorized { get; set; }
        public string AutorizedPosition { get; set; }
        public string UserId { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
