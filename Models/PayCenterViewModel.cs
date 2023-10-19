using Microsoft.EntityFrameworkCore;
using System;

namespace DPLK.Models
{
    [Keyless]
    public partial class PayCenterViewModel
    {

        public int ClientNmbr { get; set; }

        public int PaycenterNmbr { get; set; }

        public string PaycenterNm { get; set; }

        public int? MasterPaycenterNmbr { get; set; }

        public string ContactPerson { get; set; }

        public DateTime LastChangeDt { get; set; }

        public virtual Company ClientNmbrNavigation { get; set; }

        public virtual Company CompanyNm { get; set; }




    }
}
