using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIuranInvestVw
    {
        public int CerNmbr { get; set; }
        public DateTime PeriodeIuran { get; set; }
        public DateTime? TglTerimaDana { get; set; }
        public DateTime? TanggalAlokasi { get; set; }
        public DateTime TanggalProcess { get; set; }
        public string DeskripsiBankTransfer { get; set; }
        public decimal? JumlahDana { get; set; }
        public string AsalDanaDari { get; set; }
        public DateTime Proses { get; set; }
    }
}
