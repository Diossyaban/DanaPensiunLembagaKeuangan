using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class JobVctnType
    {
        public short JobVctnNmbr { get; set; }
        public string JobVctnNm { get; set; }
        public string OldtTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
