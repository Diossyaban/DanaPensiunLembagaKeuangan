using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TjobLvlType
    {
        public int JobLvlNmbr { get; set; }
        public string JobLvlNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
