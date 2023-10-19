using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TexceptionType
    {
        public short ExceptionTypeNmbr { get; set; }
        public string ExceptionTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
