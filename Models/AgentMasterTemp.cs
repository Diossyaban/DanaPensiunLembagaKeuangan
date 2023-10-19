using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class AgentMasterTemp
    {
        public int AgentNmbr { get; set; }
        public string AgentNm { get; set; }
        public string EmployeeCode { get; set; }
        public DateTime? BirthDt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCd { get; set; }
        public string PhoneNmbr { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string AcctNmbr { get; set; }
        public string AcctNm { get; set; }
        public string BankNm { get; set; }
        public string BankAddress { get; set; }
        public string AgentStatus { get; set; }
        public string TaxIdNmbr { get; set; }
        public string AgentType { get; set; }
        public string OldAgentNmbr { get; set; }
    }
}
