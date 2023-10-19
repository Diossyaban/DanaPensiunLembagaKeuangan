using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DPLK.Models
{
    public partial class Company
    {
        public Company()
        {
            Paycenters = new HashSet<Paycenter>();
        }

        public int ClientNmbr { get; set; }

        public string CompanyNm { get; set; }

        public short HasPaycenter { get; set; }

        public string Npwp { get; set; }

        public int BusinessLineNmbr { get; set; }

        public string ContactPerson { get; set; }

        public DateTime LastChangeDt { get; set; }

        public string Siup { get; set; }

        public short? MnySrcType { get; set; }

        public string PayorNm { get; set; }

        public string BankNm { get; set; }

        public string AccountNmbr { get; set; }

        public string AccountNm { get; set; }

        public string Email { get; set; }

        public string AdArt { get; set; }

        public bool? PdpFlg { get; set; }

        public string OldClientNmbr { get; set; }


        public virtual ICollection<Paycenter> Paycenters { get; set; }
        public virtual ICollection<BusinessSctr> BusinessSctrNm { get; set; }
        public virtual ICollection<MoneyType> MnySrcNm { get; set; }
    }
}
