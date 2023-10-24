using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VGlReport
    {
        public string TrnsId { get; set; }
        public string Inv { get; set; }
        public string InvTypeNm { get; set; }
        public DateTime TrnsDate { get; set; }
        public string Slcode { get; set; }
        public string Company { get; set; }
        public string GlCode { get; set; }
        public string Descr { get; set; }
        public string Type { get; set; }
        public string Keterangan { get; set; }
        public string Ccy { get; set; }
        public double? Debet { get; set; }
        public double? Credit { get; set; }
        public double? Debet2 { get; set; }
        public double? Credit2 { get; set; }
    }
}
