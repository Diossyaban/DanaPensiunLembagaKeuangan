using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SuspnApprvHst
    {
        public int SeqNmbr { get; set; }
        public long? SuspnNmbr { get; set; }
        public DateTime? EfctvDt { get; set; }
        public int? SuspnStatusCd { get; set; }
        public string SuspDesc2 { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string RefBank { get; set; }
    }
}
