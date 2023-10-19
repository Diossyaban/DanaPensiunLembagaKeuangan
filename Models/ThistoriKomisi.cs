using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ThistoriKomisi
    {
        public int GroupNmbr { get; set; }
        public string CompanyNm { get; set; }
        public int CntrbSeqNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime CntrbEfctvDt { get; set; }
        public DateTime? PaidDt { get; set; }
        public double? Iuran { get; set; }
        public double? ChargeRt { get; set; }
        public int? TahunKe { get; set; }
        public int? CommisionType { get; set; }
        public string KdAgen { get; set; }
        public int? FlgPaid { get; set; }
        public string KodeKomisi { get; set; }
    }
}
