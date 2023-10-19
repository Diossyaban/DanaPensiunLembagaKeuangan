using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PercentAsset
    {
        public DateTime EfctvDt { get; set; }
        public short? InvTypeNmbr { get; set; }
        public short? AssetTypeNmbr { get; set; }
        public double? Persen { get; set; }
    }
}
