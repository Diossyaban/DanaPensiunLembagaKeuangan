using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

#nullable disable

namespace DPLK.Models
{
    public partial class SuspenseHst
    {
        [Key]
        public long SuspnNmbr { get; set; }
        public int? GroupNmbr { get; set; }
        public int? PaycenterNmbr { get; set; }
        public DateTime? CreateDt { get; set; }
        public double? SuspnAmt { get; set; }
        public double? SuspnUseAmt { get; set; }
        public short? FinApproveCd { get; set; }
        public short? AdmApproveCd { get; set; }
        public string SuspnDesc1 { get; set; }
        public string SuspnDesc2 { get; set; }
        public string Remark { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public int? SuspnTypeNmbr { get; set; }
        public DateTime? ReceivedDt { get; set; }
        public int? UseStatusCd { get; set; }
        public short? WaivedFlg { get; set; }
        public short? RcptvoucherFlg { get; set; }
        public string RefBank { get; set; }
        public virtual Company Company { get; set; }
        public virtual GroupInfo Group { get; set; }
        public virtual Paycenter Paycenter { get; set; }
    }
}
