﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TproductType
    {
        public int ProductTypeNmbr { get; set; }
        public string ProductTypeNm { get; set; }
        public string PrdAcronym { get; set; }
        public short? MinIssueAge { get; set; }
        public short? MaxIssueAge { get; set; }
        public string Status { get; set; }
    }
}
