using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DPLK.Models.dto
{
    
    public class GetPaymentForApproval
    {

        [Column("company_nm")]
        public string CompanyName { get; set; }

        [Key]
        [Column("group_nmbr")]
        public int GroupNumber { get; set; }

        [Column("paycenter_nmbr")]
        public int PayCenterNumber { get; set; }

        [Column("efctv_dt")]
        public DateTime EffectiveDate { get; set; }

        [Column("seq_nmbr")]
        public int SequenceNumber { get; set; }

        [Column("type")]
        public int Type { get; set; }

        [Column("type_description")]
        public string TypeDescription { get; set; }

        [Column("amt", TypeName = "float")]
        public double Amount { get; set; }

    }
}
