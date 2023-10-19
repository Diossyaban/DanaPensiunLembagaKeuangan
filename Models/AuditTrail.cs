using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AuditTrail
    {
        public string TableNm { get; set; }
        public string FieldNm { get; set; }
        public string UsrId { get; set; }
        public string HostNm { get; set; }
        public string AppNm { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime CycleDt { get; set; }
        public int? GroupNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }
        public string Info4 { get; set; }
        public string Info5 { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int CodeType { get; set; }
    }
}
