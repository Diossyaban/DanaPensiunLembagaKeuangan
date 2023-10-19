using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TwdDocType
    {
        public int WdDocNmbr { get; set; }
        public string WdDocNm { get; set; }
        public string AcronymNm { get; set; }
        public DateTime LastChangeDt { get; set; }
        public string Status { get; set; }
    }
}
