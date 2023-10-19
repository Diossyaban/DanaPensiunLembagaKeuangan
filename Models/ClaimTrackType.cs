using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ClaimTrackType
    {
        public short TrackTypeNmbr { get; set; }
        public string TrackTypeNm { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
