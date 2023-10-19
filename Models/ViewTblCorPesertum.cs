using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewTblCorPesertum
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public string Email { get; set; }
        public double? TotalParticipant { get; set; }
        public double? IuranPerusahaan { get; set; }
        public double? IuranKaryawan { get; set; }
        public double? IuranTambahan { get; set; }
        public double? IuranDppk { get; set; }
        public double? DanaAwalPerusahaan { get; set; }
        public double? DanaAwalPeserta { get; set; }
        public double? DanaAwalTambahan { get; set; }
        public double? DanaAwalDppk { get; set; }
        public double? DanaAwalInvestasiPerusahaan { get; set; }
        public double? DanaAwalInvestasiPeserta { get; set; }
        public double? TotalKaryawanPensiun { get; set; }
        public double? TotalKaryawanAlih { get; set; }
        public double? TotalPembayaranPensiun { get; set; }
        public double? TotalAsetKelolaan { get; set; }
    }
}
