using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Beneficiary
    {
        public int ClientNmbr { get; set; }
        public int BeneNmbr { get; set; }
        public int BeneRltnNmbr { get; set; }
        public string BeneNm { get; set; }
        public DateTime? BeneDob { get; set; }
        public DateTime LastChangeDt { get; set; }
        public double? BenePercent { get; set; }
    }
}
