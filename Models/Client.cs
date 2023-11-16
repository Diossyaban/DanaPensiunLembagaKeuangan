using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Client
    {
        public int ClientNmbr { get; set; }
        public string ClientNm { get; set; }
        public short? IdentityType { get; set; }
        public string IdentityNmbr { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDt { get; set; }
        public short? MaritalStatusNmbr { get; set; }
        public string MaidenNm { get; set; }
        public string EmailAddr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string DobPlace { get; set; }
        public int? ClientNmbrOpf { get; set; }
        public string Path { get; set; }
   }
}
