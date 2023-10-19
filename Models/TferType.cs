using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TferType
    {
        public int TferTypeNmbr { get; set; }
        public string TferTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
