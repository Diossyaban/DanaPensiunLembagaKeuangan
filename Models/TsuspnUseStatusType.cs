using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TsuspnUseStatusType
    {
        public int UseStatusNmbr { get; set; }
        public string UseStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
