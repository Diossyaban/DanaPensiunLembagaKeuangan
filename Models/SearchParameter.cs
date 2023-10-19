using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SearchParameter
    {
        public int? Type { get; set; }
        public string FieldNm { get; set; }
        public string FieldType { get; set; }
    }
}
