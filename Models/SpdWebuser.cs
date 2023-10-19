using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class SpdWebuser
    {
        public string RefCode { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? UserLevel { get; set; }
        public DateTime? FirstLogin { get; set; }
        public int Counter { get; set; }
        public string SessionId { get; set; }
        public int WrongPass { get; set; }
        public bool IsLocked { get; set; }
        public byte Multiplicator { get; set; }
        public DateTime? VfirstLogin { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Rbdcode { get; set; }
    }
}
