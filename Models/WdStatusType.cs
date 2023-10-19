using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class WdStatusType
    {
        public int WdStatusNmbr { get; set; }
        public string WdStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
