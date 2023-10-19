using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TstatusType
    {
        public int StatusTypeNmbr { get; set; }
        public string StatusTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
