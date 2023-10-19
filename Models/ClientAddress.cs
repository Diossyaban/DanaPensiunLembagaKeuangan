using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class ClientAddress
    {
        public int AddrTypeNmbr { get; set; }
        public int ClientNmbr { get; set; }
        public short IndGrpCd { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public short? ProvinceNmbr { get; set; }
        public string PostalCd { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual AddressType AddrTypeNmbrNavigation { get; set; }
        public virtual Province ProvinceNmbrNavigation { get; set; }
    }
}
