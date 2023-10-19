using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ProductSetup
    {
        public short ProductTypeNmbr { get; set; }
        public short SetupTypeNmbr { get; set; }
        public string SetupTypeNm { get; set; }
        public string DefltValue { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
