using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public class UnitPriceIndex
    {
        public DateTime EfctvDt { get; set; }
        public string InvTypeNm { get; set; }
        public float Nab { get; set; }
        public float Unit { get; set; }
        public float UnitSuspense { get; set; }
        public string ApprovalFlg { get; set; }
        public float Price { get; set; }
        public long Idx { get; set; }
        public int InvTypeNmbr { get; set; }
    }

}
