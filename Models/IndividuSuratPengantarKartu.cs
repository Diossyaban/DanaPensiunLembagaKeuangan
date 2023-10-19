using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public class IndividuSuratPengantarKartu
    {
        public string NoSurat { get; set; }
        public string Ditujukan { get; set; }
        public DateTime TanggalSurat { get; set; }
        public string CompanyName { get; set; }
        public int GroupNumber { get; set; }
    }

}
