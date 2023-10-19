using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmoneyType
    {
        public int MoneyTypeNmbr { get; set; }
        public string MoneyTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
