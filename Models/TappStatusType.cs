using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TappStatusType
    {
        public short AppStatusNmbr { get; set; }
        public string AppStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
