using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TsuspnFinApprvType
    {
        public int FinApprvTypeNmbr { get; set; }
        public string FinApprvTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
