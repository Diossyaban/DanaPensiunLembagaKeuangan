using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PengantarKartu
    {
        public string NoSurat { get; set; }
        public string CerNmbr { get; set; }
        public DateTime TglSurat { get; set; }
        public string AlamatKirim { get; set; }
    }
}
