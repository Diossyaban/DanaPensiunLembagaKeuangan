﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TcoiType
    {
        public int? CoiTypeNmbr { get; set; }
        public string CoiTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
