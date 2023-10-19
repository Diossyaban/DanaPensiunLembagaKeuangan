using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CreditCard
    {
        public int CerNmbr { get; set; }
        public string CreditCardNmbr { get; set; }
        public DateTime ExpireDt { get; set; }
        public int BankTypeNmbr { get; set; }
        public int CreditCardTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
