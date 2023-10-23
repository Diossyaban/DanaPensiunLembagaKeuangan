using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPLK.Models.dto
{
    public class GetKartuIndividu
    {
        public string no_surat { get; set; }
        public string ditujukan { get; set; }
        public DateTime tgl_surat { get; set; }
        public string client_nm { get; set; }


        [Key]
        public int cer_nmbr { get; set; }
    }
}
