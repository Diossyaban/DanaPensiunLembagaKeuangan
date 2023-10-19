using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SuratPengalihan
    {
        public string NoSurat { get; set; }
        public string PicGroup { get; set; }
        public int? GroupNmbr { get; set; }
        public string Alamat { get; set; }
        public DateTime LogDate { get; set; }
    }
}
