using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class UploadNewParticipant
    {
        public int? GroupNumber { get; set; }
        public string Gender { get; set; }
        public string Nip { get; set; }
        public string ClientName { get; set; }
        public string MaidenName { get; set; }
        public DateTime? Dob { get; set; }
        public string DobLocation { get; set; }
        public DateTime? CoverageDate { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public int? EmploymentLevel { get; set; }
        public int? RetirementAge { get; set; }
        public int? IdentityType { get; set; }
        public string IdentityNumber { get; set; }
        public int? MaritalStatus { get; set; }
        public string TaxIdNumber { get; set; }
        public int? Citizenship { get; set; }
        public DateTime? ApplicationReceivedDate { get; set; }
        public int? CompletedFlag { get; set; }
        public int? JobType { get; set; }
        public int? FundSource { get; set; }
        public int? AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public int? Province { get; set; }
        public string PostalCode { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string OfficePhone { get; set; }
        public int? Paycenter { get; set; }
        public double? SalaryAmount { get; set; }
        public int? BeneTypeNmbr { get; set; }
        public double? SumInsured { get; set; }
        public string BeneficiaryName1 { get; set; }
        public DateTime? BeneficiaryDob1 { get; set; }
        public int? BeneficiaryRelation1 { get; set; }
        public string BeneficiaryName2 { get; set; }
        public DateTime? BeneficiaryDob2 { get; set; }
        public int? BeneficiaryRelation2 { get; set; }
        public string BeneficiaryName3 { get; set; }
        public DateTime? BeneficiaryDob3 { get; set; }
        public int? BeneficiaryRelation3 { get; set; }
        public string BeneficiaryName4 { get; set; }
        public DateTime? BeneficiaryDob4 { get; set; }
        public int? BeneficiaryRelation4 { get; set; }
        public string BeneficiaryName5 { get; set; }
        public DateTime? BeneficiaryDob5 { get; set; }
        public int? BeneficiaryRelation5 { get; set; }
        public double? ContributionRateEr { get; set; }
        public double? ContributionAmountEr { get; set; }
        public double? ContributionRateMbr { get; set; }
        public double? ContributionAmountMbr { get; set; }
        public double? ContributionRateTu { get; set; }
        public double? ContributionAmountTu { get; set; }
        public double? ContributionRateFt { get; set; }
        public double? ContributionAmountFt { get; set; }
        public int? InvestmentType1 { get; set; }
        public double? InvestmentRate1 { get; set; }
        public int? InvestmentType2 { get; set; }
        public double? InvestmentRate2 { get; set; }
        public int? InvestmentType3 { get; set; }
        public double? InvestmentRate3 { get; set; }
        public int? InvestmentType4 { get; set; }
        public double? InvestmentRate4 { get; set; }
        public int? InvestmentType5 { get; set; }
        public double? InvestmentRate5 { get; set; }
        public string Hostname { get; set; }
        public string OldCerNmbr { get; set; }
        public string Branch { get; set; }
        public string SalesName { get; set; }
        public string Mail { get; set; }
    }
}
