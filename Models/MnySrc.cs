using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class MnySrc
    {
        public short MnySrcType { get; set; }
        public string MnySrcNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChgDt { get; set; }
/*        public virtual Company Company { get; set; }
*/
    }
}
