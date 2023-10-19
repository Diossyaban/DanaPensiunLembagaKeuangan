using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CerStatus
    {
        public DateTime EfctvDt { get; set; }
        public int CerNmbr { get; set; }
        public int StatusTypeNmbr { get; set; }
        public DateTime ChangeDt { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual Certificate CerNmbrNavigation { get; set; }
        public virtual StatusType StatusTypeNmbrNavigation { get; set; }
    }
}
