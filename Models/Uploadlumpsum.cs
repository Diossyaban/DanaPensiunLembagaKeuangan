using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Uploadlumpsum
    {
        public double? NoPeserta { get; set; }
        public string NamaPeserta { get; set; }
        public double? Gross { get; set; }
        public double? Tax { get; set; }
        public decimal? Fee { get; set; }
        public double? Net { get; set; }
        public string NamaBank { get; set; }
        public string NomorRekening { get; set; }
        public string NamaPenerima { get; set; }
        public double? Lumpsum { get; set; }
    }
}
