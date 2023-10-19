using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PtcpExit
    {
        public int SeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public DateTime? ExitDt { get; set; }
        public DateTime? ChangeDt { get; set; }
        public int? TrnsSeqNmbr { get; set; }
    }
}
