using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Tempunitprice
    {
        public DateTime EfctvDt { get; set; }
        public short InvTypeNmbr { get; set; }
        public double Price { get; set; }
        public short? ApprovalFlg { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
