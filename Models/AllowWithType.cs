using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AllowWithType
    {
        public int AllowWithNmbr { get; set; }
        public string AllowWithNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
