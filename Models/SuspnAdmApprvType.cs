using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SuspnAdmApprvType
    {
        public int AdmApprvTypeNmbr { get; set; }
        public string AdmApprvTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
