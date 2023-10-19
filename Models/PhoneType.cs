using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            ClientPhones = new HashSet<ClientPhone>();
        }

        public int PhoneTypeNmbr { get; set; }
        public string PhoneTypeNm { get; set; }
        public string OldTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }

        public virtual ICollection<ClientPhone> ClientPhones { get; set; }
    }
}
