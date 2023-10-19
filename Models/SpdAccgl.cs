using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdAccgl
    {
        public int Monthperiod { get; set; }
        public int Yearperiod { get; set; }
        public string Jurnalprefix { get; set; }
        public string AppAddress { get; set; }
        public bool? AbleChangeperiod { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyNpwp { get; set; }
        public string CompanyPkpDate { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public string CompanySignName { get; set; }
        public string CompanySignTitle { get; set; }
    }
}
