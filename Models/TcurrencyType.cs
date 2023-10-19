using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcurrencyType
    {
        public int CurrencyTypeNmbr { get; set; }
        public string CurrencyTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
