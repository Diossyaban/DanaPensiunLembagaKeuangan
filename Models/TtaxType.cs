using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtaxType
    {
        public int? TaxTypeNmbr { get; set; }
        public string TaxTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
