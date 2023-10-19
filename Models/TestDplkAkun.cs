using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TestDplkAkun
    {
        public int IdAkun { get; set; }
        public string Nama { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int? IdRole { get; set; }
    }
}
