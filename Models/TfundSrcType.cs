﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TfundSrcType
    {
        public int? FundSrcNmbr { get; set; }
        public string FundSrcNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
