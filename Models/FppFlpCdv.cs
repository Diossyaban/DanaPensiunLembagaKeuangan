using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class FppFlpCdv
    {
        public int? GroupNmbr { get; set; }
        public int? CerNmbr { get; set; }
        public string Dc { get; set; }
        public string FlpNmbr { get; set; }
        public DateTime? FlpGeneratedDt { get; set; }
        public string FlpApprovalNm { get; set; }
        public string FppNmbr { get; set; }
        public DateTime? FppGeneratedDt { get; set; }
        public string FppApprovalNm { get; set; }
        public string CdvNmbr { get; set; }
        public DateTime? CvdGeneratedDt { get; set; }
        public string CdvApprovalNm { get; set; }
        public string CrvNmbr { get; set; }
        public DateTime? CrvGeneratedDt { get; set; }
        public string CrvApprovalNm { get; set; }
        public int? BillCntrbSeq { get; set; }
        public int? TrnsSeqNmbr { get; set; }
        public string JurnalCode { get; set; }
        public string JurnalNm { get; set; }
        public double? Amount { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
