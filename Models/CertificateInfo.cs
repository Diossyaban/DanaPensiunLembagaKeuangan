using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DPLK.Models
{
    [Keyless]
    public class CertificateInfo
    {
        public int CertificateNumber { get; set; }
        public string OldCertificateNumber { get; set; }
        public int ClientNumber { get; set; }
        public int GroupNumber { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public int RetirementAge { get; set; }
        public int? PaycenterNumber { get; set; }
        public int PaymentTypeNumber { get; set; }
        public int? CitizenshipCode { get; set; }
        public string TaxIdNumber { get; set; }
        public int? JobVacationNumber { get; set; }
        public int? FundSourceNumber { get; set; }
        public DateTime? ApplicationReceiveDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? KitDeliveryDate { get; set; }
        public bool FirstPremiumFlag { get; set; }
        public bool OtherDPPKFlag { get; set; }
        public float SumInsured { get; set; }
        public DateTime? SumInsuredEffectiveDate { get; set; }
        public float SalaryAmount { get; set; }
        public DateTime? SalaryEffectiveDate { get; set; }
        public DateTime? StatusEffectiveDate { get; set; }
        public string StatusTypeName { get; set; }
        public string Branch { get; set; }
        public string SalesName { get; set; }
        public int? PremiumTypeNumber { get; set; }
        public int? RiderTypeNumber { get; set; }
        public int AgentNumber { get; set; }
        public int? CommissionTypeNumber { get; set; }
        public int? PlanTypeNumber { get; set; }
        public bool ApuPpt { get; set; }
    }

}
