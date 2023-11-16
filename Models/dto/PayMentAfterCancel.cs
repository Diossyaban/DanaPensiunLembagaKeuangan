using System;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models.dto
{
    public class PayMentAfterCancel
    {
        public string company_nm { get; set; }
        
        public int group_nmbr { get; set; }
        [Key]
        public int paycenter_nmbr { get; set; }
        public DateTime efctv_dt { get; set; }
        public int seq_nmbr { get; set; }
        public int type { get; set; }
        public string type_description { get; set; }
        public double amt { get; set; }
        public DateTime approval_dt { get; set; }
    }
}
