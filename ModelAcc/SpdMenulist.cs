using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class SpdMenulist
    {
        public string MenuId { get; set; }
        public string MenuName { get; set; }
        public string Application { get; set; }
        public string ParentId { get; set; }
        public string Link { get; set; }
        public string RootId { get; set; }
        public int? Lvl { get; set; }
    }
}
