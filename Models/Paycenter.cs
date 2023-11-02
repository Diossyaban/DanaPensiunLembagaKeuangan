using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DPLK.Models
{
    public partial class Paycenter
    {
        public int ClientNmbr { get; set; }

        public int PaycenterNmbr { get; set; }

        public string PaycenterNm { get; set; }

        public int? MasterPaycenterNmbr { get; set; }

        public string ContactPerson { get; set; }

        public DateTime LastChangeDt { get; set; }

        public virtual Company ClientNmbrNavigation { get; set; }




    }
}
