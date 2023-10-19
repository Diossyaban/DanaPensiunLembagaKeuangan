using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class CycleProcess
    {
        public int? CycleId { get; set; }
        public DateTime? CycleDt { get; set; }
        public string ProcessDesc { get; set; }
        public string ProcessFlg { get; set; }
        public string ErrorDesc { get; set; }
    }
}
