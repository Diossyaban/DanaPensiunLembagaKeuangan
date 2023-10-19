using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Exception
    {
        public DateTime CycleDt { get; set; }
        public short ExceptionTypeNmbr { get; set; }
        public int? GroupNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public short? TrnsType { get; set; }
        public short? SubTrnsNmbr { get; set; }
        public double? Amount { get; set; }
    }
}
