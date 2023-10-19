using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadSuspense
    {
        public string SuspenseDesc { get; set; }
        public double? Amount { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public int? SuspenseType { get; set; }
        public string RefBank { get; set; }
        public string Hostname { get; set; }
    }
}
