using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VInvFlpfpp
    {
        public string Type { get; set; }
        public string Old { get; set; }
        public string Crvcdv { get; set; }
        public int? Status { get; set; }
        public string StatusDescr { get; set; }
        public DateTime? Thedate { get; set; }
        public string Descr { get; set; }
        public string CmAppr { get; set; }
        public DateTime? CmApprDate { get; set; }
        public string AccAppr { get; set; }
        public DateTime? AccApprDate { get; set; }
        public string Inv { get; set; }
        public string InvDescr { get; set; }
    }
}
