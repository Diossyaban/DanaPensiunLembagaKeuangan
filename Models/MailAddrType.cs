using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class MailAddrType
    {
        public short MailAddrOpt { get; set; }
        public string MailAddrNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
