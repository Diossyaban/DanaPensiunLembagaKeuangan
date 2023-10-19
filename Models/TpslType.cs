using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TpslType
    {
        public int PslTypeNmbr { get; set; }
        public string PslTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
