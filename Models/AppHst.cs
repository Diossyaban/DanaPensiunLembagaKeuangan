using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AppHst
    {
        public int CerNmbr { get; set; }
        public short? AppStatusNmbr { get; set; }
        public DateTime? ChangeDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
