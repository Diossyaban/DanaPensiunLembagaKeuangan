using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public class AgentCommison
    {
        public int group_nmbr { get; set; }
        public string company_nm { get; set; }
        public int agent_nmbr { get; set; }
        public string agent_nm { get; set; }
        public string EfctvDate { get; set; }
        public string TerminationDate { get; set; }
        public double? comm_pct { get; set; }
        public double? comm_amt { get; set; }
        public double? max_comm { get; set; }
    }
}
