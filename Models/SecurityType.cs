using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SecurityType
    {
        public int SecTypeNmbr { get; set; }
        public string SecTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
