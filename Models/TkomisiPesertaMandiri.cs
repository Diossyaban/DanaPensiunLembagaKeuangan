using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TkomisiPesertaMandiri
    {
        public int CerNmbr { get; set; }
        public string NamaPemohon { get; set; }
        public string NamaDanaPensiun { get; set; }
        public double? NilaiDanaAwal { get; set; }
        public double? NilaiIuran { get; set; }
        public double? AdminFee { get; set; }
        public int? PersenKomisi { get; set; }
        public string NamaAgen { get; set; }
        public DateTime? TglBayar { get; set; }
        public string IdAgen { get; set; }
        public double? KomisiTahun1 { get; set; }
        public double? KomisiTahun2 { get; set; }
    }
}
