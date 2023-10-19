using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Province
    {
        public Province()
        {
            ClientAddresses = new HashSet<ClientAddress>();
        }

        public short ProvinceNmbr { get; set; }
        public string ProvinceNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<ClientAddress> ClientAddresses { get; set; }
    }
}
