using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GroupTax
    {
        public int GroupNmbr { get; set; }
        public int TaxTypeNmbr { get; set; }
        public int MainTaxSeqNmbr { get; set; }
        public DateTime? TaxEfctvDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
