using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmaritalStatusType
    {
        public short MaritalStatusNmbr { get; set; }
        public string MaritalStatusNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
