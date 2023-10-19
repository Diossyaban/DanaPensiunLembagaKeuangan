using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdError
    {
        public DateTime? TheDate { get; set; }
        public string Userid { get; set; }
        public string Part { get; set; }
        public string Descr { get; set; }
    }
}
