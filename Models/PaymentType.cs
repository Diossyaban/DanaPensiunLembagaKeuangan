using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PaymentType
    {
        public short PaymentTypeNmbr { get; set; }
        public string PaymentNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
