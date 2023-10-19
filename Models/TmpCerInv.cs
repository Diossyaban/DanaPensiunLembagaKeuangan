using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmpCerInv
    {
        public int? CerNmbr { get; set; }
        public int? MoneyTypeNmbr { get; set; }
        public int? InvTypeNmbr { get; set; }
        public long? UnitCount { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
