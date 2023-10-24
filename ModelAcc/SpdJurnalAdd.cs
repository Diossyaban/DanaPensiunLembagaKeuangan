using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdJurnalAdd
    {
        public string TrnsId { get; set; }
        public string GlCode { get; set; }
        public string Slcode { get; set; }
        public int SubTrnsNmbr { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
