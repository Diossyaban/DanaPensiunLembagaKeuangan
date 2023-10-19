using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ClaimRegisterTrack
    {
        public string CrId { get; set; }
        public short TrackTypeNmbr { get; set; }
        public string Userid { get; set; }
        public DateTime? TrackDate { get; set; }
    }
}
