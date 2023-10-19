using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SunMap
    {
        public int SeqNmbr { get; set; }
        public string ProductType { get; set; }
        public string SuspTypeNm { get; set; }
        public string PayStsNm { get; set; }
        public string InvTypeAcrNm { get; set; }
        public string ProdAliasNm { get; set; }
        public string InvAliasNm { get; set; }
        public string AccNmbr { get; set; }
        public string DcActyNm { get; set; }
        public string ActyNmbr { get; set; }
        public string DcInterNm { get; set; }
        public string InterNmbr { get; set; }
        public int? TrnsTypeNmbr { get; set; }
    }
}
