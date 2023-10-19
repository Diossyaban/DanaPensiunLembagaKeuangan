using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmpClaimRequest
    {
        public string CrId { get; set; }
        public DateTime? Thedate { get; set; }
        public string BatchId { get; set; }
        public string Takenby { get; set; }
        public DateTime? Takendate { get; set; }
    }
}
