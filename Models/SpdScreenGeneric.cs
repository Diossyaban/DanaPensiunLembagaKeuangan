using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdScreenGeneric
    {
        public string ScreenId { get; set; }
        public string ScreenDesc { get; set; }
        public string SelectQuery { get; set; }
        public string SubmitSp { get; set; }
    }
}
