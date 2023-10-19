using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ProductCharge
    {
        public int ChargeTypeNmbr { get; set; }
        public int ChargeSeqNmbr { get; set; }
        public int ProductType { get; set; }
        public short? BegPrd { get; set; }
        public short? EndPrd { get; set; }
        public double? ChargeRt { get; set; }
        public double? ChargeAmt { get; set; }
        public short? MaxCnt { get; set; }
        public short? FreeCnt { get; set; }
        public double? BillPct { get; set; }
        public double? DeductPct { get; set; }
        public int PayRspnNmbr { get; set; }
        public int FreqTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
