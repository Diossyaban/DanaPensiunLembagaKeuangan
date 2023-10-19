using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tpic
    {
        public string PicName { get; set; }
        public string PicSignature { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
