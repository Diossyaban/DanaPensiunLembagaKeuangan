using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AppStatusType
    {
        public short AppStatusNmbr { get; set; }
        public string AppStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
