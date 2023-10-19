using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BillingStatus
    {
        public int GroupNmbr { get; set; }
        public DateTime? NextBillPrd { get; set; }
        public DateTime? NextBillDt { get; set; }
        public int? BillFreqNmbr { get; set; }
        public DateTime? NextCntrbPrd { get; set; }
        public DateTime? NextCntrbDt { get; set; }
        public int? CntrbFreqNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public int? PslFreqNmbr { get; set; }
        public DateTime? NextPslPrd { get; set; }
        public DateTime? NextPslDt { get; set; }
        public short? PslFreqcy { get; set; }
        public short? AutoPrintFlg { get; set; }
        public short? MateraiFlg { get; set; }
        public DateTime? NextPrintDt { get; set; }

        public virtual GroupInfo GroupNmbrNavigation { get; set; }
    }
}
