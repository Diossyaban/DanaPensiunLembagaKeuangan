using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdScreenField
    {
        public string Tablename { get; set; }
        public string FieldName { get; set; }
        public string FieldDesc { get; set; }
        public string FieldType { get; set; }
        public int? FieldLen { get; set; }
        public int? FieldPrimary { get; set; }
        public bool? Enable { get; set; }
        public string LookupQy { get; set; }
    }
}
