using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class RekapManfaatSiperdana
    {
        public int? Username { get; set; }
        public string NamaPerusahaan { get; set; }
        public string RegistrationNmbr { get; set; }
        public DateTime TglTransaksi { get; set; }
        public int NoPeserta { get; set; }
        public string NoPegawai { get; set; }
        public string NamaPeserta { get; set; }
        public DateTime TglLahir { get; set; }
        public double? DariIuran { get; set; }
        public double? DariHasilInvestasi { get; set; }
        public double? JumlahBayar { get; set; }
        public double? Biaya { get; set; }
        public double? Pajak { get; set; }
        public double? JumlahDibayar { get; set; }
        public double? Lumpsum { get; set; }
        public string LumpsumAcctNmbr { get; set; }
        public string LumpsumAcctNm { get; set; }
        public string LumpsumBankNm { get; set; }
        public string LumpsumBankAddr { get; set; }
        public double? Anuitas { get; set; }
        public string AnnuityAcctNmbr { get; set; }
        public string AnnuityAcctNm { get; set; }
        public string AnnuityBankNm { get; set; }
        public string AnnuityBankAddr { get; set; }
        public DateTime? LumpsumTransferDate { get; set; }
        public DateTime? AnuitasTransferDate { get; set; }
        public string JenisTransaksi { get; set; }
    }
}
