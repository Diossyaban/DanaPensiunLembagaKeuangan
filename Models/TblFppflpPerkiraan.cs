using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TblFppflpPerkiraan
    {
        public string TrnsId { get; set; }
        public string Inv { get; set; }
        public string Slcode { get; set; }
        public string Grp { get; set; }
        public string CompanyNm { get; set; }
        public string GlCode { get; set; }
        public string Descr { get; set; }
        public string Type { get; set; }
        public string Keterangan { get; set; }
        public string Ccy { get; set; }
        public string Debet { get; set; }
        public string Credit { get; set; }
        public double? Amont { get; set; }
        public string TransDate { get; set; }
        public int? TransTypeNmbr { get; set; }
        public int? SubTrns { get; set; }
        public string Dc { get; set; }
        public string Fund { get; set; }
        public string ModeTrans { get; set; }
        public int? SeqNmbr { get; set; }
        public string Refcode { get; set; }
        public string UserNm { get; set; }
        public DateTime? GeneratedDt { get; set; }
        public DateTime? ApprovalDt { get; set; }
        public string ApprovalNm { get; set; }
    }
}
