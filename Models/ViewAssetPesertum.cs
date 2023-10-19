using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewAssetPesertum
    {
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public int InvTypeNmbr { get; set; }
        public double? Contrib { get; set; }
        public double? Distrib { get; set; }
        public double? NetContrib { get; set; }
        public double? Earning { get; set; }
        public double? Fee { get; set; }
        public double? AcctVal { get; set; }
        public double? Unit { get; set; }
        public DateTime? PeriodDt { get; set; }
    }
}
