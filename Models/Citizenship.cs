using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Citizenship
    {
        public short CitizenshipCd { get; set; }
        public string CitizenshipNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
