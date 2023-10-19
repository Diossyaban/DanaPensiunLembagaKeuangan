using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TphoneType
    {
        public int PhoneTypeNmbr { get; set; }
        public string PhoneTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
