using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BeneType
    {
        public int? BeneTypeNmbr { get; set; }
        public string BeneTypeNm { get; set; }
        public int? ParentBeneTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
