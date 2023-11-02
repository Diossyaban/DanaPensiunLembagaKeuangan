using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DPLK.Models
{
    public class DplkRollover
    {
        [Key]
        [Display(Name = "Institution Code")]
        public int? DplkNmbr { get; set; }

        [Display(Name = "Institution Name")]
        public string DplkNm { get; set; }

        [Display(Name = "Bank Name")]
        public string BankNm { get; set; }

        [Display(Name = "Account Number")]
        public string AcctNmbr { get; set; }

        [Display(Name = "Last Change Date")]
        public DateTime? LastChangeDt { get; set; }

        [Display(Name = "Address 1")]
        public string DplkAddress1 { get; set; }

        [Display(Name = "Address 2")]
        public string DplkAddress2 { get; set; }

        [Display(Name = "Address 3")]
        public string DplkAddress3 { get; set; }

        [Display(Name = "City")]
        public string DplkCity { get; set; }

        [Display(Name = "Postal Code")]
        public string DplkPostalCd { get; set; }

        [Display(Name = "Contact Person")]
        public string DplkContactPerson { get; set; }
    }
}