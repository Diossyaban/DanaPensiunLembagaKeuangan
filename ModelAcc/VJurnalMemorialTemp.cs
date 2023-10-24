using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class VJurnalMemorialTemp
    {
        public string TrnsId { get; set; }
        public string DateJurnal { get; set; }
        public string Inv { get; set; }
        public string InvTypeNm { get; set; }
        public int? TrnsTypeNmbr { get; set; }
        public int? SubTrnsNmbr { get; set; }
        public string SubTrnsNm { get; set; }
        public int Monthperiod { get; set; }
        public int Yearperiod { get; set; }
        public bool? Correction { get; set; }
    }
}
