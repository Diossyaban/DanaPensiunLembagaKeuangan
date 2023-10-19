using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIndSaldoPesertum
    {
        public DateTime EfctvDt { get; set; }
        public int CerNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public string InvTypeNm { get; set; }
        public double? Unit { get; set; }
        public double Harga { get; set; }
        public double? SaldoValuasi { get; set; }
    }
}
