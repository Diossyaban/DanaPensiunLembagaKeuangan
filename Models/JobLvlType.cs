﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class JobLvlType
    {
        public int JobLvlNmbr { get; set; }
        public string JobLvlNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
