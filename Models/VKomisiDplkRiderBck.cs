using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class VKomisiDplkRiderBck
    {
        public int KdPerusahaan { get; set; }
        public string NamaPerusahaan { get; set; }
        public int KodePeserta { get; set; }
        public string NamaPeserta { get; set; }
        public DateTime? TanggalValuasi { get; set; }
        public string NomorFlp { get; set; }
        public string NomorCrv { get; set; }
        public double? JumlahValuasi { get; set; }
        public string JenisKomisi { get; set; }
        public string JenisPremi { get; set; }
        public string JenisRider { get; set; }
        public string SalesName { get; set; }
        public DateTime TglEntry { get; set; }
        public string TahunKomisi { get; set; }
        public int? PersenKomisi { get; set; }
        public double? Iuran { get; set; }
        public short? FlagKomisi { get; set; }
        public double? DanaAwal { get; set; }
        public double? AdminFee { get; set; }
    }
}
