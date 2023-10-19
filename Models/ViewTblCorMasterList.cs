using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewTblCorMasterList
    {
        public int Username { get; set; }
        public int NoPeserta { get; set; }
        public string NoPesertaLama { get; set; }
        public string NamaPerusahaan { get; set; }
        public DateTime? PeriodeKeuangan { get; set; }
        public string Nip { get; set; }
        public string NamaPegawai { get; set; }
        public string Lokasi { get; set; }
        public DateTime TglLahir { get; set; }
        public double? KumpulanIuranPeserta { get; set; }
        public double? KumpulanIuranPerusahaan { get; set; }
        public double? KumDanaAwalIuranPeserta { get; set; }
        public double? KumDanaAwalIuranPerusahaan { get; set; }
        public double? KumDanaAwalInvestasiPeserta { get; set; }
        public double? KumDanaAwalInvestasiPerusahaan { get; set; }
        public double? KumDppk { get; set; }
        public double? KumManfaat { get; set; }
        public double? AdminFeeDanLainnya { get; set; }
        public double? HasilInvestasiPeserta { get; set; }
        public double? HasilInvestasiPerusahaan { get; set; }
        public double? HasilInvestasiTambahan { get; set; }
        public double? HasilInvestasiDppk { get; set; }
        public double? Saldo { get; set; }
    }
}
