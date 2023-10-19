using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TbPenampung
    {
        public string CerNmbr { get; set; }
        public string CntrbSeqNmbr { get; set; }
        public int? Bulan { get; set; }
        public string Tahun { get; set; }
    }
}
