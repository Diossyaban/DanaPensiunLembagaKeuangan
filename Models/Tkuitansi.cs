using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tkuitansi
    {
        public string IdKuitansi { get; set; }
        public string NoKontrak { get; set; }
        public string KodePerusahaan { get; set; }
        public string KodePeserta { get; set; }
        public string Alamat { get; set; }
        public string PenjelasanKuitansi { get; set; }
        public string AnKuitansi { get; set; }
        public string UpKuitansi { get; set; }
        public DateTime? TglKuitansi { get; set; }
        public decimal TotalKuitansi { get; set; }
        public string NamaPenandatangan { get; set; }
        public DateTime DtEtr { get; set; }
        public string UserEtr { get; set; }
        public string HostEtr { get; set; }
        public DateTime? DtUpd { get; set; }
        public string UserUpd { get; set; }
        public string HostUpd { get; set; }
    }
}
