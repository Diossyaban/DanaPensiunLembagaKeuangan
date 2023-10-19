using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TjobVctnType
    {
        public short JobVctnNmbr { get; set; }
        public string JobVctnNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
