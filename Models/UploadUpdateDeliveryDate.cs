using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadUpdateDeliveryDate
    {
        public int GroupNmbr { get; set; }
        public int CerNmbr { get; set; }
        public DateTime KitDeliveryDt { get; set; }
        public string Hostname { get; set; }
        public string Pic { get; set; }
    }
}
