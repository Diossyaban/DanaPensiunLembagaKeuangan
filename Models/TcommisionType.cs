﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcommisionType
    {
        public short CommisionTypeNmbr { get; set; }
        public string CommisionTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
