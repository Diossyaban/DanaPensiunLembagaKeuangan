using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwKomisiDplk
    {
        public string NamaPemohon { get; set; }
        public string NamaDanaPensiun { get; set; }
        public string IdRegistrasi { get; set; }
        public double? NilaiIuran { get; set; }
        public double? AdminFee { get; set; }
        public string NamaAgen { get; set; }
        public DateTime? TanggalBayar { get; set; }
        public string NoCdv { get; set; }
        public string IdAgen { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
    }
}
