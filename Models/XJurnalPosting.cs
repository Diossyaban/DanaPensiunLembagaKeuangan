using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class XJurnalPosting
    {
        public string TrnsId { get; set; }
        public string TrnsTypeNmbr { get; set; }
        public string GlCode { get; set; }
        public string Dc { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public double? Amount { get; set; }
        public string UserNm { get; set; }
        public DateTime? TrnsDt { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
