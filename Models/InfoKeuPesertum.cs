using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class InfoKeuPesertum
    {
        public int? CerNmbr { get; set; }
        public int? MoneyType { get; set; }
        public int? InvType { get; set; }
        public double? Contrib { get; set; }
        public double? Distrib { get; set; }
        public double? NetContrib { get; set; }
        public double? Earning { get; set; }
        public double? Fee { get; set; }
        public double? AcctVal { get; set; }
        public double? Unit { get; set; }
    }
}
