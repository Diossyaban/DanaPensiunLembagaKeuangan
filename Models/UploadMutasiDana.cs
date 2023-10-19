using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadMutasiDana
    {
        public int? SourceCer { get; set; }
        public int? DestinationCer { get; set; }
        public double? Amount { get; set; }
        public string Hostname { get; set; }
        public string Pic { get; set; }
    }
}
