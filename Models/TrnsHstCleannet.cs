using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TrnsHstCleannet
    {
        public int TrnsSeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public DateTime TrnsHstChangeDt { get; set; }
        public double GrossAmt { get; set; }
        public double NetAmt { get; set; }
        public short ReversalFlg { get; set; }
        public DateTime? ReversedDt { get; set; }
        public short ProcessedFlg { get; set; }
        public short? CompletedFlg { get; set; }
        public int? BatchId { get; set; }
        public string ProcessorId { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? CntrbSeqNmbr { get; set; }
        public double? VestedAmt { get; set; }
        public DateTime? DeletedDt { get; set; }
    }
}
