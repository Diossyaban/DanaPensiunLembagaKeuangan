using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdBankMaster
    {
        public string Code { get; set; }
        public string Descr { get; set; }
        public string ShortDescr { get; set; }
        public string Branch { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Zipcode { get; set; }
        public string Pic { get; set; }
        public string Company { get; set; }
        public string Account { get; set; }
        public string Currency { get; set; }
        public double Startbalance { get; set; }
        public string Createby { get; set; }
        public DateTime? Createdate { get; set; }
        public string Lastchangeby { get; set; }
        public DateTime? Lastchangedate { get; set; }
        public string Fund { get; set; }
        public int? Status { get; set; }
    }
}
