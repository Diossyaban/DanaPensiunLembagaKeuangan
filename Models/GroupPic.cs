using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GroupPic
    {
        public string KdPic { get; set; }
        public int GroupNmbr { get; set; }
        public string Title { get; set; }
        public string NamaPic { get; set; }
        public string Jabatan { get; set; }
        public bool? IsActive { get; set; }
    }
}
