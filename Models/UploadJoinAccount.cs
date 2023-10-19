using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadJoinAccount
    {
        public int? CerNmbrSrc { get; set; }
        public int? CerNmbrDst { get; set; }
        public string FundOption { get; set; }
        public string Hostname { get; set; }
        public string Pic { get; set; }
    }
}
