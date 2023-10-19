using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrnsPost
    {
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public bool? DebetPost { get; set; }
        public bool? CreditPost { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
