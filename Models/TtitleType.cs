using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtitleType
    {
        public int TitleTypeNmbr { get; set; }
        public string TitleTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
