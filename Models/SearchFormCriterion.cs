using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SearchFormCriterion
    {
        public int? Code { get; set; }
        public string Fieldname { get; set; }
        public string Fieldalias { get; set; }
        public string Type { get; set; }
    }
}
