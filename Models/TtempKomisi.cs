using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TtempKomisi
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
        public string KodeAgen { get; set; }
        public string KodeAgenPerekrut { get; set; }
        public string KodeKantor { get; set; }
        public string KodeJabatan { get; set; }
        public string KodeAtasan { get; set; }
        public string Npwp { get; set; }
        public DateTime? TglAwalNpwp { get; set; }
        public DateTime? TglAkhirNpwp { get; set; }
        public string NamaAgen { get; set; }
        public string NoIdentitas { get; set; }
        public string Alamat { get; set; }
        public string KodeKota { get; set; }
        public string TempatLahir { get; set; }
        public DateTime? TglLahir { get; set; }
        public string JenisKelamin { get; set; }
        public string KodeStatusKawin { get; set; }
        public string Agama { get; set; }
        public string Pendidikan { get; set; }
        public string NoTelepon { get; set; }
        public string NoHandphone { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
        public string UserEntry { get; set; }
        public string HostEntry { get; set; }
        public short Status { get; set; }
        public string Sam { get; set; }
        public int? JenisAgen { get; set; }
        public string JenisPajak { get; set; }
        public int? StatusFaktur { get; set; }
        public int? StatusPkp { get; set; }
        public string NamaTim { get; set; }
        public string NamaJabatan { get; set; }
        public string NoRekening { get; set; }
        public string KodeBank { get; set; }
        public string AtasNama { get; set; }
        public string Cabang { get; set; }
        public string NoLisensi { get; set; }
        public DateTime? TglAkhir { get; set; }
        public DateTime? EfctvDt { get; set; }
    }
}
