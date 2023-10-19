using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class WdTransferType
    {
        public int? WdTransferNmbr { get; set; }
        public string WdTransferNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
