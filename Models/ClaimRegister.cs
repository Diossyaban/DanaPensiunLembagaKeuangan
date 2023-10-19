using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ClaimRegister
    {
        public string CrId { get; set; }
        public DateTime CrDate { get; set; }
        public string Description { get; set; }
        public int CerNmbr { get; set; }
        public double? ClaimAmount { get; set; }
        public int SubTrnsType { get; set; }
        public int? RegisterMtdNmbr { get; set; }
    }
}
