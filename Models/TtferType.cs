using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtferType
    {
        public int TferTypeNmbr { get; set; }
        public string TferTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
