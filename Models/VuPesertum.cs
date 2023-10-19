using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VuPesertum
    {
        public int KodePerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public int KodePeserta { get; set; }
        public string NamaPeserta { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string AlamatPeserta { get; set; }
        public string KodePos { get; set; }
        public string Telpon { get; set; }
        public string NamaIbuKandung { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime? TanggalPensiun { get; set; }
    }
}
