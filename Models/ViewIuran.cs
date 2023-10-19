using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIuran
    {
        public string PeriodeIuran { get; set; }
        public string TglTerimaDana { get; set; }
        public string TanggalAlokasi { get; set; }
        public string TanggalProcess { get; set; }
        public string DeskripsiBankTransfer { get; set; }
        public string JumlahDana { get; set; }
        public string AsalDanaDari { get; set; }
        public string Proses { get; set; }
    }
}
