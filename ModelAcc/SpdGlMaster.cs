﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdGlMaster
    {
        public string Code { get; set; }
        public string Descr { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }
        public string Parentcode { get; set; }
        public string Cash { get; set; }
    }
}