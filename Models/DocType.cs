using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class DocType
    {
        public int DocTypeNmbr { get; set; }
        public string DocTypeNm { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
