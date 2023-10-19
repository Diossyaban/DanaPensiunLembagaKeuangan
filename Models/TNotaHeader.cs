using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TNotaHeader
    {
        public string NoNota { get; set; }
        public string NoKontrak { get; set; }
        public string NoSurat { get; set; }
        public DateTime? TglJatuhTempo { get; set; }
        public int? JmlKaryawan { get; set; }
        public decimal? JmlPembayaran { get; set; }
        public string JangkaPembayaran { get; set; }
        public DateTime? TglTerbit { get; set; }
        public string KantorPerwakilan { get; set; }
        public string Up { get; set; }
        public string NamaPerusahaan { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string KodePos { get; set; }
        public string Perihal { get; set; }
        public string NamaBank { get; set; }
        public string CabangBank { get; set; }
        public string NoRekening { get; set; }
        public string AtasNama { get; set; }
        public string Penyetuju { get; set; }
    }
}
