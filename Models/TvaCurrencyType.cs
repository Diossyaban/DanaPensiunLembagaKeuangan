using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TvaCurrencyType
    {
        public string VaNmbr { get; set; }
        public string CurrencyTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
