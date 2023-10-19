using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class FundMvntEst
    {
        public int CerNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public int InvTypeSrc { get; set; }
        public int InvTypeDst { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public double? GrossAmt { get; set; }
        public short? ApproveFlg { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public DateTime? DocRecvDt { get; set; }
        public DateTime? ProcessedDt { get; set; }
        public string ProcessedBy { get; set; }
        public int? BatchId { get; set; }
    }
}
