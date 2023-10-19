using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TfrequencyType
    {
        public int FreqTypeNmbr { get; set; }
        public string FreqTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
