using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PaymentTrnsType
    {
        public int PaymentTrnsNmbr { get; set; }
        public string PaymentTrnsNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
