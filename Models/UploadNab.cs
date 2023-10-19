using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadNab
    {
        public DateTime EfctvDt { get; set; }
        public int InvTypeNmbr { get; set; }
        public double? Nab { get; set; }
        public double? SuspenseUnit { get; set; }
        public string Hostname { get; set; }
    }
}
