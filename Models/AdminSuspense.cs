using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models
{
    [Keyless]
    public class AdminSuspense
    {
        [Key]
        public long suspn_nmbr { get; set; }
        public double suspn_amt { get; set; }
        public string suspn_desc1 { get; set; }
        public string suspn_type_nm { get; set; }
        public string received_dt { get; set; }
        public int? group_nmbr { get; set; }
        public string company_nm { get; set; }
        public string paycenter_nm { get; set; }
        public DateTime datesorting { get; set; }
        public string Ref_Bank { get; set; }
    }
}
