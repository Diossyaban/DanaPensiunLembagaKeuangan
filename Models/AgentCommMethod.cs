using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AgentCommMethod
    {
        public int GroupNmbr { get; set; }
        public int AgentNmbr { get; set; }
        public DateTime? EfctvDt { get; set; }
        public double? CommPct { get; set; }
        public double? CommAmt { get; set; }
        public double? MaxComm { get; set; }
        public DateTime? TerminationDt { get; set; }
        public DateTime? LastChangeDt { get; set; }


    }
}
