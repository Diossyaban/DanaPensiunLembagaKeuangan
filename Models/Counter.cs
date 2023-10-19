using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Counter
    {
        public int CounterNmbr { get; set; }
        public string CounterNm { get; set; }
        public string LastNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
