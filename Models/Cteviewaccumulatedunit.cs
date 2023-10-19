using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Cteviewaccumulatedunit
    {
        public int TrnsSeqNmbr { get; set; }
        public int CerNmbr { get; set; }
        public DateTime TrnsHstEfctvDt { get; set; }
        public int MoneyTypeNmbr { get; set; }
        public short InvTypeNmbr { get; set; }
        public string InvTypeNm { get; set; }
        public int TrnsTypeNmbr { get; set; }
        public int SubTrnsNmbr { get; set; }
        public bool? DebetPost { get; set; }
        public bool? CreditPost { get; set; }
        public double UnitCnt { get; set; }
        public double GrossAmt { get; set; }
        public double NetAmt { get; set; }
        public long? Rownum { get; set; }
        public double? Sumunit { get; set; }
    }
}
