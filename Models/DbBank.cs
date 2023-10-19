using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class DbBank
    {
        public int SeqNmbr { get; set; }
        public string BankNmbr { get; set; }
        public string BankBiNmbr { get; set; }
        public string BankNm { get; set; }
        public string BankAddr { get; set; }
        public int? BankCentral { get; set; }
    }
}
