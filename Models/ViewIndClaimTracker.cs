using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ViewIndClaimTracker
    {
        public int CerNmbr { get; set; }
        public string KodeRegistrasi { get; set; }
        public DateTime? RegisterClaim { get; set; }
        public DateTime? PersetujuanRegistrasi { get; set; }
        public DateTime? SiapDiProses { get; set; }
        public DateTime? PersetujuanTransfer { get; set; }
        public double? GrossAmt { get; set; }
        public double? NetAmt { get; set; }
        public double? FeeAmt { get; set; }
        public double? Tax { get; set; }
        public string BankLumpsum { get; set; }
        public string RekLumpsum { get; set; }
        public string RekNameLumpsum { get; set; }
        public double? LumpsumAmt { get; set; }
        public string BankAnuitas { get; set; }
        public string RekAnuitas { get; set; }
        public string RekNameAnuitas { get; set; }
        public double? AnuitasAmt { get; set; }
    }
}
