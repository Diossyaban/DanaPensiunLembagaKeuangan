using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TbeneRelationType
    {
        public int BeneRltnNmbr { get; set; }
        public string RelationNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
