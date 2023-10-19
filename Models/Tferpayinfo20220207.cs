using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tferpayinfo20220207
    {
        public double? NoPeserta { get; set; }
        public string NamaPeserta { get; set; }
        public string Npwp { get; set; }
        public string JenisPenarikan { get; set; }
        public double? Gross { get; set; }
        public double? Pajak { get; set; }
        public double? Biaya { get; set; }
        public double? Net { get; set; }
        public string NamaBank { get; set; }
        public double? NomorRekening { get; set; }
        public string NamaPenerima { get; set; }
        public double? JumlahTransferLumpsum { get; set; }
        public string NamaBank1 { get; set; }
        public string NomorRekening1 { get; set; }
        public string NamaPenerima1 { get; set; }
        public double? JumlahTransferAnuitas { get; set; }
    }
}
