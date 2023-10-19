using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BankType
    {
        public int BankTypeNmbr { get; set; }
        public string BankTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
