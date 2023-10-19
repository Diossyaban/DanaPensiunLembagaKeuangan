using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class StatusType
    {
        public StatusType()
        {
            CerStatuses = new HashSet<CerStatus>();
        }

        public int StatusTypeNmbr { get; set; }
        public string StatusTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<CerStatus> CerStatuses { get; set; }
    }
}
