using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VaCurrencyType
    {
        public string VaNmbr { get; set; }
        public string CurrencyTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
