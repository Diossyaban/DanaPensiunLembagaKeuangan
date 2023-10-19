using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VClaimRequest4
    {
        public string Batch { get; set; }
        public DateTime? TheDate { get; set; }
        public string TheDate1 { get; set; }
        public string RegId { get; set; }
        public int TrnsId { get; set; }
        public string TransType { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string TakenBy { get; set; }
        public string ClaimStatus { get; set; }
    }
}
