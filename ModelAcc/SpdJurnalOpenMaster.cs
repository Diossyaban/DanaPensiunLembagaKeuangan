using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdJurnalOpenMaster
    {
        public string TrnsId { get; set; }
        public string Descr { get; set; }
        public DateTime? TrnsDate { get; set; }
        public string Userid { get; set; }
        public bool? Approved { get; set; }
    }
}
