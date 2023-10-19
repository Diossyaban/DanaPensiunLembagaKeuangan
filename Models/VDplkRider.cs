using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VDplkRider
    {
        public int KdPerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public int KodePeserta { get; set; }
        public string NamaPeserta { get; set; }
        public string NomorPegawai { get; set; }
        public DateTime TanggalLahir { get; set; }
        public DateTime TanggalMulai { get; set; }
        public DateTime? TanggalPensiun { get; set; }
        public string AlamatEmail { get; set; }
        public string Status { get; set; }
        public string AlamatPeserta { get; set; }
        public DateTime BillingPeriode { get; set; }
        public int Id { get; set; }
        public string FundAllocation { get; set; }
        public DateTime? TanggalValuasi { get; set; }
        public string NomorFlp { get; set; }
        public string NomorCrv { get; set; }
        public double? JumlahValuasi { get; set; }
        public string Deskripsi { get; set; }
        public string TanggalJurnal { get; set; }
        public string JenisKomisi { get; set; }
        public string JenisPremi { get; set; }
        public string JenisRider { get; set; }
        public string SalesName { get; set; }
    }
}
