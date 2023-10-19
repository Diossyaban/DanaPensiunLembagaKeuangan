using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ClientPhone
    {
        public int PhoneTypeNmbr { get; set; }
        public int ClientNmbr { get; set; }
        public short IndGrpCd { get; set; }
        public string PhoneNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual PhoneType PhoneTypeNmbrNavigation { get; set; }
    }
}
