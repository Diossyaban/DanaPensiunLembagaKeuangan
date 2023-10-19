using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class MaturityType
    {
        public short MaturityTypeNmbr { get; set; }
        public string MaturityTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
