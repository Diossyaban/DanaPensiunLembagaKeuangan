using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TNotaDetail
    {
        public string NoNota { get; set; }
        public int? NoNotaDetail { get; set; }
        public string Keterangan { get; set; }
        public int? JmlKaryawanEnd { get; set; }
        public int? TambahanKaryawan { get; set; }
        public int? PenguranganKaryawan { get; set; }
        public int? JmlKaryawan { get; set; }
        public decimal? Jml { get; set; }
    }
}
