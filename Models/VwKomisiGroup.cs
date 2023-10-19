using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VwKomisiGroup
    {
        public int GroupNmbr { get; set; }
        public int CerNmbr { get; set; }
        public string NamaPemohon { get; set; }
        public string NamaDanaPensiun { get; set; }
        public double? NilaiDanaAwal { get; set; }
        public double? NilaiIuran { get; set; }
        public double? AdminFee { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public string IdAgen { get; set; }
        public double? KomisiTahun1 { get; set; }
        public double? KomisiTahun2 { get; set; }
        public int? TahunKe { get; set; }
        public short? FlagKomisi1 { get; set; }
        public short? FlagKomisi2 { get; set; }
        public int? CntrbSeqNmbr { get; set; }
    }
}
