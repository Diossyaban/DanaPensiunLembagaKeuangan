using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tcounter
    {
        public int CounterNmbr { get; set; }
        public string CounterNm { get; set; }
        public string LastNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
