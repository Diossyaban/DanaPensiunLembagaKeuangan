using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class XspdJurnalKonsolidasiMapping
    {
        public string NewTrnsId { get; set; }
        public string OldTrnsId { get; set; }
        public string LastTrnsId { get; set; }
        public int? Status { get; set; }
        public string Approveby { get; set; }
        public DateTime? Approvedate { get; set; }
    }
}
