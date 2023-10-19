using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class RfTableReference
    {
        public string Tablename { get; set; }
        public int Colid { get; set; }
        public string Refertable { get; set; }
        public string Referfield1 { get; set; }
        public string Referfield2 { get; set; }
        public string Condition { get; set; }
        public bool? ConditionCreateby { get; set; }
        public string Orderby { get; set; }
    }
}
