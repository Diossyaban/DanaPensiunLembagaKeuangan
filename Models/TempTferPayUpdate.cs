using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TempTferPayUpdate
    {
        public double? NoPeserta { get; set; }
        public string NamaPeserta { get; set; }
        public string Npwp { get; set; }
        public string JenisPenarikan { get; set; }
        public string Gross { get; set; }
        public string Pajak { get; set; }
        public DateTime? Biaya { get; set; }
        public string Net { get; set; }
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
