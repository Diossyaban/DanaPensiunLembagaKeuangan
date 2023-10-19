using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Pic
    {
        public int PicId { get; set; }
        public string PicName { get; set; }
        public string PicSignature { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime? LastChangeDt { get; set; }
    }
}
