using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwKomisiPengalihan
    {
        public int CerNmbr { get; set; }
        public string NamaPemohon { get; set; }
        public string NamaDanaPensiun { get; set; }
        public string IdRegistrasi { get; set; }
        public double? NilaiIuran { get; set; }
        public double? AdminFee { get; set; }
        public double? PersenKomisi { get; set; }
        public string NameAgen { get; set; }
        public DateTime? TanggalBayar { get; set; }
        public string NoCdv { get; set; }
        public string IdAgen { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public DateTime TglEntry { get; set; }
    }
}
