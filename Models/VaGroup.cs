using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VaGroup
    {
        public string VaAccnNmbr { get; set; }
        public int? GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public DateTime? CreateDt { get; set; }
        public bool? Isactive { get; set; }
        public DateTime? ActiveDt { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? DeletedDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
