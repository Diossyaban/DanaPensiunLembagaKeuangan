using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UsrLst
    {
        public short ProdTypeNum { get; set; }
        public short JobFcnNum { get; set; }
        public string UsrId { get; set; }
        public string UsrNm { get; set; }
        public DateTime? LastChngDt { get; set; }
        public DateTime? ExpireDt { get; set; }
        public short? LockedFlg { get; set; }
    }
}
