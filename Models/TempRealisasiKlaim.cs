using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TempRealisasiKlaim
    {
        public string KodePerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public string KodePerusahaanAsal { get; set; }
        public string NamaPerusahaanAsal { get; set; }
        public string KodePeserta { get; set; }
        public string KodePegawai { get; set; }
        public string Npwp { get; set; }
        public string NamaPeserta { get; set; }
        public DateTime? TanggalLahir { get; set; }
        public DateTime? TanggalTransaksi { get; set; }
        public string JenisPenarikan { get; set; }
        public string KodePenarikan { get; set; }
        public string TrnsTypeNmbr { get; set; }
        public double? JumlahBayar { get; set; }
        public double? Pajak { get; set; }
        public double? Biaya { get; set; }
        public double? JumlahDiterima { get; set; }
        public double? IuranPeserta { get; set; }
        public double? IuranPemberiKerja { get; set; }
        public double? InvestasiPeserta { get; set; }
        public double? InvestasiPemberiKerja { get; set; }
        public double? Withdrawal { get; set; }
        public double? Fee { get; set; }
        public double? AcctVal { get; set; }
        public string KodeBankLumpsum { get; set; }
        public string NoRekLumpsum { get; set; }
        public string NamaBankLumpsum { get; set; }
        public string NamaCabangLumpsum { get; set; }
        public string AtasNamaLumpsum { get; set; }
        public double? JumlahLumpsum { get; set; }
        public string KodeBankAnuitas { get; set; }
        public string NoRekAnuitas { get; set; }
        public string NamaBankAnuitas { get; set; }
        public string NamaCabangAnuitas { get; set; }
        public string AtasNamaAnuitas { get; set; }
        public double? JumlahAnuitas { get; set; }
        public string AlamatPeserta { get; set; }
        public string KodePos { get; set; }
        public string Provinsi { get; set; }
        public DateTime? TglBayar { get; set; }
        public string SourceType { get; set; }
        public string SourceTypeNm { get; set; }
        public string MetodePengajuan { get; set; }
        public string NoPengajuan { get; set; }
        public DateTime? TanggalPengajuan { get; set; }
        public string StatusPengajuan { get; set; }
    }
}
