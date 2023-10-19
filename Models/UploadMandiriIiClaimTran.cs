using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadMandiriIiClaimTran
    {
        public int? GroupNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public DateTime? Dob { get; set; }
        public string KodeBankLumpsum { get; set; }
        public string NoRekLumpsum { get; set; }
        public string NamaBankLumpsum { get; set; }
        public string NamaCabangLumpsum { get; set; }
        public string AtasNamaLumpsum { get; set; }
        public string KodeBankAnuitas { get; set; }
        public string NoRekAnuitas { get; set; }
        public string NamaBankAnuitas { get; set; }
        public string NamaCabangAnuitas { get; set; }
        public string AtasNamaAnuitas { get; set; }
        public double? AnnuityPct { get; set; }
        public string Hostname { get; set; }
        public string Pic { get; set; }
    }
}
