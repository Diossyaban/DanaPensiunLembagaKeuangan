using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class TmpCertificate
    {
        public int CerNmbr { get; set; }
        public int GroupNmbr { get; set; }
        public int ClientNmbr { get; set; }
        public string OldCerNmbr { get; set; }
        public string EmployeeNmbr { get; set; }
        public string Employee2Nmbr { get; set; }
        public DateTime EfctvDt { get; set; }
        public DateTime CreateDt { get; set; }
        public DateTime? TerminationDt { get; set; }
        public DateTime? EmploymentDt { get; set; }
        public int RetirementAge { get; set; }
        public int? PaycenterNmbr { get; set; }
        public short? PaymentTypeNmbr { get; set; }
        public DateTime LastChangeDt { get; set; }
        public short? AppStatusNmbr { get; set; }
        public DateTime? CompletionDt { get; set; }
        public DateTime? AppReceiveDt { get; set; }
        public short? CitizenshipCd { get; set; }
        public string TaxIdNmbr { get; set; }
        public short? JobVctnNmbr { get; set; }
        public short? FundSrcNmbr { get; set; }
        public DateTime? MaturityDt { get; set; }
        public short OthDppkFlg { get; set; }
        public DateTime? PinPrintDt { get; set; }
        public int? CerNmbrOpf { get; set; }
        public DateTime? KitDeliveryDt { get; set; }
        public bool? FirstPremiumFlg { get; set; }
        public string Branch { get; set; }
    }
}
