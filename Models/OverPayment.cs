using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class OverPayment
    {
        public int GroupNmbr { get; set; }
        public DateTime PaidDt { get; set; }
        public double OverPmt { get; set; }
        public string Comment { get; set; }
    }
}
