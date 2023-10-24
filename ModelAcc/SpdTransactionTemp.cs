using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdTransactionTemp
    {
        public string TrnsId { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public string GlCode { get; set; }
        public string Dc { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public double Amount { get; set; }
        public string Userid { get; set; }
        public DateTime? TrnsDate { get; set; }
    }
}
