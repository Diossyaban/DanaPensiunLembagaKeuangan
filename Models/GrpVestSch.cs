using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class GrpVestSch
    {
        public GrpVestSch()
        {
            GrpVestDtls = new HashSet<GrpVestDtl>();
        }

        public int GrpSeqNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public DateTime? EfctvDt { get; set; }
        public int VestSchNmbr { get; set; }
        public string VestSchDesc { get; set; }
        public DateTime? LastChangeDt { get; set; }

        public virtual GroupInfo GroupNmbrNavigation { get; set; }
        public virtual ICollection<GrpVestDtl> GrpVestDtls { get; set; }
    }
}
