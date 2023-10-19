using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadMandiriIiClaim
    {
        public string ClientNm { get; set; }
        public DateTime? Dob { get; set; }
        public int? GroupNmbr { get; set; }
        public string Nip { get; set; }
        public string SalesNm { get; set; }
        public string Phone { get; set; }
        public string Npwp { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string ClaimTypeNm { get; set; }
        public int? TransferMethod { get; set; }
        public DateTime? AppReceiveDt { get; set; }
        public string Hostname { get; set; }
        public string Pic { get; set; }
    }
}
