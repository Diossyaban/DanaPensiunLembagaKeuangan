﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PaymentApprvType
    {
        public int? PaymentApprvNmbr { get; set; }
        public string PaymentApprvNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    
    }
}
