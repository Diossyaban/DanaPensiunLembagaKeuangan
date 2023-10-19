using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TvaProductType
    {
        public string VaNmbr { get; set; }
        public int? ProductTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
