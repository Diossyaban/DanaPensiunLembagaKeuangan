using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models
{
    [Keyless]
    public class PayCenterIndex
    {
        public int ClientNmbr { get; set; }

        public int PaycenterNmbr { get; set; }

        public string PaycenterNm { get; set; }

        public int? MasterPaycenterNmbr { get; set; }

        public string ContactPerson { get; set; }

        public DateTime LastChangeDt { get; set; }
    }
}
