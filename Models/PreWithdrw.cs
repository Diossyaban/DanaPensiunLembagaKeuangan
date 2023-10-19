using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PreWithdrw
    {
        public int SeqNmbr { get; set; }
        public DateTime CreateDt { get; set; }
        public int CerNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public int? GsTerminateNmbr { get; set; }
        public int WdStatusNmbr { get; set; }
        public DateTime? WdStatusdocDt { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? CerNmbrMpp { get; set; }
        public DateTime? ReceivedDt { get; set; }
        public string ProcessorId { get; set; }
        public string Note { get; set; }
    }
}
