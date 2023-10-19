using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TidType
    {
        public short IdentityType { get; set; }
        public string IdentityNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
