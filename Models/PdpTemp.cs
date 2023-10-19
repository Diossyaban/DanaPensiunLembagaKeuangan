using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PdpTemp
    {
        public string NamaPerusahaan { get; set; }
        public string AlamatPerusahaan { get; set; }
        public string NamaPeserta { get; set; }
        public string NoPeserta { get; set; }
        public double? NoKtp { get; set; }
        public string NamaIbuKandung { get; set; }
        public string TempatLahir { get; set; }
        public double? TanggalLahir { get; set; }
        public double? BulanLahir { get; set; }
        public double? TahunLahir { get; set; }
        public string AlamatKtp { get; set; }
        public string KodePosKtp { get; set; }
        public string Email { get; set; }
        public string AlamatRumah { get; set; }
        public string KodePos { get; set; }
        public string TelpRumah { get; set; }
        public string Hp { get; set; }
        public string StatusNikah { get; set; }
        public string StatusBlmNikah { get; set; }
        public string StatusJandaDuda { get; set; }
        public string JumlahAnak { get; set; }
        public double? UsiaPensiunNormal { get; set; }
        public string DanaPensiunAwal { get; set; }
        public string NoPesertaDpAwal { get; set; }
    }
}
