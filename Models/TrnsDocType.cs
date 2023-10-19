using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrnsDocType
    {
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public int DocTypeNmbr { get; set; }
        public bool? Mandatory { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
