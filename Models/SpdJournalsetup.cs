using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdJournalsetup
    {
        public int? TrnsTypeNmbr { get; set; }
        public int? Seq { get; set; }
        public string DebtAcc { get; set; }
        public string CredAcc { get; set; }
    }
}
