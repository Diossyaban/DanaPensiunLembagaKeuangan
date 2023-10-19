using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TaddressType
    {
        public int AddrTypeNmbr { get; set; }
        public string AddrTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
