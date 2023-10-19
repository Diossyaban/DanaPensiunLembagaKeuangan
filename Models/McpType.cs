using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class McpType
    {
        public int McpNmbr { get; set; }
        public string McpNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
