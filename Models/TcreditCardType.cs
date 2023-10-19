using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcreditCardType
    {
        public int CreditCardTypeNmbr { get; set; }
        public string CreditCardNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
