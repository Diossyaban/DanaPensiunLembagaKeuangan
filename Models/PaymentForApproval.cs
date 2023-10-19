using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DPLK.Models
{
    [Keyless] 
    public class PaymentForApproval
    {
        [Column("company_nm")]
        public string CompanyName { get; set; }      
        [Column("group_nmbr")]
        public int GroupNumber { get; set; }
        [Column("paycenter_nmbr")]
        public int PaycenterNumber { get; set; }
        [Column("efctv_dt")]
        public DateTime EffectiveDate { get; set; }
        [Column("seq_nmbr")]
        public int SequenceNumber { get; set; }
        public int Type { get; set; }
        [Column("type_description")]
        public string TypeDescription { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }

    }

}

