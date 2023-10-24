using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdUser
    {
        public string Userid { get; set; }
        public string Username { get; set; }
        public bool Active { get; set; }
        public int? GroupId { get; set; }
        public string Password { get; set; }
        public bool? Logged { get; set; }
        public DateTime? Lastlogin { get; set; }
        public DateTime? Lastactivity { get; set; }
    }
}
