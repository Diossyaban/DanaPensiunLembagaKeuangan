using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class BusinessLine
    {
        public int BusinessLineNmbr { get; set; }
        public string BusinessLineNm { get; set; }
        public short BusinessSctrNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual BusinessSctr BusinessSctrNmbrNavigation { get; set; }
    }
}
