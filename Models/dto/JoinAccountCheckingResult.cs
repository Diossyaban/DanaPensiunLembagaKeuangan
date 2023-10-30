using System;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models.dto
{
    public class JoinAccountCheckingResult
    {
        [Key]
        public int CerNmbrSrc { get; set; }
        public int CerNmbrDst { get; set; }
        public DateTime EfctvDt { get; set; }
        public int TrnsType { get; set; }
        public int? GroupNmbr { get; set; }
    }

}
