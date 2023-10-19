using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ExchgRate
    {
        public short InvTypeNmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public double BuyRt { get; set; }
        public double SellRt { get; set; }
        public short? ApprovalFlg { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual InvType InvTypeNmbrNavigation { get; set; }
    }
}
