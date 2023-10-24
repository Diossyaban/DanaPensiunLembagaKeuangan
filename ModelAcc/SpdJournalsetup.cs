using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdJournalsetup
    {
        public string TrnsTypeNmbr { get; set; }
        public int? Inv { get; set; }
        public int Seq { get; set; }
        public string Acc { get; set; }
        public double? AccPrc { get; set; }
        public string Dc { get; set; }
    }
}
