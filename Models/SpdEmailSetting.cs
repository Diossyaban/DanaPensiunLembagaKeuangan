using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdEmailSetting
    {
        public string Smtp { get; set; }
        public string Sender { get; set; }
        public string Recipients { get; set; }
    }
}
