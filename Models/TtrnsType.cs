using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtrnsType
    {
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public string SubTrnsNm { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
