using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using DPLK.Models.dto;

#nullable disable

namespace DPLK.Models.context
{
    public partial class PensionContext : DbContext
    {
        public PensionContext()
        {
        }

        public PensionContext(DbContextOptions<PensionContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<CompanyOnScrPaycenterModel> CompanyOnScrPaycenterModels { get; set; }  //Ini SP
        //baru 
        public DbSet<AccountListingModel> AccountListingModels { get; set; }
        public virtual DbSet<JoinAccountCheckingResult> JoinAccountCheckingResults { get; set; }


        public virtual DbSet<GetKartuIndividu> GetKartuIndividus { get; set; }

        public virtual DbSet<GroupBenefit> GroupBenefits { get; set; }

        public virtual DbSet<UnitPriceIndex> UnitPriceIndexs { get; set; }
        public virtual DbSet<CertificateInfo> CertificateInfos { get; set; }

        public virtual DbSet<PayCenterIndex> PayCenterIndexs { get; set; }

        public virtual DbSet<AgentCommison> AgentCommisions { get; set; }

        public virtual DbSet<AdminSuspense> AdminSuspenses { get; set; }

        public virtual DbSet<PaymentForApproval> PaymentForApprovals { get; set; }
        public virtual DbSet<SuspenseRecord> SuspenseRecords { get; set; }

        public virtual DbSet<AccType> AccTypes { get; set; }
        public virtual DbSet<Accumulatedunitvico> Accumulatedunitvicos { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<AgentCommMethod> AgentCommMethods { get; set; }
        public virtual DbSet<AgentMaster> AgentMasters { get; set; }
        public virtual DbSet<AgentMasterTemp> AgentMasterTemps { get; set; }
        public virtual DbSet<AllowWithType> AllowWithTypes { get; set; }
        public virtual DbSet<AppHst> AppHsts { get; set; }
        public virtual DbSet<AppStatusType> AppStatusTypes { get; set; }
        public virtual DbSet<ApprovalLayerType> ApprovalLayerTypes { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<AssetsDetail> AssetsDetails { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<BankType> BankTypes { get; set; }
        public virtual DbSet<Benchmark> Benchmarks { get; set; }
        public virtual DbSet<BeneRelationType> BeneRelationTypes { get; set; }
        public virtual DbSet<BeneType> BeneTypes { get; set; }
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<BillingStatus> BillingStatuses { get; set; }
        public virtual DbSet<BoInvRate> BoInvRates { get; set; }
        public virtual DbSet<BoInvType> BoInvTypes { get; set; }
        public virtual DbSet<BranchOffice> BranchOffices { get; set; }
        public virtual DbSet<BuktiTrfDb> BuktiTrfDbs { get; set; }
        public virtual DbSet<BusinessLine> BusinessLines { get; set; }
        public virtual DbSet<BusinessSctr> BusinessSctrs { get; set; }
        public virtual DbSet<CerAccumulator> CerAccumulators { get; set; }
        public virtual DbSet<CerAccumulatorTemp> CerAccumulatorTemps { get; set; }
        public virtual DbSet<CerCharge> CerCharges { get; set; }
        public virtual DbSet<CerCntrb> CerCntrbs { get; set; }
        public virtual DbSet<CerInv> CerInvs { get; set; }
        public virtual DbSet<CerInvDrct> CerInvDrcts { get; set; }
        public virtual DbSet<CerInvDrctSwitch> CerInvDrctSwitches { get; set; }
        public virtual DbSet<CerInvDrctTemp> CerInvDrctTemps { get; set; }
        public virtual DbSet<CerInvDrctTmp> CerInvDrctTmps { get; set; }
        public virtual DbSet<CerMovement> CerMovements { get; set; }
        public virtual DbSet<CerMovementSwitch> CerMovementSwitches { get; set; }
        public virtual DbSet<CerStatus> CerStatuses { get; set; }
        public virtual DbSet<CerTrnsCnt> CerTrnsCnts { get; set; }
        public virtual DbSet<CerWargiani> CerWargianis { get; set; }
        public virtual DbSet<Certificate> Certificates { get; set; }
        public virtual DbSet<ChargeType> ChargeTypes { get; set; }
        public virtual DbSet<Citizenship> Citizenships { get; set; }
        public virtual DbSet<ClaimRegister> ClaimRegisters { get; set; }
        public virtual DbSet<ClaimRegisterDoc> ClaimRegisterDocs { get; set; }
        public virtual DbSet<ClaimRegisterFlagRemunerasi> ClaimRegisterFlagRemunerasis { get; set; }
        public virtual DbSet<ClaimRegisterTrack> ClaimRegisterTracks { get; set; }
        public virtual DbSet<ClaimRegistrationTemp> ClaimRegistrationTemps { get; set; }
        public virtual DbSet<ClaimRequest> ClaimRequests { get; set; }
        public virtual DbSet<ClaimTrackType> ClaimTrackTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientAddress> ClientAddresses { get; set; }
        public virtual DbSet<ClientPhone> ClientPhones { get; set; }
        public virtual DbSet<CoiType> CoiTypes { get; set; }
        public virtual DbSet<CoiTypeRate> CoiTypeRates { get; set; }
        public virtual DbSet<CommRltnType> CommRltnTypes { get; set; }
        public virtual DbSet<CommTitleType> CommTitleTypes { get; set; }
        public virtual DbSet<CommisionType> CommisionTypes { get; set; }
        public virtual DbSet<CommissionType> CommissionTypes { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ContribDetail> ContribDetails { get; set; }
        public virtual DbSet<ContribDetailGroup> ContribDetailGroups { get; set; }
        public virtual DbSet<ContribDetailTemp> ContribDetailTemps { get; set; }
        public virtual DbSet<ContribReq> ContribReqs { get; set; }
        public virtual DbSet<CopyOfCycleCertificateCharge> CopyOfCycleCertificateCharges { get; set; }
        public virtual DbSet<CopyofSpdIuranInvestasiByperson> CopyofSpdIuranInvestasiBypeople { get; set; }
        public virtual DbSet<CopyofTrnsHst> CopyofTrnsHsts { get; set; }
        public virtual DbSet<CopyofTrnsHstInv> CopyofTrnsHstInvs { get; set; }
        public virtual DbSet<Counter> Counters { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<CreditCardType> CreditCardTypes { get; set; }
        public virtual DbSet<Cteviewaccumulatedunit> Cteviewaccumulatedunits { get; set; }
        public virtual DbSet<CurrencyType> CurrencyTypes { get; set; }
        public virtual DbSet<Cycle> Cycles { get; set; }
        public virtual DbSet<CycleCertificateCharge> CycleCertificateCharges { get; set; }
        public virtual DbSet<CycleCertificateChargeAdjustment> CycleCertificateChargeAdjustments { get; set; }
        public virtual DbSet<CycleCertificateCoi> CycleCertificateCois { get; set; }
        public virtual DbSet<CycleProcess> CycleProcesses { get; set; }
        public virtual DbSet<DataPesertum> DataPeserta { get; set; }
        public virtual DbSet<DatapesertaTemp> DatapesertaTemps { get; set; }
        public virtual DbSet<DbBank> DbBanks { get; set; }
        public virtual DbSet<Delete20220307Mutasi100> Delete20220307Mutasi100s { get; set; }
        public virtual DbSet<Delete20220307Mutasi400> Delete20220307Mutasi400s { get; set; }
        public virtual DbSet<DocType> DocTypes { get; set; }
        public virtual DbSet<Double2026670> Double2026670s { get; set; }
        public virtual DbSet<DplkRollover> DplkRollovers { get; set; }
        public virtual DbSet<Dtproperty> Dtproperties { get; set; }
        public virtual DbSet<Exception> Exceptions { get; set; }
        public virtual DbSet<ExceptionType> ExceptionTypes { get; set; }
        public virtual DbSet<ExchgRate> ExchgRates { get; set; }
        public virtual DbSet<FppFlpCdv> FppFlpCdvs { get; set; }
        public virtual DbSet<FrequencyType> FrequencyTypes { get; set; }
        public virtual DbSet<FundMvntComp> FundMvntComps { get; set; }
        public virtual DbSet<FundMvntEst> FundMvntEsts { get; set; }
        public virtual DbSet<FundMvntEstTmp> FundMvntEstTmps { get; set; }
        public virtual DbSet<FundSrcType> FundSrcTypes { get; set; }
        public virtual DbSet<GroupBeneSetup> GroupBeneSetups { get; set; }
        public virtual DbSet<GroupCharge> GroupCharges { get; set; }
        public virtual DbSet<GroupCommissionFlg> GroupCommissionFlgs { get; set; }
        public virtual DbSet<GroupInfo> GroupInfos { get; set; }
        public virtual DbSet<GroupPic> GroupPics { get; set; }
        public virtual DbSet<GroupTax> GroupTaxes { get; set; }
        public virtual DbSet<GrpChargeInvRt> GrpChargeInvRts { get; set; }
        public virtual DbSet<GrpChargeRt> GrpChargeRts { get; set; }
        public virtual DbSet<GrpInvDrct> GrpInvDrcts { get; set; }
        public virtual DbSet<GrpVestDtl> GrpVestDtls { get; set; }
        public virtual DbSet<GrpVestSch> GrpVestSches { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<HtrnsHst> HtrnsHsts { get; set; }
        public virtual DbSet<IchaPetrochina> IchaPetrochinas { get; set; }
        public virtual DbSet<IdType> IdTypes { get; set; }
        public virtual DbSet<IkptHist> IkptHists { get; set; }
        public virtual DbSet<IndeksPrice> IndeksPrices { get; set; }
        public virtual DbSet<IndividualCommissionFlg> IndividualCommissionFlgs { get; set; }
        public virtual DbSet<InfoKeuPesertum> InfoKeuPeserta { get; set; }
        public virtual DbSet<InvRedempInfo> InvRedempInfos { get; set; }
        public virtual DbSet<InvSahat> InvSahats { get; set; }
        public virtual DbSet<InvType> InvTypes { get; set; }
        public virtual DbSet<JobLvlType> JobLvlTypes { get; set; }
        public virtual DbSet<JobVctnType> JobVctnTypes { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<MailAddrType> MailAddrTypes { get; set; }
        public virtual DbSet<MaritalStatusType> MaritalStatusTypes { get; set; }
        public virtual DbSet<MaturityType> MaturityTypes { get; set; }
        public virtual DbSet<MbrClsPlan> MbrClsPlans { get; set; }
        public virtual DbSet<McpType> McpTypes { get; set; }
        public virtual DbSet<MnySrc> MnySrcs { get; set; }
        public virtual DbSet<MoneyMvntComp> MoneyMvntComps { get; set; }
        public virtual DbSet<MoneyType> MoneyTypes { get; set; }
        public virtual DbSet<MppWdMaximum> MppWdMaximums { get; set; }
        public virtual DbSet<MutasiTemp> MutasiTemps { get; set; }
        public virtual DbSet<Nab> Nabs { get; set; }
        public virtual DbSet<OptionType> OptionTypes { get; set; }
        public virtual DbSet<OverPayment> OverPayments { get; set; }
        public virtual DbSet<PayRspnType> PayRspnTypes { get; set; }
        public virtual DbSet<Paycenter> Paycenters { get; set; }

        public virtual DbSet<PaymentApprvType> PaymentApprvTypes { get; set; }
        public virtual DbSet<PaymentHst> PaymentHsts { get; set; }
        public virtual DbSet<PaymentHst20221220> PaymentHst20221220s { get; set; }
        public virtual DbSet<PaymentTrnsType> PaymentTrnsTypes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<PdpTemp> PdpTemps { get; set; }
        public virtual DbSet<PengantarKartu> PengantarKartus { get; set; }
        public virtual DbSet<PensionCert> PensionCerts { get; set; }
        public virtual DbSet<PensionInfo> PensionInfos { get; set; }
        public virtual DbSet<PercentAsset> PercentAssets { get; set; }
        public virtual DbSet<Pesertum> Peserta { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<Pic> Pics { get; set; }
        public virtual DbSet<PlanRiderType> PlanRiderTypes { get; set; }
        public virtual DbSet<PreWithdrw> PreWithdrws { get; set; }
        public virtual DbSet<PremiumMethod> PremiumMethods { get; set; }
        public virtual DbSet<PremiumType> PremiumTypes { get; set; }
        public virtual DbSet<Prewithtemp> Prewithtemps { get; set; }
        public virtual DbSet<ProductCharge> ProductCharges { get; set; }
        public virtual DbSet<ProductSetup> ProductSetups { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<PslType> PslTypes { get; set; }
        public virtual DbSet<PtcpExit> PtcpExits { get; set; }
        public virtual DbSet<RateRider> RateRiders { get; set; }
        public virtual DbSet<RateTableDetail> RateTableDetails { get; set; }
        public virtual DbSet<RateTableType> RateTableTypes { get; set; }
        public virtual DbSet<Reconciliation> Reconciliations { get; set; }
        public virtual DbSet<RegisterMtdType> RegisterMtdTypes { get; set; }
        public virtual DbSet<RekapManfaatSiperdana> RekapManfaatSiperdanas { get; set; }
        public virtual DbSet<ReturInfo> ReturInfos { get; set; }
        public virtual DbSet<RfTableExt> RfTableExts { get; set; }
        public virtual DbSet<RfTableReference> RfTableReferences { get; set; }
        public virtual DbSet<RfUrl> RfUrls { get; set; }
        public virtual DbSet<Rfparameterall> Rfparameteralls { get; set; }
        public virtual DbSet<RiderType> RiderTypes { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<SearchFormCriterion> SearchFormCriteria { get; set; }
        public virtual DbSet<SearchFormType> SearchFormTypes { get; set; }
        public virtual DbSet<SearchParameter> SearchParameters { get; set; }
        public virtual DbSet<SecType> SecTypes { get; set; }
        public virtual DbSet<SecurityType> SecurityTypes { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<Sheet2> Sheet2s { get; set; }
        public virtual DbSet<SiCalcType> SiCalcTypes { get; set; }
        public virtual DbSet<SiperdanaLogin> SiperdanaLogins { get; set; }
        public virtual DbSet<SlryHistory> SlryHistories { get; set; }
        public virtual DbSet<SpFirBck> SpFirBcks { get; set; }
        public virtual DbSet<SpdAccgl> SpdAccgls { get; set; }
        public virtual DbSet<SpdAccountingreport> SpdAccountingreports { get; set; }
        public virtual DbSet<SpdBigledger> SpdBigledgers { get; set; }
        public virtual DbSet<SpdBigledgerV> SpdBigledgerVs { get; set; }
        public virtual DbSet<SpdCash> SpdCashes { get; set; }
        public virtual DbSet<SpdCashcodeException> SpdCashcodeExceptions { get; set; }
        public virtual DbSet<SpdCertificateIuranInvestasiByperson> SpdCertificateIuranInvestasiBypeople { get; set; }
        public virtual DbSet<SpdEmailSetting> SpdEmailSettings { get; set; }
        public virtual DbSet<SpdError> SpdErrors { get; set; }
        public virtual DbSet<SpdFtp> SpdFtps { get; set; }
        public virtual DbSet<SpdGroup> SpdGroups { get; set; }
        public virtual DbSet<SpdGroupMenuaccess> SpdGroupMenuaccesses { get; set; }
        public virtual DbSet<SpdIuranInvestasiByperson> SpdIuranInvestasiBypeople { get; set; }
        public virtual DbSet<SpdIuranInvestasiBypersonTemp> SpdIuranInvestasiBypersonTemps { get; set; }
        public virtual DbSet<SpdJournalsetup> SpdJournalsetups { get; set; }
        public virtual DbSet<SpdReport> SpdReports { get; set; }
        public virtual DbSet<SpdReport1> SpdReports1 { get; set; }
        public virtual DbSet<SpdReportsParam> SpdReportsParams { get; set; }
        public virtual DbSet<SpdScreenField> SpdScreenFields { get; set; }
        public virtual DbSet<SpdScreenGeneric> SpdScreenGenerics { get; set; }
        public virtual DbSet<SpdSubledger> SpdSubledgers { get; set; }
        public virtual DbSet<SpdSubledgerV> SpdSubledgerVs { get; set; }
        public virtual DbSet<SpdSubsidiary> SpdSubsidiaries { get; set; }
        public virtual DbSet<SpdUser> SpdUsers { get; set; }
        public virtual DbSet<SpdWebuser> SpdWebusers { get; set; }
        public virtual DbSet<SporadicDetail> SporadicDetails { get; set; }
        public virtual DbSet<SporadicPmt> SporadicPmts { get; set; }
        public virtual DbSet<StatusType> StatusTypes { get; set; }
        public virtual DbSet<SumInsured> SumInsureds { get; set; }
        public virtual DbSet<SunGlType> SunGlTypes { get; set; }
        public virtual DbSet<SunMap> SunMaps { get; set; }
        public virtual DbSet<SuratPengalihan> SuratPengalihans { get; set; }
        public virtual DbSet<SuspenseHst> SuspenseHsts { get; set; }
        public virtual DbSet<SuspenseHst20221220> SuspenseHst20221220s { get; set; }
        public virtual DbSet<SuspenseType> SuspenseTypes { get; set; }
        public virtual DbSet<SuspnAdmApprvType> SuspnAdmApprvTypes { get; set; }
        public virtual DbSet<SuspnApprvHst> SuspnApprvHsts { get; set; }
        public virtual DbSet<SuspnFinApprvType> SuspnFinApprvTypes { get; set; }
        public virtual DbSet<SuspnStatusType> SuspnStatusTypes { get; set; }
        public virtual DbSet<SuspnUseStatusType> SuspnUseStatusTypes { get; set; }
        public virtual DbSet<SwitchingRegistrationTemp> SwitchingRegistrationTemps { get; set; }
        public virtual DbSet<SysMenuLst> SysMenuLsts { get; set; }
        public virtual DbSet<TNotaDetail> TNotaDetails { get; set; }
        public virtual DbSet<TNotaHeader> TNotaHeaders { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<TaccType> TaccTypes { get; set; }
        public virtual DbSet<TaddressType> TaddressTypes { get; set; }
        public virtual DbSet<TallowWithType> TallowWithTypes { get; set; }
        public virtual DbSet<TappStatusType> TappStatusTypes { get; set; }
        public virtual DbSet<TapprovalLayerType> TapprovalLayerTypes { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<TaxWdType> TaxWdTypes { get; set; }
        public virtual DbSet<TbCntrbRdn> TbCntrbRdns { get; set; }
        public virtual DbSet<TbPenampung> TbPenampungs { get; set; }
        public virtual DbSet<TbRekBank> TbRekBanks { get; set; }
        public virtual DbSet<TbankType> TbankTypes { get; set; }
        public virtual DbSet<TbeneRelationType> TbeneRelationTypes { get; set; }
        public virtual DbSet<TbeneType> TbeneTypes { get; set; }
        public virtual DbSet<TblConfirmationLetter> TblConfirmationLetters { get; set; }
        public virtual DbSet<TblDbDirect> TblDbDirects { get; set; }
        public virtual DbSet<TblDbDirectBit> TblDbDirectBits { get; set; }
        public virtual DbSet<TblDbDirectFeeTax> TblDbDirectFeeTaxes { get; set; }
        public virtual DbSet<TblDbDirectNotafikasi> TblDbDirectNotafikasis { get; set; }
        public virtual DbSet<TblDbDirectSwitch> TblDbDirectSwitches { get; set; }
        public virtual DbSet<TblFppflpPerkiraan> TblFppflpPerkiraans { get; set; }
        public virtual DbSet<TblFppflpPerkiraan20230316> TblFppflpPerkiraan20230316s { get; set; }
        public virtual DbSet<TblFppflpPerkiraan20230316bak> TblFppflpPerkiraan20230316baks { get; set; }
        public virtual DbSet<TblFppflpPerkiraanTemp> TblFppflpPerkiraanTemps { get; set; }
        public virtual DbSet<TblFppflpPerkiraancustody> TblFppflpPerkiraancustodies { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TboInvRate> TboInvRates { get; set; }
        public virtual DbSet<TboInvType> TboInvTypes { get; set; }
        public virtual DbSet<TchargeType> TchargeTypes { get; set; }
        public virtual DbSet<Tcitizenship> Tcitizenships { get; set; }
        public virtual DbSet<TcoiType> TcoiTypes { get; set; }
        public virtual DbSet<TcoiTypeRate> TcoiTypeRates { get; set; }
        public virtual DbSet<TcommRltnType> TcommRltnTypes { get; set; }
        public virtual DbSet<TcommTitleType> TcommTitleTypes { get; set; }
        public virtual DbSet<TcommisionType> TcommisionTypes { get; set; }
        public virtual DbSet<Tcounter> Tcounters { get; set; }
        public virtual DbSet<TcreditCardType> TcreditCardTypes { get; set; }
        public virtual DbSet<TcurrencyType> TcurrencyTypes { get; set; }
        public virtual DbSet<TempAgen> TempAgens { get; set; }
        public virtual DbSet<TempFundInfo> TempFundInfos { get; set; }
        public virtual DbSet<TempFundInfo2> TempFundInfo2s { get; set; }
        public virtual DbSet<TempFundInfo2Disct> TempFundInfo2Discts { get; set; }
        public virtual DbSet<TempPengantarKartu> TempPengantarKartus { get; set; }
        public virtual DbSet<TempRealisasiKlaim> TempRealisasiKlaims { get; set; }
        public virtual DbSet<TempResult> TempResults { get; set; }
        public virtual DbSet<TempSaldoDana> TempSaldoDanas { get; set; }
        public virtual DbSet<TempSaldoPesertum> TempSaldoPeserta { get; set; }
        public virtual DbSet<TempSuratPengalihan> TempSuratPengalihans { get; set; }
        public virtual DbSet<TempTferPayUpdate> TempTferPayUpdates { get; set; }
        public virtual DbSet<TempUploadPayrollContribution> TempUploadPayrollContributions { get; set; }
        public virtual DbSet<TempVico> TempVicos { get; set; }
        public virtual DbSet<TempVicoMasterlist> TempVicoMasterlists { get; set; }
        public virtual DbSet<TempWd> TempWds { get; set; }
        public virtual DbSet<TempfeeWd> TempfeeWds { get; set; }
        public virtual DbSet<Tempgajistar> Tempgajistars { get; set; }
        public virtual DbSet<TempinvWd> TempinvWds { get; set; }
        public virtual DbSet<Tempnab> Tempnabs { get; set; }
        public virtual DbSet<TemporariTrnsHst> TemporariTrnsHsts { get; set; }
        public virtual DbSet<TemporariTrnsHstInv> TemporariTrnsHstInvs { get; set; }
        public virtual DbSet<Tempunitprice> Tempunitprices { get; set; }
        public virtual DbSet<TestDplkAkun> TestDplkAkuns { get; set; }
        public virtual DbSet<TestDplkRole> TestDplkRoles { get; set; }
        public virtual DbSet<TexceptionType> TexceptionTypes { get; set; }
        public virtual DbSet<TferPayInfo> TferPayInfos { get; set; }
        public virtual DbSet<TferPayInfo2> TferPayInfo2s { get; set; }
        public virtual DbSet<TferType> TferTypes { get; set; }
        public virtual DbSet<Tferpayinfo20220207> Tferpayinfo20220207s { get; set; }
        public virtual DbSet<TfrequencyType> TfrequencyTypes { get; set; }
        public virtual DbSet<TfundSrcType> TfundSrcTypes { get; set; }
        public virtual DbSet<ThistoriKomisi> ThistoriKomisis { get; set; }
        public virtual DbSet<TidType> TidTypes { get; set; }
        public virtual DbSet<TinvType> TinvTypes { get; set; }
        public virtual DbSet<TitleType> TitleTypes { get; set; }
        public virtual DbSet<TjobLvlType> TjobLvlTypes { get; set; }
        public virtual DbSet<TjobVctnType> TjobVctnTypes { get; set; }
        public virtual DbSet<TkomisiPesertaMandiri> TkomisiPesertaMandiris { get; set; }
        public virtual DbSet<Tkuitansi> Tkuitansis { get; set; }
        public virtual DbSet<TmailAddrType> TmailAddrTypes { get; set; }
        public virtual DbSet<TmaritalStatusType> TmaritalStatusTypes { get; set; }
        public virtual DbSet<TmaturityType> TmaturityTypes { get; set; }
        public virtual DbSet<TmcpType> TmcpTypes { get; set; }
        public virtual DbSet<TmnySrc> TmnySrcs { get; set; }
        public virtual DbSet<TmoneyType> TmoneyTypes { get; set; }
        public virtual DbSet<TmoveGroup> TmoveGroups { get; set; }
        public virtual DbSet<TmpCerCntrb> TmpCerCntrbs { get; set; }
        public virtual DbSet<TmpCerInv> TmpCerInvs { get; set; }
        public virtual DbSet<TmpCerInvDrct> TmpCerInvDrcts { get; set; }
        public virtual DbSet<TmpCerStatus> TmpCerStatuses { get; set; }
        public virtual DbSet<TmpCertificate> TmpCertificates { get; set; }
        public virtual DbSet<TmpClaimRegister> TmpClaimRegisters { get; set; }
        public virtual DbSet<TmpClaimRegisterTrack> TmpClaimRegisterTracks { get; set; }
        public virtual DbSet<TmpClaimRequest> TmpClaimRequests { get; set; }
        public virtual DbSet<TmpCycleCertificateCharge> TmpCycleCertificateCharges { get; set; }
        public virtual DbSet<TmpTblFppflpPerkiraan> TmpTblFppflpPerkiraans { get; set; }
        public virtual DbSet<TmpchanCerInv> TmpchanCerInvs { get; set; }
        public virtual DbSet<TokaiTemp> TokaiTemps { get; set; }
        public virtual DbSet<TpayRspnType> TpayRspnTypes { get; set; }
        public virtual DbSet<TpaymentApprvType> TpaymentApprvTypes { get; set; }
        public virtual DbSet<TpaymentTrnsType> TpaymentTrnsTypes { get; set; }
        public virtual DbSet<TpaymentType> TpaymentTypes { get; set; }
        public virtual DbSet<TphoneType> TphoneTypes { get; set; }
        public virtual DbSet<Tpic> Tpics { get; set; }
        public virtual DbSet<TpremiumMethod> TpremiumMethods { get; set; }
        public virtual DbSet<TpremiumType> TpremiumTypes { get; set; }
        public virtual DbSet<TproductType> TproductTypes { get; set; }
        public virtual DbSet<Tprovince> Tprovinces { get; set; }
        public virtual DbSet<TpslType> TpslTypes { get; set; }
        public virtual DbSet<TrateTableDetail> TrateTableDetails { get; set; }
        public virtual DbSet<TrateTableType> TrateTableTypes { get; set; }
        public virtual DbSet<TriderType> TriderTypes { get; set; }
        public virtual DbSet<TrnsAdminGantung> TrnsAdminGantungs { get; set; }
        public virtual DbSet<TrnsDocType> TrnsDocTypes { get; set; }
        public virtual DbSet<TrnsHst> TrnsHsts { get; set; }
        public virtual DbSet<TrnsHst20230216> TrnsHst20230216s { get; set; }
        public virtual DbSet<TrnsHstCleannet> TrnsHstCleannets { get; set; }
        public virtual DbSet<TrnsHstFee> TrnsHstFees { get; set; }
        public virtual DbSet<TrnsHstFeeSwitch> TrnsHstFeeSwitches { get; set; }
        public virtual DbSet<TrnsHstFeeWd> TrnsHstFeeWds { get; set; }
        public virtual DbSet<TrnsHstInv> TrnsHstInvs { get; set; }
        public virtual DbSet<TrnsHstInv20230216> TrnsHstInv20230216s { get; set; }
        public virtual DbSet<TrnsHstInvClean20230327> TrnsHstInvClean20230327s { get; set; }
        public virtual DbSet<TrnsHstInvCleannet> TrnsHstInvCleannets { get; set; }
        public virtual DbSet<TrnsHstInvSwitch> TrnsHstInvSwitches { get; set; }
        public virtual DbSet<TrnsHstInvTempv> TrnsHstInvTempvs { get; set; }
        public virtual DbSet<TrnsHstInvWd> TrnsHstInvWds { get; set; }
        public virtual DbSet<TrnsHstSwitch> TrnsHstSwitches { get; set; }
        public virtual DbSet<TrnsHstTempv> TrnsHstTempvs { get; set; }
        public virtual DbSet<TrnsHstWd> TrnsHstWds { get; set; }
        public virtual DbSet<TrnsPost> TrnsPosts { get; set; }
        public virtual DbSet<TrnsType> TrnsTypes { get; set; }
        public virtual DbSet<TroleType> TroleTypes { get; set; }
        public virtual DbSet<TsecType> TsecTypes { get; set; }
        public virtual DbSet<TsecurityType> TsecurityTypes { get; set; }
        public virtual DbSet<TsiCalcType> TsiCalcTypes { get; set; }
        public virtual DbSet<TstatusType> TstatusTypes { get; set; }
        public virtual DbSet<TsunGlType> TsunGlTypes { get; set; }
        public virtual DbSet<TsuspenseType> TsuspenseTypes { get; set; }
        public virtual DbSet<TsuspnAdmApprvType> TsuspnAdmApprvTypes { get; set; }
        public virtual DbSet<TsuspnFinApprvType> TsuspnFinApprvTypes { get; set; }
        public virtual DbSet<TsuspnStatusType> TsuspnStatusTypes { get; set; }
        public virtual DbSet<TsuspnUseStatusType> TsuspnUseStatusTypes { get; set; }
        public virtual DbSet<TtaxType> TtaxTypes { get; set; }
        public virtual DbSet<TtaxWdType> TtaxWdTypes { get; set; }
        public virtual DbSet<TtempKomisi> TtempKomisis { get; set; }
        public virtual DbSet<TtferType> TtferTypes { get; set; }
        public virtual DbSet<TtitleType> TtitleTypes { get; set; }
        public virtual DbSet<TtrnsType> TtrnsTypes { get; set; }
        public virtual DbSet<TvaCurrencyType> TvaCurrencyTypes { get; set; }
        public virtual DbSet<TvaDplkType> TvaDplkTypes { get; set; }
        public virtual DbSet<TvaProductType> TvaProductTypes { get; set; }
        public virtual DbSet<TvestingType> TvestingTypes { get; set; }
        public virtual DbSet<TwdDocType> TwdDocTypes { get; set; }
        public virtual DbSet<TwdStatusType> TwdStatusTypes { get; set; }
        public virtual DbSet<TwdTransferType> TwdTransferTypes { get; set; }
        public virtual DbSet<TwithSourceType> TwithSourceTypes { get; set; }
        public virtual DbSet<UnitPrice> UnitPrices { get; set; }
        public virtual DbSet<UploadJoinAccount> UploadJoinAccounts { get; set; }
        public virtual DbSet<UploadMandiriIi> UploadMandiriIis { get; set; }
        public virtual DbSet<UploadMandiriIiBak> UploadMandiriIiBaks { get; set; }
        public virtual DbSet<UploadMandiriIiClaim> UploadMandiriIiClaims { get; set; }
        public virtual DbSet<UploadMandiriIiClaimTran> UploadMandiriIiClaimTrans { get; set; }
        public virtual DbSet<UploadMutasiDana> UploadMutasiDanas { get; set; }
        public virtual DbSet<UploadNab> UploadNabs { get; set; }
        public virtual DbSet<UploadNewParticipant> UploadNewParticipants { get; set; }
        public virtual DbSet<UploadNewParticipantMoneyType> UploadNewParticipantMoneyTypes { get; set; }
        public virtual DbSet<UploadPayrollContribution> UploadPayrollContributions { get; set; }
        public virtual DbSet<UploadRollover> UploadRollovers { get; set; }
        public virtual DbSet<UploadSuspense> UploadSuspenses { get; set; }
        public virtual DbSet<UploadUpdateDeliveryDate> UploadUpdateDeliveryDates { get; set; }
        public virtual DbSet<UploadUpdateParticipant> UploadUpdateParticipants { get; set; }
        public virtual DbSet<UploadUpdateParticipantMoneyType> UploadUpdateParticipantMoneyTypes { get; set; }
        public virtual DbSet<Uploadlumpsum> Uploadlumpsums { get; set; }
        public virtual DbSet<UsrActvy> UsrActvies { get; set; }
        public virtual DbSet<UsrLst> UsrLsts { get; set; }
        public virtual DbSet<VClaimRequest1> VClaimRequest1s { get; set; }
        public virtual DbSet<VClaimRequest2> VClaimRequest2s { get; set; }
        public virtual DbSet<VClaimRequest3> VClaimRequest3s { get; set; }
        public virtual DbSet<VClaimRequest4> VClaimRequest4s { get; set; }
        public virtual DbSet<VDplkRider> VDplkRiders { get; set; }
        public virtual DbSet<VKomisiDplkRider> VKomisiDplkRiders { get; set; }
        public virtual DbSet<VKomisiDplkRiderBck> VKomisiDplkRiderBcks { get; set; }
        public virtual DbSet<VaCurrencyType> VaCurrencyTypes { get; set; }
        public virtual DbSet<VaDplkType> VaDplkTypes { get; set; }
        public virtual DbSet<VaGroup> VaGroups { get; set; }
        public virtual DbSet<VaProductType> VaProductTypes { get; set; }
        public virtual DbSet<VestingType> VestingTypes { get; set; }
        public virtual DbSet<ViewAssetPesertum> ViewAssetPeserta { get; set; }
        public virtual DbSet<ViewIndAkumulasiIuran> ViewIndAkumulasiIurans { get; set; }
        public virtual DbSet<ViewIndAkumulasiPenarikan> ViewIndAkumulasiPenarikans { get; set; }
        public virtual DbSet<ViewIndClaimTracker> ViewIndClaimTrackers { get; set; }
        public virtual DbSet<ViewIndHargaUnit> ViewIndHargaUnits { get; set; }
        public virtual DbSet<ViewIndPesertum> ViewIndPeserta { get; set; }
        public virtual DbSet<ViewIndPilihanInvestasi> ViewIndPilihanInvestasis { get; set; }
        public virtual DbSet<ViewIndSaldoPesertum> ViewIndSaldoPeserta { get; set; }
        public virtual DbSet<ViewIuran> ViewIurans { get; set; }
        public virtual DbSet<ViewIuranInvest> ViewIuranInvests { get; set; }
        public virtual DbSet<ViewIuranInvestVw> ViewIuranInvestVws { get; set; }
        public virtual DbSet<ViewKlaimPaid> ViewKlaimPaids { get; set; }
        public virtual DbSet<ViewKlaimRegister> ViewKlaimRegisters { get; set; }
        public virtual DbSet<ViewPesertaDplk> ViewPesertaDplks { get; set; }
        public virtual DbSet<ViewTblCorMasterList> ViewTblCorMasterLists { get; set; }
        public virtual DbSet<ViewTblCorPesertum> ViewTblCorPeserta { get; set; }
        public virtual DbSet<VirtualAccount> VirtualAccounts { get; set; }
        public virtual DbSet<VuPesertum> VuPeserta { get; set; }
        public virtual DbSet<VwCashBasisGroupCommission> VwCashBasisGroupCommissions { get; set; }
        public virtual DbSet<VwKomisiCashBasisIndividu> VwKomisiCashBasisIndividus { get; set; }
        public virtual DbSet<VwKomisiDplk> VwKomisiDplks { get; set; }
        public virtual DbSet<VwKomisiGroup> VwKomisiGroups { get; set; }
        public virtual DbSet<VwKomisiPengalihan> VwKomisiPengalihans { get; set; }
        public virtual DbSet<VwKomisiPesertaMandiri> VwKomisiPesertaMandiris { get; set; }
        public virtual DbSet<VwSuratPengantarKartuPerusahaan> VwSuratPengantarKartuPerusahaans { get; set; }
        public virtual DbSet<VwTransPertamina> VwTransPertaminas { get; set; }
        public virtual DbSet<VwYearlyGroupCommission> VwYearlyGroupCommissions { get; set; }
        public virtual DbSet<WdAccumulator> WdAccumulators { get; set; }
        public virtual DbSet<WdDocList> WdDocLists { get; set; }
        public virtual DbSet<WdDocSetup> WdDocSetups { get; set; }
        public virtual DbSet<WdDocType> WdDocTypes { get; set; }
        public virtual DbSet<WdStatusType> WdStatusTypes { get; set; }
        public virtual DbSet<WdTransferType> WdTransferTypes { get; set; }
        public virtual DbSet<WithSourceType> WithSourceTypes { get; set; }
        public virtual DbSet<XJurnalPosting> XJurnalPostings { get; set; }
        public virtual DbSet<YearlyCommissionFlag> YearlyCommissionFlags { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<GetKartuIndividu>().HasNoKey();
            modelBuilder.Entity<AccType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_type");

                entity.Property(e => e.AccTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("acc_type_nm");

                entity.Property(e => e.AccTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });
            modelBuilder.Entity<Accumulatedunitvico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACCUMULATEDUNITVICO");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CreditPost).HasColumnName("credit_post");

                entity.Property(e => e.DebetPost).HasColumnName("debet_post");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.Rownum).HasColumnName("rownum");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.Sumunit).HasColumnName("sumunit");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.AddrTypeNmbr)
                    .HasName("PK__address_type__63256CB5")
                    .IsClustered(false);

                entity.ToTable("address_type");

                entity.Property(e => e.AddrTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("addr_type_nmbr");

                entity.Property(e => e.AddrTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<AgentCommMethod>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.AgentNmbr });

                entity.ToTable("agent_comm_method");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.AgentNmbr).HasColumnName("agent_nmbr");

                entity.Property(e => e.CommAmt).HasColumnName("comm_amt");

                entity.Property(e => e.CommPct).HasColumnName("comm_pct");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxComm).HasColumnName("max_comm");

                entity.Property(e => e.TerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("termination_dt");
            });

            modelBuilder.Entity<AgentMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("agent_master");

                entity.Property(e => e.AcctNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acct_nm");

                entity.Property(e => e.AcctNmbr)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("acct_nmbr");

                entity.Property(e => e.Address)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AgentNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agent_nm");

                entity.Property(e => e.AgentNmbr)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("agent_nmbr");

                entity.Property(e => e.AgentStatus)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("agent_type");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("bank_address");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.City)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.OldAgentNmbr)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("old_agent_nmbr");

                entity.Property(e => e.PhoneNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_nmbr");

                entity.Property(e => e.PostalCd)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("postal_cd");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");
            });

            modelBuilder.Entity<AgentMasterTemp>(entity =>
            {
                entity.HasKey(e => e.AgentNmbr)
                    .HasName("PK_agent_master");

                entity.ToTable("agent_master_temp");

                entity.Property(e => e.AgentNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("agent_nmbr");

                entity.Property(e => e.AcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("acct_nm");

                entity.Property(e => e.AcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acct_nmbr");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AgentNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("agent_nm");

                entity.Property(e => e.AgentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agent_status");

                entity.Property(e => e.AgentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("agent_type");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("bank_address");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.OldAgentNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_agent_nmbr");

                entity.Property(e => e.PhoneNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_nmbr");

                entity.Property(e => e.PostalCd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("postal_cd");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");
            });

            modelBuilder.Entity<AllowWithType>(entity =>
            {
                entity.HasKey(e => e.AllowWithNmbr)
                    .HasName("PK__allow_with_type__650DB527");

                entity.ToTable("allow_with_type");

                entity.Property(e => e.AllowWithNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("allow_with_nmbr");

                entity.Property(e => e.AllowWithNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("allow_with_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<AppHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("app_hst");

                entity.Property(e => e.AppStatusNmbr).HasColumnName("app_status_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<AppStatusType>(entity =>
            {
                entity.HasKey(e => e.AppStatusNmbr);

                entity.ToTable("app_status_type");

                entity.Property(e => e.AppStatusNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("app_status_nmbr");

                entity.Property(e => e.AppStatusNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("app_status_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<ApprovalLayerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("approval_layer_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxAmt).HasColumnName("max_amt");

                entity.Property(e => e.TrnsId).HasColumnName("trns_id");

                entity.Property(e => e.UserApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_approval_nm");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasKey(e => e.AssetsNumber);

                entity.Property(e => e.AssetsNumber)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AssetsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.HasKey(e => e.AssetTypeNmbr);

                entity.ToTable("asset_type");

                entity.Property(e => e.AssetTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("asset_type_nmbr");

                entity.Property(e => e.AssetTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("asset_type_nm");
            });

            modelBuilder.Entity<AssetsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AssetsDetail");

                entity.Property(e => e.AssetNumberType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AvgBookCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.BookCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.DaysAccr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EffectiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Effective_dt");

                entity.Property(e => e.FaceValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.IntRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.MarketValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaturityDate).HasColumnType("datetime");

                entity.Property(e => e.ProfitShare).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.SubAssetsName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubAssetsNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("audit_trail");

                entity.Property(e => e.AppNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("app_nm");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CodeType).HasColumnName("code_type");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.FieldNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field_nm");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.HostNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("host_nm");

                entity.Property(e => e.Info1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("info1");

                entity.Property(e => e.Info2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("info2");

                entity.Property(e => e.Info3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("info3");

                entity.Property(e => e.Info4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("info4");

                entity.Property(e => e.Info5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("info5");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NewData)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("new_data");

                entity.Property(e => e.OldData)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("old_data");

                entity.Property(e => e.TableNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("table_nm");

                entity.Property(e => e.UsrId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("usr_id");
            });

            modelBuilder.Entity<BankType>(entity =>
            {
                entity.HasKey(e => e.BankTypeNmbr);

                entity.ToTable("bank_type");

                entity.Property(e => e.BankTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("bank_type_nmbr");

                entity.Property(e => e.BankTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("bank_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<Benchmark>(entity =>
            {
                entity.HasKey(e => new { e.Month, e.Year });

                entity.ToTable("benchmark");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.BenchmarkRt).HasColumnName("benchmark_rt");

                entity.Property(e => e.BniRt).HasColumnName("bni_rt");

                entity.Property(e => e.BriRt).HasColumnName("bri_rt");

                entity.Property(e => e.BtnRt).HasColumnName("btn_rt");

                entity.Property(e => e.MandiriRt).HasColumnName("mandiri_rt");
            });

            modelBuilder.Entity<BeneRelationType>(entity =>
            {
                entity.HasKey(e => e.BeneRltnNmbr)
                    .HasName("PK__bene_relation_ty__32AB8735")
                    .IsClustered(false);

                entity.ToTable("bene_relation_type");

                entity.Property(e => e.BeneRltnNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("bene_rltn_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RelationNm)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("relation_nm");
            });

            modelBuilder.Entity<BeneType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bene_type");

                entity.Property(e => e.BeneTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bene_type_nm");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.ParentBeneTypeNmbr).HasColumnName("parent_bene_type_nmbr");
            });

            modelBuilder.Entity<Beneficiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("beneficiary");

                entity.HasIndex(e => e.ClientNmbr, "xbeneficiary");

                entity.Property(e => e.BeneDob)
                    .HasColumnType("datetime")
                    .HasColumnName("bene_dob");

                entity.Property(e => e.BeneNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bene_nm");

                entity.Property(e => e.BeneNmbr).HasColumnName("bene_nmbr");

                entity.Property(e => e.BenePercent).HasColumnName("bene_percent");

                entity.Property(e => e.BeneRltnNmbr).HasColumnName("bene_rltn_nmbr");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bill");

                entity.Property(e => e.BillAmt).HasColumnName("bill_amt");

                entity.Property(e => e.BillCreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bill_create_dt");

                entity.Property(e => e.BillEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bill_efctv_dt");

                entity.Property(e => e.BillFreqNmbr).HasColumnName("bill_freq_nmbr");

                entity.Property(e => e.BillRunDt)
                    .HasColumnType("datetime")
                    .HasColumnName("bill_run_dt");

                entity.Property(e => e.BillSeqNmbr).HasColumnName("bill_seq_nmbr");

                entity.Property(e => e.BillType).HasColumnName("bill_type");

                entity.Property(e => e.Comment)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OutstandingAmt).HasColumnName("outstanding_amt");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("received_dt");

                entity.Property(e => e.ReversalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversal_dt");

                entity.Property(e => e.SuspenseUseCd).HasColumnName("suspense_use_cd");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bill_detail");

                entity.Property(e => e.AdjAmt).HasColumnName("adj_amt");

                entity.Property(e => e.BillDtlAmt).HasColumnName("bill_dtl_amt");

                entity.Property(e => e.BillDtlNmbr).HasColumnName("bill_dtl_nmbr");

                entity.Property(e => e.BillSeqNmbr).HasColumnName("bill_seq_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.PayorTypeNmbr).HasColumnName("payor_type_nmbr");
            });

            modelBuilder.Entity<BillingStatus>(entity =>
            {
                entity.HasKey(e => e.GroupNmbr)
                    .HasName("PK__billing_status__707F67D3")
                    .IsClustered(false);

                entity.ToTable("billing_status");

                entity.Property(e => e.GroupNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("group_nmbr");

                entity.Property(e => e.AutoPrintFlg).HasColumnName("auto_print_flg");

                entity.Property(e => e.BillFreqNmbr).HasColumnName("bill_freq_nmbr");

                entity.Property(e => e.CntrbFreqNmbr).HasColumnName("cntrb_freq_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MateraiFlg).HasColumnName("materai_flg");

                entity.Property(e => e.NextBillDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_bill_dt");

                entity.Property(e => e.NextBillPrd)
                    .HasColumnType("datetime")
                    .HasColumnName("next_bill_prd");

                entity.Property(e => e.NextCntrbDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_cntrb_dt");

                entity.Property(e => e.NextCntrbPrd)
                    .HasColumnType("datetime")
                    .HasColumnName("next_cntrb_prd");

                entity.Property(e => e.NextPrintDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_print_dt");

                entity.Property(e => e.NextPslDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_psl_dt");

                entity.Property(e => e.NextPslPrd)
                    .HasColumnType("datetime")
                    .HasColumnName("next_psl_prd");

                entity.Property(e => e.PslFreqNmbr).HasColumnName("psl_freq_nmbr");

                entity.Property(e => e.PslFreqcy).HasColumnName("psl_freqcy");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithOne(p => p.BillingStatus)
                    .HasForeignKey<BillingStatus>(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__billing_s__group__76F75B38");
            });

            modelBuilder.Entity<BoInvRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bo_inv_rate");

                entity.Property(e => e.BoInvTypeNmbr).HasColumnName("bo_inv_type_nmbr");

                entity.Property(e => e.FundManagerNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fund_manager_nm");

                entity.Property(e => e.InvPct).HasColumnName("inv_pct");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");
            });

            modelBuilder.Entity<BoInvType>(entity =>
            {
                entity.HasKey(e => e.BoInvTypeNmbr);

                entity.ToTable("bo_inv_type");

                entity.Property(e => e.BoInvTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("bo_inv_type_nmbr");

                entity.Property(e => e.BoInvTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bo_inv_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_id_nmbr");
            });

            modelBuilder.Entity<BranchOffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("branch_office");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.BranchCode).HasColumnName("branch_code");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branch_name");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PostalCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postal_cd");

                entity.Property(e => e.ProvinceNmbr).HasColumnName("province_nmbr");
            });

            modelBuilder.Entity<BuktiTrfDb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BuktiTrfDB");

                entity.Property(e => e.Column0)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");
            });

            modelBuilder.Entity<BusinessLine>(entity =>
            {
                entity.HasKey(e => new { e.BusinessLineNmbr, e.BusinessSctrNmbr })
                    .HasName("PK__business_line__7267B045")
                    .IsClustered(false);

                entity.ToTable("business_line");

                entity.Property(e => e.BusinessLineNmbr).HasColumnName("business_line_nmbr");

                entity.Property(e => e.BusinessSctrNmbr).HasColumnName("business_sctr_nmbr");

                entity.Property(e => e.BusinessLineNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("business_line_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.HasOne(d => d.BusinessSctrNmbrNavigation)
                    .WithMany(p => p.BusinessLines)
                    .HasForeignKey(d => d.BusinessSctrNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__business___busin__77EB7F71");
            });

            modelBuilder.Entity<BusinessSctr>(entity =>
            {
                entity.HasKey(e => e.BusinessSctrNmbr)
                    .HasName("PK__business_sctr__744FF8B7")
                    .IsClustered(false);

                entity.ToTable("business_sctr");

                entity.Property(e => e.BusinessSctrNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("business_sctr_nmbr");

                entity.Property(e => e.BusinessSctrNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("business_sctr_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<CerAccumulator>(entity =>
            {
                entity.HasKey(e => new { e.CerNmbr, e.MoneyTypeNmbr })
                    .HasName("PK__cer_accumulator__76384129");

                entity.ToTable("cer_accumulator");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.DstbAmt).HasColumnName("dstb_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerAccumulators)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_accum__cer_n__78DFA3AA");

                entity.HasOne(d => d.MoneyTypeNmbrNavigation)
                    .WithMany(p => p.CerAccumulators)
                    .HasForeignKey(d => d.MoneyTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_accum__money__79D3C7E3");
            });
            modelBuilder.Entity<CerAccumulatorTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_accumulator_temp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.DstbAmt).HasColumnName("dstb_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");
            });

            modelBuilder.Entity<CerCharge>(entity =>
            {
                entity.HasKey(e => new { e.CerNmbr, e.ChargeTypeNmbr, e.EfctvDt });

                entity.ToTable("cer_charge");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NextChargeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_charge_dt");

                entity.HasOne(d => d.ChargeTypeNmbrNavigation)
                    .WithMany(p => p.CerCharges)
                    .HasForeignKey(d => d.ChargeTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cer_charge_type_nmbr");
            });

            modelBuilder.Entity<CerCntrb>(entity =>
            {
                entity.HasKey(e => new { e.CerNmbr, e.McpNmbr, e.MoneyTypeNmbr, e.EfctvDt })
                    .HasName("PK__cer_cntrb__7820899B")
                    .IsClustered(false);

                entity.ToTable("cer_cntrb");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.McpNmbr).HasColumnName("mcp_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbRt).HasColumnName("cntrb_rt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.UseGrpCd).HasColumnName("use_grp_cd");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerCntrbs)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_cntrb__cer_n__7CB0348E");

                entity.HasOne(d => d.MoneyTypeNmbrNavigation)
                    .WithMany(p => p.CerCntrbs)
                    .HasForeignKey(d => d.MoneyTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_cntrb__money__7AC7EC1C");
            });

            modelBuilder.Entity<CerInv>(entity =>
            {
                entity.HasKey(e => new { e.MoneyTypeNmbr, e.CerNmbr, e.InvTypeNmbr })
                    .HasName("PK__cer_inv__7A08D20D")
                    .IsClustered(false);

                entity.ToTable("cer_inv");

                entity.HasIndex(e => e.UnitCount, "IX_cer_inv_missing_254");

                entity.HasIndex(e => e.CerNmbr, "IX_cer_inv_missing_756");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.UnitCount).HasColumnName("unit_count");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerInvs)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_inv__cer_nmb__7DA458C7");

                entity.HasOne(d => d.MoneyTypeNmbrNavigation)
                    .WithMany(p => p.CerInvs)
                    .HasForeignKey(d => d.MoneyTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_inv__money_t__7E987D00");
            });

            modelBuilder.Entity<CerInvDrct>(entity =>
            {
                entity.HasKey(e => new { e.EfctvDt, e.CerNmbr, e.InvTypeNmbr, e.MoneyTypeNmbr })
                    .HasName("PK__cer_inv_drct__7BF11A7F")
                    .IsClustered(false);

                entity.ToTable("cer_inv_drct");

                entity.HasIndex(e => e.InvTypeNmbr, "IX_cer_inv_drct_missing_85");

                entity.HasIndex(e => new { e.CerNmbr, e.EfctvDt }, "xcer_inv_drct");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerInvDrcts)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_inv_d__cer_n__0080C572");

                entity.HasOne(d => d.InvTypeNmbrNavigation)
                    .WithMany(p => p.CerInvDrcts)
                    .HasForeignKey(d => d.InvTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_inv_d__inv_t__0174E9AB");

                entity.HasOne(d => d.MoneyTypeNmbrNavigation)
                    .WithMany(p => p.CerInvDrcts)
                    .HasForeignKey(d => d.MoneyTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_inv_d__money__7F8CA139");
            });

            modelBuilder.Entity<CerInvDrctSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_inv_drct_switch");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.Percentage).HasColumnName("percentage");
            });

            modelBuilder.Entity<CerInvDrctTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_inv_drct_temp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.Percentage).HasColumnName("percentage");
            });

            modelBuilder.Entity<CerInvDrctTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_inv_drct_tmp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.Percentage).HasColumnName("percentage");
            });

            modelBuilder.Entity<CerMovement>(entity =>
            {
                entity.HasKey(e => new { e.CerSeqNmbr, e.CerNmbr })
                    .HasName("PK__cer_movement__7DD962F1")
                    .IsClustered(false);

                entity.ToTable("cer_movement");

                entity.Property(e => e.CerSeqNmbr).HasColumnName("cer_seq_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NewGrpNmbr).HasColumnName("new_grp_nmbr");

                entity.Property(e => e.OldGrpNmbr).HasColumnName("old_grp_nmbr");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerMovements)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_movem__cer_n__02690DE4");
            });

            modelBuilder.Entity<CerMovementSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_movement_switch");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NewGrpNmbr).HasColumnName("new_grp_nmbr");

                entity.Property(e => e.OldGrpNmbr).HasColumnName("old_grp_nmbr");
            });

            modelBuilder.Entity<CerStatus>(entity =>
            {
                entity.HasKey(e => new { e.EfctvDt, e.CerNmbr, e.StatusTypeNmbr })
                    .HasName("PK__cer_status__7FC1AB63")
                    .IsClustered(false);

                entity.ToTable("cer_status");

                entity.HasIndex(e => e.StatusTypeNmbr, "IX_cer_status_missing_252");

                entity.HasIndex(e => new { e.CerNmbr, e.EfctvDt }, "IX_cer_status_missing_3");

                entity.HasIndex(e => new { e.StatusTypeNmbr, e.CerNmbr }, "_dta_index_cer_status_9_1771153355__K3_K2");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.StatusTypeNmbr).HasColumnName("status_type_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerStatuses)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_statu__cer_n__04515656");

                entity.HasOne(d => d.StatusTypeNmbrNavigation)
                    .WithMany(p => p.CerStatuses)
                    .HasForeignKey(d => d.StatusTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_statu__statu__035D321D");
            });

            modelBuilder.Entity<CerTrnsCnt>(entity =>
            {
                entity.HasKey(e => new { e.CerNmbr, e.ChargeTypeNmbr })
                    .HasName("PK__cer_trns_cnt__0FB750B3")
                    .IsClustered(false);

                entity.ToTable("cer_trns_cnt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.TrnsCnt).HasColumnName("trns_cnt");

                entity.HasOne(d => d.CerNmbrNavigation)
                    .WithMany(p => p.CerTrnsCnts)
                    .HasForeignKey(d => d.CerNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_trns___cer_n__06399EC8");

                entity.HasOne(d => d.ChargeTypeNmbrNavigation)
                    .WithMany(p => p.CerTrnsCnts)
                    .HasForeignKey(d => d.ChargeTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cer_trns___charg__05457A8F");
            });

            modelBuilder.Entity<CerWargiani>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cer_wargiani");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.StatusTypeNmbr).HasColumnName("status_type_nmbr");
            });

            modelBuilder.Entity<Certificate>(entity =>
            {
                entity.HasKey(e => e.CerNmbr)
                    .HasName("PK__certificate__03923C47")
                    .IsClustered(false);

                entity.ToTable("certificate");

                entity.HasIndex(e => new { e.GroupNmbr, e.EfctvDt }, "IX_certificate");

                entity.HasIndex(e => e.GroupNmbr, "IX_certificate_missing_100");

                entity.HasIndex(e => e.GroupNmbr, "IX_certificate_missing_2521");

                entity.HasIndex(e => new { e.ClientNmbr, e.GroupNmbr, e.CerNmbr }, "_dta_index_certificate_9_1803153469__K3_K2_K1_5_28");

                entity.HasIndex(e => new { e.CerNmbr, e.GroupNmbr, e.ClientNmbr, e.EfctvDt, e.MaturityDt }, "xcertificate");

                entity.Property(e => e.CerNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.AppReceiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("app_receive_dt");

                entity.Property(e => e.AppStatusNmbr).HasColumnName("app_status_nmbr");

                entity.Property(e => e.ApuPpt).HasColumnName("apu_ppt");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CerNmbrOpf).HasColumnName("cer_nmbr_opf");

                entity.Property(e => e.CitizenshipCd).HasColumnName("citizenship_cd");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.CommisionTypeNmbr).HasColumnName("commision_type_nmbr");

                entity.Property(e => e.CompletionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("completion_dt");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.Employee2Nmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee2_nmbr");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.EmploymentDt)
                    .HasColumnType("datetime")
                    .HasColumnName("employment_dt");

                entity.Property(e => e.FirstPremiumFlg).HasColumnName("first_premium_flg");

                entity.Property(e => e.FlagKomisi).HasColumnName("flag_komisi");

                entity.Property(e => e.FlagKomisi1).HasColumnName("flag_komisi_1");

                entity.Property(e => e.FlagKomisi2).HasColumnName("flag_komisi_2");

                entity.Property(e => e.FundSrcNmbr).HasColumnName("fund_src_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.JobVctnNmbr).HasColumnName("job_vctn_nmbr");

                entity.Property(e => e.KitDeliveryDt)
                    .HasColumnType("datetime")
                    .HasColumnName("kit_delivery_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaturityDt)
                    .HasColumnType("datetime")
                    .HasColumnName("maturity_dt");

                entity.Property(e => e.OldCerNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_cer_nmbr");

                entity.Property(e => e.OthDppkFlg).HasColumnName("oth_DPPK_flg");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.PaymentTypeNmbr).HasColumnName("payment_type_nmbr");

                entity.Property(e => e.PinPrintDt)
                    .HasColumnType("datetime")
                    .HasColumnName("pin_print_dt");

                entity.Property(e => e.PlanTypeNmbr).HasColumnName("plan_type_nmbr");

                entity.Property(e => e.PremiumTypeNmbr).HasColumnName("premium_type_nmbr");

                entity.Property(e => e.RetirementAge).HasColumnName("retirement_age");

                entity.Property(e => e.RiderTypeNmbr).HasColumnName("rider_type_nmbr");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");

                entity.Property(e => e.TerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("termination_dt");

                entity.Property(e => e.VAccNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("v_acc_nmbr");
            });

            modelBuilder.Entity<ChargeType>(entity =>
            {
                entity.HasKey(e => e.ChargeTypeNmbr)
                    .HasName("PK__charge_type__057A84B9")
                    .IsClustered(false);

                entity.ToTable("charge_type");

                entity.HasIndex(e => new { e.ChargeTypeNmbr, e.ChargeTypeNm }, "xcharge_type")
                    .HasFillFactor(80);

                entity.Property(e => e.ChargeTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("charge_type_nmbr");

                entity.Property(e => e.ChargeTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("charge_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<Citizenship>(entity =>
            {
                entity.HasKey(e => e.CitizenshipCd);

                entity.ToTable("citizenship");

                entity.Property(e => e.CitizenshipCd)
                    .ValueGeneratedNever()
                    .HasColumnName("citizenship_cd");

                entity.Property(e => e.CitizenshipNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizenship_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<ClaimRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claim_register");

                entity.HasIndex(e => e.CerNmbr, "IX_claim_register_missing_54");

                entity.HasIndex(e => new { e.CrId, e.CrDate, e.CerNmbr }, "xClaim_register");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClaimAmount).HasColumnName("claim_amount");

                entity.Property(e => e.CrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cr_date");

                entity.Property(e => e.CrId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.RegisterMtdNmbr).HasColumnName("register_mtd_nmbr");

                entity.Property(e => e.SubTrnsType).HasColumnName("sub_trns_type");
            });

            modelBuilder.Entity<ClaimRegisterDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claim_register_doc");

                entity.HasIndex(e => e.CrId, "IX_claim_register_doc_missing_39");

                entity.Property(e => e.CrId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.DocType).HasColumnName("doc_type");
            });

            modelBuilder.Entity<ClaimRegisterFlagRemunerasi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Claim_Register_Flag_Remunerasi");

                entity.Property(e => e.CrId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cr_id");

                entity.Property(e => e.FlagRemunerasi).HasColumnName("Flag_Remunerasi");
            });

            modelBuilder.Entity<ClaimRegisterTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claim_register_track");

                entity.HasIndex(e => e.CrId, "IX_claim_register_track_missing_88");

                entity.HasIndex(e => new { e.CrId, e.TrackTypeNmbr }, "xClaim_register_track");

                entity.Property(e => e.CrId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.TrackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("track_date");

                entity.Property(e => e.TrackTypeNmbr).HasColumnName("track_type_nmbr");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<ClaimRegistrationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ClaimRegistrationTemp");

                entity.Property(e => e.AtasNamaLumpsum)
                    .HasMaxLength(255)
                    .HasColumnName("Atas_Nama_Lumpsum");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(255)
                    .HasColumnName("Cer_Nmbr");

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(255)
                    .HasColumnName("Claim_Type");

                entity.Property(e => e.DocReceived)
                    .HasMaxLength(255)
                    .HasColumnName("Doc_Received");

                entity.Property(e => e.Hostname).HasMaxLength(255);

                entity.Property(e => e.IsDoc1).HasMaxLength(255);

                entity.Property(e => e.IsDoc10).HasMaxLength(255);

                entity.Property(e => e.IsDoc11).HasMaxLength(255);

                entity.Property(e => e.IsDoc12).HasMaxLength(255);

                entity.Property(e => e.IsDoc13).HasMaxLength(255);

                entity.Property(e => e.IsDoc14).HasMaxLength(255);

                entity.Property(e => e.IsDoc15).HasMaxLength(255);

                entity.Property(e => e.IsDoc16).HasMaxLength(255);

                entity.Property(e => e.IsDoc2).HasMaxLength(255);

                entity.Property(e => e.IsDoc3).HasMaxLength(255);

                entity.Property(e => e.IsDoc4).HasMaxLength(255);

                entity.Property(e => e.IsDoc5).HasMaxLength(255);

                entity.Property(e => e.IsDoc6).HasMaxLength(255);

                entity.Property(e => e.IsDoc7).HasMaxLength(255);

                entity.Property(e => e.IsDoc8).HasMaxLength(255);

                entity.Property(e => e.IsDoc9).HasMaxLength(255);

                entity.Property(e => e.KodeBankLumpsum)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Bank_Lumpsum");

                entity.Property(e => e.LumpsumPct)
                    .HasMaxLength(50)
                    .HasColumnName("Lumpsum_Pct");

                entity.Property(e => e.NamaBankLumpsum)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Bank_Lumpsum");

                entity.Property(e => e.NamaCabangLumpsum)
                    .HasMaxLength(50)
                    .HasColumnName("Nama_Cabang_Lumpsum");

                entity.Property(e => e.NoRekLumpsum)
                    .HasMaxLength(255)
                    .HasColumnName("No_Rek_Lumpsum");

                entity.Property(e => e.Userid).HasMaxLength(50);
            });

            modelBuilder.Entity<ClaimRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claim_request");

                entity.HasIndex(e => new { e.CrId, e.Thedate, e.BatchId }, "xClaim_request");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("batch_id");

                entity.Property(e => e.CrId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.Takenby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("takenby");

                entity.Property(e => e.Takendate)
                    .HasColumnType("datetime")
                    .HasColumnName("takendate");

                entity.Property(e => e.Thedate)
                    .HasColumnType("datetime")
                    .HasColumnName("thedate");
            });

            modelBuilder.Entity<ClaimTrackType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("claim_track_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.TrackTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("track_type_nm");

                entity.Property(e => e.TrackTypeNmbr).HasColumnName("track_type_nmbr");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("client");

                entity.HasIndex(e => e.ClientNmbr, "_dta_index_client_9_1819153526__K1_2_6");

                entity.HasIndex(e => e.ClientNmbr, "xclient");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.ClientNmbrOpf).HasColumnName("client_nmbr_opf");

                entity.Property(e => e.DobPlace)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("dob_place");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_addr");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.IdentityNmbr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("identity_nmbr");

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaidenNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("maiden_nm");

                entity.Property(e => e.MaritalStatusNmbr).HasColumnName("marital_status_nmbr");

                entity.Property(e => e.Path)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<ClientAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddrTypeNmbr, e.ClientNmbr, e.IndGrpCd })
                    .HasName("PK__client_address__094B159D")
                    .IsClustered(false);

                entity.ToTable("client_address");

                entity.HasIndex(e => e.ClientNmbr, "xclient_address");

                entity.Property(e => e.AddrTypeNmbr).HasColumnName("addr_type_nmbr");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.IndGrpCd).HasColumnName("ind_grp_cd");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PostalCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postal_cd");

                entity.Property(e => e.ProvinceNmbr).HasColumnName("province_nmbr");

                entity.HasOne(d => d.AddrTypeNmbrNavigation)
                    .WithMany(p => p.ClientAddresses)
                    .HasForeignKey(d => d.AddrTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__client_ad__addr___0BF2781E");

                entity.HasOne(d => d.ProvinceNmbrNavigation)
                    .WithMany(p => p.ClientAddresses)
                    .HasForeignKey(d => d.ProvinceNmbr)
                    .HasConstraintName("FK_client_address_province");
            });

            modelBuilder.Entity<ClientPhone>(entity =>
            {
                entity.HasKey(e => new { e.PhoneTypeNmbr, e.ClientNmbr, e.IndGrpCd })
                    .HasName("PK__client_phone__0B335E0F")
                    .IsClustered(false);

                entity.ToTable("client_phone");

                entity.Property(e => e.PhoneTypeNmbr).HasColumnName("phone_type_nmbr");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.IndGrpCd).HasColumnName("ind_grp_cd");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PhoneNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone_nmbr");

                entity.HasOne(d => d.PhoneTypeNmbrNavigation)
                    .WithMany(p => p.ClientPhones)
                    .HasForeignKey(d => d.PhoneTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__client_ph__phone__0CE69C57");
            });

            modelBuilder.Entity<CoiType>(entity =>
            {
                entity.HasKey(e => e.CoiTypeNmbr);

                entity.ToTable("coi_type");

                entity.Property(e => e.CoiTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("coi_type_nmbr");

                entity.Property(e => e.CoiTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("coi_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<CoiTypeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("coi_type_rate");

                entity.Property(e => e.CoiAge).HasColumnName("coi_age");

                entity.Property(e => e.CoiAmount).HasColumnName("coi_amount");

                entity.Property(e => e.CoiRate).HasColumnName("coi_rate");

                entity.Property(e => e.CoiTypeNmbr).HasColumnName("coi_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<CommRltnType>(entity =>
            {
                entity.HasKey(e => e.CommRltnTypeNmbr);

                entity.ToTable("comm_rltn_type");

                entity.Property(e => e.CommRltnTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("comm_rltn_type_nmbr");

                entity.Property(e => e.CommRltnTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("comm_rltn_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<CommTitleType>(entity =>
            {
                entity.HasKey(e => e.TitleTypeNmbr);

                entity.ToTable("comm_title_type");

                entity.Property(e => e.TitleTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("title_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.TitleTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title_type_nm");
            });

            modelBuilder.Entity<CommisionType>(entity =>
            {
                entity.HasKey(e => e.CommisionTypeNmbr);

                entity.ToTable("commision_type");

                entity.Property(e => e.CommisionTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("commision_type_nmbr");

                entity.Property(e => e.CommisionTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("commision_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<CommissionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("commission_type");

                entity.Property(e => e.CommisionNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("commision_nm");

                entity.Property(e => e.CommisionType).HasColumnName("commision_type");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.ClientNmbr)
                    .HasName("PK__company__1A75A19F");

                entity.ToTable("company");

                entity.HasIndex(e => e.ClientNmbr, "xcompany");

                entity.Property(e => e.ClientNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("client_nmbr");

                entity.Property(e => e.AccountNm)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("Account_nm");

                entity.Property(e => e.AccountNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Account_nmbr");

                entity.Property(e => e.AdArt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad_art");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_nm");

                entity.Property(e => e.BusinessLineNmbr).HasColumnName("business_line_nmbr");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_person");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.HasPaycenter).HasColumnName("has_paycenter");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MnySrcType).HasColumnName("Mny_src_type");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NPWP");

                entity.Property(e => e.OldClientNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_client_nmbr");

                entity.Property(e => e.PayorNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Payor_nm");

                entity.Property(e => e.PdpFlg).HasColumnName("pdp_flg");

                entity.Property(e => e.Siup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SIUP");
                /*
                                entity.HasMany(e => e.OptionTypeNm)
                               .WithMany()
                               .UsingEntity<Dictionary<string, object>>(
                                   "CompanyOptionTypes",
                                   j => j
                                       .HasOne<OptionType>()
                                       .WithMany()
                                       .HasForeignKey("OptionTypeNmbr"),
                                   j => j
                                       .HasOne<Company>()
                                       .WithMany()
                                       .HasForeignKey("ClientNmbr"));*/
            });

            modelBuilder.Entity<ContribDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contrib_detail");

                entity.HasIndex(e => new { e.CntrbSeqNmbr, e.GroupNmbr }, "IX_contrib_detail_missing_129");

                entity.HasIndex(e => new { e.CntrbSeqNmbr, e.CerNmbr, e.MoneyTypeNmbr }, "IX_contrib_detail_missing_6117");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbDtlSeqNmbr).HasColumnName("cntrb_dtl_seq_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");
            });

            modelBuilder.Entity<ContribDetailGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contrib_detail_group");

                entity.Property(e => e.Bulan).HasMaxLength(255);

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");
            });

            modelBuilder.Entity<ContribDetailTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contrib_detail_temp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbDtlSeqNmbr).HasColumnName("cntrb_dtl_seq_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");
            });

            modelBuilder.Entity<ContribReq>(entity =>
            {
                entity.HasKey(e => new { e.CntrbSeqNmbr, e.GroupNmbr })
                    .HasName("PK__contrib_req__1E463283");

                entity.ToTable("contrib_req");

                entity.HasIndex(e => e.GroupNmbr, "IX_contrib_req_missing_303");

                entity.HasIndex(e => e.GroupNmbr, "IX_contrib_req_missing_32");

                entity.HasIndex(e => new { e.ReversalDt, e.PaidDt, e.PaidAmt }, "IX_contrib_req_missing_47");

                entity.HasIndex(e => new { e.CntrbSeqNmbr, e.GroupNmbr, e.CntrbEfctvDt, e.CntrbRunDt, e.ReversalDt, e.CreateDt, e.ReceivedDt }, "xContrib_req");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cntrb_efctv_dt");

                entity.Property(e => e.CntrbRunDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cntrb_run_dt");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.LapseSts).HasColumnName("lapse_sts");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.PaycenterNmbr)
                    .HasColumnName("paycenter_nmbr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("received_dt");

                entity.Property(e => e.ReversalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversal_dt");

                entity.Property(e => e.SuspenseUseCd).HasColumnName("suspense_use_cd");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithMany(p => p.ContribReqs)
                    .HasForeignKey(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__contrib_r__group__16700691");
            });

            modelBuilder.Entity<CopyOfCycleCertificateCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CopyOf_cycle_certificate_charge");

                entity.Property(e => e.AssetAmt).HasColumnName("asset_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.DeductedAmt).HasColumnName("deducted_amt");

                entity.Property(e => e.DeductedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deducted_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChargeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_charge_dt");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CopyofSpdIuranInvestasiByperson>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("copyof_SPD_IURAN_INVESTASI_BYPERSON");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntrb).HasColumnName("tu_cntrb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.Wd).HasColumnName("wd");
            });

            modelBuilder.Entity<CopyofTrnsHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("copyof_trns_hst");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<CopyofTrnsHstInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("copyof_trns_hst_inv");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasKey(e => e.CounterNmbr)
                    .HasName("PK__counter__202E7AF5")
                    .IsClustered(false);

                entity.ToTable("counter");

                entity.Property(e => e.CounterNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("counter_nmbr");

                entity.Property(e => e.CounterNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("counter_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.LastNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_nmbr");
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("credit_card");

                entity.Property(e => e.BankTypeNmbr).HasColumnName("bank_type_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CreditCardNmbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("credit_card_nmbr");

                entity.Property(e => e.CreditCardTypeNmbr).HasColumnName("credit_card_type_nmbr");

                entity.Property(e => e.ExpireDt)
                    .HasColumnType("datetime")
                    .HasColumnName("expire_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<CreditCardType>(entity =>
            {
                entity.HasKey(e => e.CreditCardTypeNmbr);

                entity.ToTable("credit_card_type");

                entity.Property(e => e.CreditCardTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("credit_card_type_nmbr");

                entity.Property(e => e.CreditCardNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("credit_card_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<Cteviewaccumulatedunit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CTEVIEWACCUMULATEDUNIT");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CreditPost).HasColumnName("credit_post");

                entity.Property(e => e.DebetPost).HasColumnName("debet_post");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.Rownum).HasColumnName("rownum");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.Sumunit).HasColumnName("sumunit");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<CurrencyType>(entity =>
            {
                entity.HasKey(e => e.CurrencyTypeNmbr)
                    .HasName("PK_currenct_type");

                entity.ToTable("currency_type");

                entity.Property(e => e.CurrencyTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("currency_type_nmbr");

                entity.Property(e => e.CurrencyTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("currency_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<Cycle>(entity =>
            {
                entity.HasKey(e => new { e.CycleDt, e.CycleFlg })
                    .HasName("PK__cycle__23FF0BD9")
                    .IsClustered(false);

                entity.ToTable("cycle");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.CycleFlg).HasColumnName("cycle_flg");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<CycleCertificateCharge>(entity =>
            {
                entity.HasKey(e => new { e.CycleDt, e.GroupNmbr, e.CerNmbr, e.ChargeTypeNmbr });

                entity.ToTable("cycle_certificate_charge");

                entity.HasIndex(e => new { e.CerNmbr, e.ChargeTypeNmbr, e.DeductedDt }, "IX_cycle_certificate_charge_missing_198");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.AssetAmt).HasColumnName("asset_amt");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.DeductedAmt).HasColumnName("deducted_amt");

                entity.Property(e => e.DeductedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deducted_dt");

                entity.Property(e => e.LastChargeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_charge_dt");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<CycleCertificateChargeAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.InvTypeNmbr, e.FeePeriodStart, e.FeePeriodEnd });

                entity.ToTable("cycle_certificate_charge_adjustment");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.FeePeriodStart)
                    .HasColumnType("datetime")
                    .HasColumnName("fee_period_start");

                entity.Property(e => e.FeePeriodEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("fee_period_end");

                entity.Property(e => e.AdjAmt).HasColumnName("adj_amt");

                entity.Property(e => e.DeductedAmt).HasColumnName("deducted_amt");

                entity.Property(e => e.DeductedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deducted_dt");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<CycleCertificateCoi>(entity =>
            {
                entity.HasKey(e => new { e.ChargeTypeNmbr, e.BeneTypeNmbr, e.CerNmbr, e.EfctvDt });

                entity.ToTable("cycle_certificate_coi");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.CoiAmt).HasColumnName("coi_amt");

                entity.Property(e => e.DeductedAmt).HasColumnName("deducted_amt");

                entity.Property(e => e.DeductedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deducted_dt");

                entity.Property(e => e.DiscontAmt).HasColumnName("discont_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.LoadingAmt).HasColumnName("loading_amt");

                entity.Property(e => e.SumInsuredAmt).HasColumnName("sum_insured_amt");
            });

            modelBuilder.Entity<CycleProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cycle_process");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.CycleId).HasColumnName("cycle_id");

                entity.Property(e => e.ErrorDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("error_desc");

                entity.Property(e => e.ProcessDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("process_desc");

                entity.Property(e => e.ProcessFlg)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("process_flg");
            });

            modelBuilder.Entity<DataPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataPeserta$");

                entity.Property(e => e.Agama).HasMaxLength(255);

                entity.Property(e => e.AlamatKtp)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_KTP");

                entity.Property(e => e.AlamatPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Perusahaan");

                entity.Property(e => e.AlamatRumah)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Rumah");

                entity.Property(e => e.AnakKe)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke");

                entity.Property(e => e.AnakKe1)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke1");

                entity.Property(e => e.AnakKe2)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke2");

                entity.Property(e => e.BlmNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Blm_Nikah");

                entity.Property(e => e.CabangUnit)
                    .HasMaxLength(255)
                    .HasColumnName("Cabang/Unit");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Hubungan).HasMaxLength(255);

                entity.Property(e => e.Hubungan1).HasMaxLength(255);

                entity.Property(e => e.IuranKaryawan).HasColumnName("Iuran_Karyawan");

                entity.Property(e => e.IuranPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Iuran_Perusahaan");

                entity.Property(e => e.JandaDuda)
                    .HasMaxLength(255)
                    .HasColumnName("Janda/Duda");

                entity.Property(e => e.JumlahAnak)
                    .HasMaxLength(255)
                    .HasColumnName("Jumlah_Anak");

                entity.Property(e => e.KodePos1)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos1");

                entity.Property(e => e.KodePos2)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos2");

                entity.Property(e => e.KodePosPerusahaan).HasColumnName("Kode_Pos_Perusahaan");

                entity.Property(e => e.NamAnak1)
                    .HasMaxLength(255)
                    .HasColumnName("Nam_Anak_1");

                entity.Property(e => e.NamAnak2)
                    .HasMaxLength(255)
                    .HasColumnName("Nam_Anak_2");

                entity.Property(e => e.NamAnak3)
                    .HasMaxLength(255)
                    .HasColumnName("Nam_Anak_3");

                entity.Property(e => e.NamaAhliWarisBelumMenikah)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ahli_Waris_Belum_Menikah");

                entity.Property(e => e.NamaIbuKandung)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ibu_Kandung");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Peserta");

                entity.Property(e => e.NamaSuamiIstri)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Suami_Istri");

                entity.Property(e => e.Nikah).HasMaxLength(255);

                entity.Property(e => e.NoKtpSim)
                    .HasMaxLength(255)
                    .HasColumnName("No_KTP/SIM");

                entity.Property(e => e.NoPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("No_peserta");

                entity.Property(e => e.NoTelpRumah)
                    .HasMaxLength(255)
                    .HasColumnName("No_Telp_Rumah");

                entity.Property(e => e.NomorHp)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor_HP");

                entity.Property(e => e.NpwpPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Perusahaan");

                entity.Property(e => e.NpwpPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Peserta");

                entity.Property(e => e.PilihanInvestasi1).HasColumnName("Pilihan_Investasi_1");

                entity.Property(e => e.PilihanInvestasi2).HasColumnName("Pilihan_Investasi_2");

                entity.Property(e => e.PilihanInvestasi3).HasColumnName("Pilihan_Investasi_3");

                entity.Property(e => e.PilihanInvestasi4)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_4");

                entity.Property(e => e.PilihanInvestasi5)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_5");

                entity.Property(e => e.PilihanInvestasi6)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_6");

                entity.Property(e => e.TanggalLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir");

                entity.Property(e => e.TanggalLahir1)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Lahir1");

                entity.Property(e => e.TanggalLahir2)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Lahir2");

                entity.Property(e => e.TanggalLahir3)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Lahir3");

                entity.Property(e => e.TanggalLahir4)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Lahir4");

                entity.Property(e => e.TanggalLahir5)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Lahir5");

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(255)
                    .HasColumnName("Tempat_Lahir");

                entity.Property(e => e.TtdPerusahaanOleh)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Perusahaan_Oleh");

                entity.Property(e => e.TtdPerusahaanTanggal)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Perusahaan_Tanggal");

                entity.Property(e => e.TtdPesertaOleh)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Peserta_Oleh");

                entity.Property(e => e.TtdPesertaTanggal)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Peserta_Tanggal");

                entity.Property(e => e.UsiaPensiun).HasColumnName("Usia_Pensiun");
            });

            modelBuilder.Entity<DatapesertaTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("datapeserta_temp");

                entity.Property(e => e.Agama).HasMaxLength(255);

                entity.Property(e => e.AlamatKtp)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_KTP");

                entity.Property(e => e.AlamatPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Perusahaan");

                entity.Property(e => e.AlamatRumah)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Rumah");

                entity.Property(e => e.AnakKe1)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke_1");

                entity.Property(e => e.AnakKe2)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke_2");

                entity.Property(e => e.AnakKe3)
                    .HasMaxLength(255)
                    .HasColumnName("Anak_Ke_3");

                entity.Property(e => e.BlmNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Blm_Nikah");

                entity.Property(e => e.BulanLahir).HasColumnName("Bulan_Lahir");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Hubungan).HasMaxLength(255);

                entity.Property(e => e.HubunganAhliWaris)
                    .HasMaxLength(255)
                    .HasColumnName("Hubungan_Ahli_Waris");

                entity.Property(e => e.IuranKaryawan)
                    .HasMaxLength(255)
                    .HasColumnName("Iuran_Karyawan");

                entity.Property(e => e.IuranPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Iuran_Perusahaan");

                entity.Property(e => e.JandaDuda)
                    .HasMaxLength(255)
                    .HasColumnName("Janda_Duda");

                entity.Property(e => e.JumlahAnak)
                    .HasMaxLength(255)
                    .HasColumnName("Jumlah_Anak");

                entity.Property(e => e.KodePos1)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos1");

                entity.Property(e => e.KodePos2)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos2");

                entity.Property(e => e.KodePosPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos_Perusahaan");

                entity.Property(e => e.NamaAhliWarisBelumMenikah)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ahli_Waris_Belum_Menikah");

                entity.Property(e => e.NamaAnak1)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Anak_1");

                entity.Property(e => e.NamaAnak2)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Anak_2");

                entity.Property(e => e.NamaAnak3)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Anak_3");

                entity.Property(e => e.NamaIbuKandung)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ibu_Kandung");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Peserta");

                entity.Property(e => e.NamaSuamiIstri)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Suami_Istri");

                entity.Property(e => e.Nikah).HasMaxLength(255);

                entity.Property(e => e.NoKtpSim)
                    .HasMaxLength(255)
                    .HasColumnName("No_KTP_SIM");

                entity.Property(e => e.NoPeserta)
                    .HasMaxLength(50)
                    .HasColumnName("No_peserta");

                entity.Property(e => e.NoTelpRumah)
                    .HasMaxLength(255)
                    .HasColumnName("No_Telp_Rumah");

                entity.Property(e => e.NomorHp)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor_HP");

                entity.Property(e => e.NpwpPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Perusahaan");

                entity.Property(e => e.NpwpPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Peserta");

                entity.Property(e => e.PilihanInvestasi1)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_1");

                entity.Property(e => e.PilihanInvestasi2)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_2");

                entity.Property(e => e.PilihanInvestasi3)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_3");

                entity.Property(e => e.PilihanInvestasi4)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_4");

                entity.Property(e => e.PilihanInvestasi5)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_5");

                entity.Property(e => e.PilihanInvestasi6)
                    .HasMaxLength(255)
                    .HasColumnName("Pilihan_Investasi_6");

                entity.Property(e => e.TahunLahir).HasColumnName("Tahun_Lahir");

                entity.Property(e => e.TanggalLahir).HasColumnName("Tanggal_Lahir");

                entity.Property(e => e.TanggalLahirAhliWaris)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir_Ahli_Waris");

                entity.Property(e => e.TanggalLahirAnak1)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir_Anak_1");

                entity.Property(e => e.TanggalLahirAnak2)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir_Anak_2");

                entity.Property(e => e.TanggalLahirAnak3)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir_Anak_3");

                entity.Property(e => e.TanggalLahirSuamiIstri)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_Lahir_Suami_Istri");

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(255)
                    .HasColumnName("Tempat_Lahir");

                entity.Property(e => e.TopupKaryawan)
                    .HasMaxLength(255)
                    .HasColumnName("Topup_Karyawan");

                entity.Property(e => e.TopupPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Topup_Perusahaan");

                entity.Property(e => e.TtdPerusahaanOleh)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Perusahaan_Oleh");

                entity.Property(e => e.TtdPerusahaanTanggal)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Perusahaan_Tanggal");

                entity.Property(e => e.TtdPesertaOleh)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Peserta_Oleh");

                entity.Property(e => e.TtdPesertaTanggal)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Peserta_Tanggal");

                entity.Property(e => e.UsiaPensiun)
                    .HasMaxLength(255)
                    .HasColumnName("Usia_Pensiun");
            });

            modelBuilder.Entity<DbBank>(entity =>
            {
                entity.HasKey(e => e.SeqNmbr);

                entity.ToTable("db_bank");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.BankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_addr");

                entity.Property(e => e.BankBiNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("bank_bi_nmbr");

                entity.Property(e => e.BankCentral).HasColumnName("bank_central");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.BankNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("bank_nmbr");
            });

            modelBuilder.Entity<Delete20220307Mutasi100>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delete20220307_mutasi100");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<Delete20220307Mutasi400>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("delete20220307_mutasi400");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<DocType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("doc_type");

                entity.Property(e => e.DocTypeNm)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("doc_type_nm");

                entity.Property(e => e.DocTypeNmbr).HasColumnName("doc_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<Double2026670>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOUBLE_2026670");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<DplkRollover>(entity =>
            {
                entity.HasKey(e => e.DplkNmbr);

                entity.ToTable("dplk_rollover");

                entity.Property(e => e.AcctNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("acct_nmbr");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.DplkAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dplk_address1");

                entity.Property(e => e.DplkAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dplk_address2");

                entity.Property(e => e.DplkAddress3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dplk_address3");

                entity.Property(e => e.DplkCity)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dplk_city");

                entity.Property(e => e.DplkContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dplk_contact_person");

                entity.Property(e => e.DplkNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dplk_nm");

                entity.Property(e => e.DplkNmbr).HasColumnName("dplk_nmbr");

                entity.Property(e => e.DplkPostalCd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dplk_postal_cd");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<Dtproperty>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Property })
                    .HasName("pk_dtproperties");

                entity.ToTable("dtproperties");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Property)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("property");

                entity.Property(e => e.Lvalue)
                    .HasColumnType("image")
                    .HasColumnName("lvalue");

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Uvalue)
                    .HasMaxLength(255)
                    .HasColumnName("uvalue");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Exception>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exception");

                entity.Property(e => e.CerNmbr).HasColumnName("Cer_nmbr");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Cycle_dt");

                entity.Property(e => e.ExceptionTypeNmbr).HasColumnName("Exception_type_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("Group_nmbr");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("Sub_trns_nmbr");

                entity.Property(e => e.TrnsType).HasColumnName("Trns_type");
            });

            modelBuilder.Entity<ExceptionType>(entity =>
            {
                entity.HasKey(e => e.ExceptionTypeNmbr)
                    .HasName("PK_Exception_type");

                entity.ToTable("exception_type");

                entity.Property(e => e.ExceptionTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("Exception_type_nmbr");

                entity.Property(e => e.ExceptionTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Exception_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<ExchgRate>(entity =>
            {
                entity.HasKey(e => new { e.InvTypeNmbr, e.EfctvDt })
                    .HasName("PK__exchg_rate__25E7544B")
                    .IsClustered(false);

                entity.ToTable("exchg_rate");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.BuyRt).HasColumnName("buy_rt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SellRt).HasColumnName("sell_rt");

                entity.HasOne(d => d.InvTypeNmbrNavigation)
                    .WithMany(p => p.ExchgRates)
                    .HasForeignKey(d => d.InvTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__exchg_rat__inv_t__18584F03");
            });

            modelBuilder.Entity<FppFlpCdv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fpp_flp_cdv");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.BillCntrbSeq).HasColumnName("bill_cntrb_seq");

                entity.Property(e => e.CdvApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_approval_nm");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CrvApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crv_approval_nm");

                entity.Property(e => e.CrvGeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("crv_generated_dt");

                entity.Property(e => e.CrvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("crv_nmbr");

                entity.Property(e => e.CvdGeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cvd_generated_dt");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dc");

                entity.Property(e => e.FlpApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flp_approval_nm");

                entity.Property(e => e.FlpGeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("flp_generated_dt");

                entity.Property(e => e.FlpNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flp_nmbr");

                entity.Property(e => e.FppApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fpp_approval_nm");

                entity.Property(e => e.FppGeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("fpp_generated_dt");

                entity.Property(e => e.FppNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fpp_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.JurnalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jurnal_code");

                entity.Property(e => e.JurnalNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("jurnal_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<FrequencyType>(entity =>
            {
                entity.HasKey(e => e.FreqTypeNmbr)
                    .HasName("PK__frequency_type__27CF9CBD")
                    .IsClustered(false);

                entity.ToTable("frequency_type");

                entity.Property(e => e.FreqTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("freq_type_nmbr");

                entity.Property(e => e.FreqTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("freq_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<FundMvntComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fund_mvnt_comp");

                entity.HasIndex(e => new { e.CerNmbr, e.EfctvDt, e.InvTypeNmbr }, "IX_fund_mvnt_comp_missing_932");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CompositionPct).HasColumnName("composition_pct");

                entity.Property(e => e.CurrentAsset).HasColumnName("current_asset");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NewAsset).HasColumnName("new_asset");
            });

            modelBuilder.Entity<FundMvntEst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fund_mvnt_est");

                entity.HasIndex(e => new { e.EfctvDt, e.ApproveFlg }, "IX_fund_mvnt_est_missing_372");

                entity.HasIndex(e => new { e.ProcessedDt, e.ApproveFlg }, "IX_fund_mvnt_est_missing_76");

                entity.HasIndex(e => new { e.CerNmbr, e.EfctvDt, e.MoneyTypeNmbr }, "xFund_mvnt_est");

                entity.Property(e => e.ApproveFlg).HasColumnName("approve_flg");

                entity.Property(e => e.BatchId).HasColumnName("batchID");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.DocRecvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("doc_recv_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeDst).HasColumnName("inv_type_dst");

                entity.Property(e => e.InvTypeSrc).HasColumnName("inv_type_src");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("processed_by");

                entity.Property(e => e.ProcessedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("processed_dt");
            });

            modelBuilder.Entity<FundMvntEstTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fund_mvnt_est_tmp");

                entity.Property(e => e.ApproveFlg).HasColumnName("approve_flg");

                entity.Property(e => e.BatchId).HasColumnName("batchID");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.DocRecvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("doc_recv_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeDst).HasColumnName("inv_type_dst");

                entity.Property(e => e.InvTypeSrc).HasColumnName("inv_type_src");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.ProcessedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("processed_dt");
            });

            modelBuilder.Entity<FundSrcType>(entity =>
            {
                entity.HasKey(e => e.FundSrcNmbr);

                entity.ToTable("fund_src_type");

                entity.Property(e => e.FundSrcNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("fund_src_nmbr");

                entity.Property(e => e.FundSrcNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("fund_src_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<GroupBeneSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_bene_setup");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.CoiDiscontFlg).HasColumnName("coi_discont_flg");

                entity.Property(e => e.CoiDiscontValue).HasColumnName("coi_discont_value");

                entity.Property(e => e.CoiLoadingFlg).HasColumnName("coi_loading_flg");

                entity.Property(e => e.CoiLoadingValue).HasColumnName("coi_loading_value");

                entity.Property(e => e.CoiTypeNmbr).HasColumnName("coi_type_nmbr");

                entity.Property(e => e.DefaultSumInsured).HasColumnName("default_sum_insured");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxCovAge).HasColumnName("max_cov_age");

                entity.Property(e => e.MaxEntryAge).HasColumnName("max_entry_age");

                entity.Property(e => e.MaxSumInsured).HasColumnName("max_sum_insured");

                entity.Property(e => e.McpTypeNmbr).HasColumnName("mcp_type_nmbr");

                entity.Property(e => e.SiCalcTypeNmbr).HasColumnName("si_calc_type_nmbr");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");
            });

            modelBuilder.Entity<GroupCharge>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr })
                    .HasName("PK__group_charge__29B7E52F");

                entity.ToTable("group_charge");

                entity.HasIndex(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr, e.ChargeEfctvDt }, "xgroup_charge");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.MainChrgSeqNmbr).HasColumnName("main_chrg_seq_nmbr");

                entity.Property(e => e.ChargeEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("charge_efctv_dt");

                entity.Property(e => e.ChargeTrmntnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("charge_trmntn_dt");

                entity.Property(e => e.FreqTypeNmbr).HasColumnName("freq_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NextChargeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("next_charge_dt");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.HasOne(d => d.ChargeTypeNmbrNavigation)
                    .WithMany(p => p.GroupCharges)
                    .HasForeignKey(d => d.ChargeTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__group_cha__charg__1B34BBAE");

                entity.HasOne(d => d.FreqTypeNmbrNavigation)
                    .WithMany(p => p.GroupCharges)
                    .HasForeignKey(d => d.FreqTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__group_cha__freq___194C733C");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithMany(p => p.GroupCharges)
                    .HasForeignKey(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__group_cha__group__1C28DFE7");

                entity.HasOne(d => d.PayRspnNmbrNavigation)
                    .WithMany(p => p.GroupCharges)
                    .HasForeignKey(d => d.PayRspnNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__group_cha__pay_r__1A409775");
            });

            modelBuilder.Entity<GroupCommissionFlg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_commission_flg");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Tahun).HasColumnName("tahun");
            });

            modelBuilder.Entity<GroupInfo>(entity =>
            {
                entity.HasKey(e => e.GroupNmbr)
                    .HasName("PK__group_info__2BA02DA1");

                entity.ToTable("group_info");

                entity.HasIndex(e => new { e.GroupNmbr, e.EfctvDt, e.ClientNmbr }, "xgroup_info");

                entity.Property(e => e.GroupNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("group_nmbr");

                entity.Property(e => e.AccbalFreqNmbr).HasColumnName("accbal_freq_nmbr");

                entity.Property(e => e.AccbalLstprnDt)
                    .HasColumnType("datetime")
                    .HasColumnName("accbal_lstprn_dt");

                entity.Property(e => e.AffiliatedTo).HasColumnName("affiliatedTo");

                entity.Property(e => e.AgentNmbr).HasColumnName("agent_nmbr");

                entity.Property(e => e.AllowWithNmbr).HasColumnName("allow_with_nmbr");

                entity.Property(e => e.AnlMaxWithFreq).HasColumnName("anl_max_with_freq");

                entity.Property(e => e.BackdatedEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("backdated_efctv_dt");

                entity.Property(e => e.BillPayctrOpt).HasColumnName("bill_payctr_opt");

                entity.Property(e => e.CaseCloseDt)
                    .HasColumnType("datetime")
                    .HasColumnName("case_close_dt");

                entity.Property(e => e.ClaimProcessDay).HasColumnName("claim_process_day");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.CommisionFlg).HasColumnName("commision_flg");

                entity.Property(e => e.CommisionType).HasColumnName("commision_type");

                entity.Property(e => e.CompletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("completed_dt");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.EarlyRetireAge).HasColumnName("early_retire_age");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.HavePsl).HasColumnName("have_psl");

                entity.Property(e => e.InclContribFlg).HasColumnName("incl_contrib_flg");

                entity.Property(e => e.IndGrpCd).HasColumnName("ind_grp_cd");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MailAddrOpt).HasColumnName("mail_addr_opt");

                entity.Property(e => e.MaturityTypeNmbr).HasColumnName("maturity_type_nmbr");

                entity.Property(e => e.MaturityVal)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("maturity_val");

                entity.Property(e => e.MaxCntrbAmt).HasColumnName("max_cntrb_amt");

                entity.Property(e => e.MaxWithPrct).HasColumnName("max_with_prct");

                entity.Property(e => e.MinAnnuityAmt).HasColumnName("min_annuity_amt");

                entity.Property(e => e.MinAnnuityPrct).HasColumnName("min_annuity_prct");

                entity.Property(e => e.MinCntrbAmt).HasColumnName("min_cntrb_amt");

                entity.Property(e => e.MinWithAmt).HasColumnName("min_with_amt");

                entity.Property(e => e.MinYrForWith).HasColumnName("min_yr_for_with");

                entity.Property(e => e.MppTerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("mpp_termination_dt");

                entity.Property(e => e.NormalRetireAge).HasColumnName("normal_retire_age");

                entity.Property(e => e.OldGrpNmbr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("old_grp_nmbr");

                entity.Property(e => e.PooledFlg).HasColumnName("pooled_flg");

                entity.Property(e => e.PremiumMtdType)
                    .HasColumnName("premium_mtd_type")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProductType).HasColumnName("product_type");

                entity.Property(e => e.ProrateFeeFlg).HasColumnName("prorate_fee_flg");

                entity.Property(e => e.PslPaymentFreq).HasColumnName("psl_payment_freq");

                entity.Property(e => e.PslType).HasColumnName("psl_type");

                entity.Property(e => e.SpakRecvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("SPAK_recv_dt");

                entity.Property(e => e.SupportUu1992).HasColumnName("Support_UU1992");

                entity.Property(e => e.TerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("termination_dt");

                entity.Property(e => e.VaCurrencyNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("va_currency_nmbr");

                entity.Property(e => e.VaDplkNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("va_dplk_nmbr");

                entity.Property(e => e.WithSrcTypeNmbr).HasColumnName("with_src_type_nmbr");

                entity.Property(e => e.WithYear).HasColumnName("with_year");
            });

            modelBuilder.Entity<GroupPic>(entity =>
            {
                entity.HasKey(e => e.KdPic)
                    .HasName("PK__group_pi__A6F6F0C01FAE8CB1");

                entity.ToTable("group_pic");

                entity.Property(e => e.KdPic)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("kd_pic");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Jabatan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jabatan");

                entity.Property(e => e.NamaPic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_pic");

                entity.Property(e => e.Title)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<GroupTax>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.TaxTypeNmbr, e.MainTaxSeqNmbr });

                entity.ToTable("group_tax");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.TaxTypeNmbr).HasColumnName("tax_type_nmbr");

                entity.Property(e => e.MainTaxSeqNmbr).HasColumnName("main_tax_seq_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.TaxEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("tax_efctv_dt");
            });

            modelBuilder.Entity<GrpChargeInvRt>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr, e.InvTypeNmbr })
                    .HasName("PK__grp_charge_inv_r__315906F7")
                    .IsClustered(false);

                entity.ToTable("grp_charge_inv_rt");

                entity.HasIndex(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr, e.InvTypeNmbr }, "xgrp_charge_inv_rt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.MainChrgSeqNmbr).HasColumnName("main_chrg_seq_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.BillPct).HasColumnName("bill_pct");

                entity.Property(e => e.ChargeAmt)
                    .HasColumnName("charge_amt")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.ChargeRt)
                    .HasColumnName("charge_rt")
                    .HasDefaultValueSql("(null)");

                entity.Property(e => e.DeductPct).HasColumnName("deduct_pct");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.HasOne(d => d.InvTypeNmbrNavigation)
                    .WithMany(p => p.GrpChargeInvRts)
                    .HasForeignKey(d => d.InvTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__grp_charg__inv_t__1FF970CB");

                entity.HasOne(d => d.GroupCharge)
                    .WithMany(p => p.GrpChargeInvRts)
                    .HasForeignKey(d => new { d.GroupNmbr, d.ChargeTypeNmbr, d.MainChrgSeqNmbr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_grp_charge_inv_rt_group_charge");
            });

            modelBuilder.Entity<GrpChargeRt>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr, e.ChargeSeqNmbr })
                    .HasName("PK__grp_charge_rt__33414F69");

                entity.ToTable("grp_charge_rt");

                entity.HasIndex(e => new { e.GroupNmbr, e.ChargeTypeNmbr, e.MainChrgSeqNmbr, e.ChargeSeqNmbr }, "xgrp_charge_rt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.MainChrgSeqNmbr).HasColumnName("main_chrg_seq_nmbr");

                entity.Property(e => e.ChargeSeqNmbr).HasColumnName("charge_seq_nmbr");

                entity.Property(e => e.BegPrd).HasColumnName("beg_prd");

                entity.Property(e => e.BillPct).HasColumnName("bill_pct");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.ChargeRt).HasColumnName("charge_rt");

                entity.Property(e => e.DeductPct).HasColumnName("deduct_pct");

                entity.Property(e => e.EndPrd).HasColumnName("end_prd");

                entity.Property(e => e.FreeCnt).HasColumnName("free_cnt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxChargeAmt).HasColumnName("max_charge_amt");

                entity.Property(e => e.MaxCnt).HasColumnName("max_cnt");

                entity.HasOne(d => d.GroupCharge)
                    .WithMany(p => p.GrpChargeRts)
                    .HasForeignKey(d => new { d.GroupNmbr, d.ChargeTypeNmbr, d.MainChrgSeqNmbr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_grp_charge_rt_group_charge");
            });

            modelBuilder.Entity<GrpInvDrct>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.InvTypeNmbr })
                    .HasName("PK__grp_inv_drct__352997DB")
                    .IsClustered(false);

                entity.ToTable("grp_inv_drct");

                entity.HasIndex(e => new { e.GroupNmbr, e.InvTypeNmbr }, "xgrp_inv_drct");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxPercent).HasColumnName("max_percent");

                entity.Property(e => e.MinPercent).HasColumnName("min_percent");

                entity.HasOne(d => d.InvTypeNmbrNavigation)
                    .WithMany(p => p.GrpInvDrcts)
                    .HasForeignKey(d => d.InvTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__grp_inv_d__inv_t__22D5DD76");
            });

            modelBuilder.Entity<GrpVestDtl>(entity =>
            {
                entity.HasKey(e => new { e.GrpSeqNmbr, e.GroupNmbr, e.SeqNmbr });

                entity.ToTable("grp_vest_dtl");

                entity.Property(e => e.GrpSeqNmbr).HasColumnName("grp_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.BegYop).HasColumnName("beg_yop");

                entity.Property(e => e.BegYos).HasColumnName("beg_yos");

                entity.Property(e => e.DeathFlg).HasColumnName("death_flg");

                entity.Property(e => e.EndYop).HasColumnName("end_yop");

                entity.Property(e => e.EndYos).HasColumnName("end_yos");

                entity.Property(e => e.JobLvlNmbr).HasColumnName("job_lvl_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.VestSchPct).HasColumnName("vest_sch_pct");

                entity.HasOne(d => d.Gr)
                    .WithMany(p => p.GrpVestDtls)
                    .HasForeignKey(d => new { d.GrpSeqNmbr, d.GroupNmbr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_grp_vest_dtl_grp_vest_sch");
            });

            modelBuilder.Entity<GrpVestSch>(entity =>
            {
                entity.HasKey(e => new { e.GrpSeqNmbr, e.GroupNmbr });

                entity.ToTable("grp_vest_sch");

                entity.Property(e => e.GrpSeqNmbr).HasColumnName("grp_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("Group_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.VestSchDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vest_sch_desc");

                entity.Property(e => e.VestSchNmbr).HasColumnName("vest_sch_nmbr");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithMany(p => p.GrpVestSches)
                    .HasForeignKey(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_grp_vest_sch_group_info");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("holiday");

                entity.Property(e => e.Comment)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.HolidayDt)
                    .HasColumnType("datetime")
                    .HasColumnName("holiday_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<HtrnsHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("htrns_hst");

                entity.HasIndex(e => new { e.CerNmbr, e.EfctvDt }, "IX_htrns_hst_missing_48");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.OldCerNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_cer_nmbr");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsTypeNm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nm");
            });

            modelBuilder.Entity<IchaPetrochina>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("icha_petrochina$");

                entity.Property(e => e.AnuitasAccntNmbr)
                    .HasMaxLength(255)
                    .HasColumnName("anuitas_accnt_nmbr");

                entity.Property(e => e.AnuitasAcctNm)
                    .HasMaxLength(255)
                    .HasColumnName("anuitas_acct_nm");

                entity.Property(e => e.AnuitasAmt)
                    .HasColumnType("money")
                    .HasColumnName("anuitas_amt");

                entity.Property(e => e.AnuitasBankNm)
                    .HasMaxLength(255)
                    .HasColumnName("anuitas_bank_nm");

                entity.Property(e => e.JmlFee)
                    .HasColumnType("money")
                    .HasColumnName("jml_fee");

                entity.Property(e => e.JmlGross)
                    .HasColumnType("money")
                    .HasColumnName("jml_gross");

                entity.Property(e => e.JmlNet)
                    .HasColumnType("money")
                    .HasColumnName("jml_net");

                entity.Property(e => e.JmlTax)
                    .HasColumnType("money")
                    .HasColumnName("jml_tax");

                entity.Property(e => e.LumpsumAccntNmbr)
                    .HasMaxLength(255)
                    .HasColumnName("lumpsum_accnt_nmbr");

                entity.Property(e => e.LumpsumAcctNm)
                    .HasMaxLength(255)
                    .HasColumnName("lumpsum_acct_nm");

                entity.Property(e => e.LumpsumAmt)
                    .HasColumnType("money")
                    .HasColumnName("lumpsum_amt");

                entity.Property(e => e.LumpsumBankNm)
                    .HasMaxLength(255)
                    .HasColumnName("lumpsum_bank_nm");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NoPegawai)
                    .HasMaxLength(255)
                    .HasColumnName("no_pegawai");

                entity.Property(e => e.NoPeserta).HasColumnName("no_peserta");

                entity.Property(e => e.TglLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_lahir");
            });

            modelBuilder.Entity<IdType>(entity =>
            {
                entity.HasKey(e => e.IdentityType)
                    .HasName("PK__id_type__4C6B5938")
                    .IsClustered(false);

                entity.ToTable("id_type");

                entity.Property(e => e.IdentityType)
                    .ValueGeneratedNever()
                    .HasColumnName("identity_type");

                entity.Property(e => e.IdentityNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identity_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<IkptHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ikpt_hist");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<IndeksPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("indeks_price");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.PriceHsbc).HasColumnName("price_hsbc");

                entity.Property(e => e.PriceIcbi).HasColumnName("price_icbi");

                entity.Property(e => e.PriceIgbi).HasColumnName("price_igbi");

                entity.Property(e => e.PriceIhsg).HasColumnName("price_ihsg");
            });

            modelBuilder.Entity<IndividualCommissionFlg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("individual_commission_flg");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.Flag).HasColumnName("flag");
            });

            modelBuilder.Entity<InfoKeuPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("info_keu_peserta");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.Contrib).HasColumnName("contrib");

                entity.Property(e => e.Distrib).HasColumnName("distrib");

                entity.Property(e => e.Earning).HasColumnName("earning");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.InvType).HasColumnName("inv_type");

                entity.Property(e => e.MoneyType).HasColumnName("money_type");

                entity.Property(e => e.NetContrib).HasColumnName("net_contrib");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<InvRedempInfo>(entity =>
            {
                entity.HasKey(e => e.InvTypeNmbr);

                entity.ToTable("inv_redemp_info");

                entity.Property(e => e.InvTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("inv_type_nmbr");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.BankAccNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_acc_nm");

                entity.Property(e => e.BankAccNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_acc_nmbr");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");

                entity.Property(e => e.PicPost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_post");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postal_code");
            });

            modelBuilder.Entity<InvSahat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inv_sahat");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<InvType>(entity =>
            {
                entity.HasKey(e => e.InvTypeNmbr)
                    .HasName("PK__inv_type__38FA28BF")
                    .IsClustered(false);

                entity.ToTable("inv_type");

                entity.Property(e => e.InvTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("inv_type_nmbr");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.InvTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldInvType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_inv_type");
            });

            modelBuilder.Entity<JobLvlType>(entity =>
            {
                entity.HasKey(e => e.JobLvlNmbr);

                entity.ToTable("job_lvl_type");

                entity.Property(e => e.JobLvlNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("job_lvl_nmbr");

                entity.Property(e => e.JobLvlNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Job_lvl_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<JobVctnType>(entity =>
            {
                entity.HasKey(e => e.JobVctnNmbr);

                entity.ToTable("job_vctn_type");

                entity.Property(e => e.JobVctnNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("job_vctn_nmbr");

                entity.Property(e => e.JobVctnNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("job_vctn_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldtTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("oldt_type_nmbr");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("journal");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Debt).HasColumnName("DEBT");

                entity.Property(e => e.Remark)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REMARK");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("TRNS_DATE");

                entity.Property(e => e.TrnsType).HasColumnName("TRNS_TYPE");
            });

            modelBuilder.Entity<MailAddrType>(entity =>
            {
                entity.HasKey(e => e.MailAddrOpt);

                entity.ToTable("mail_addr_type");

                entity.Property(e => e.MailAddrOpt)
                    .ValueGeneratedNever()
                    .HasColumnName("mail_addr_opt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MailAddrNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail_addr_nm");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MaritalStatusType>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusNmbr)
                    .HasName("PK__marital_status_t__3AE27131")
                    .IsClustered(false);

                entity.ToTable("marital_status_type");

                entity.Property(e => e.MaritalStatusNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("marital_status_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaritalStatusNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("marital_status_nm");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MaturityType>(entity =>
            {
                entity.HasKey(e => e.MaturityTypeNmbr);

                entity.ToTable("maturity_type");

                entity.Property(e => e.MaturityTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("maturity_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaturityTypeNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("maturity_type_nm");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MbrClsPlan>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.McpNmbr, e.MoneyTypeNmbr, e.McpSeqNmbr })
                    .HasName("PK__mbr_cls_plan__3EB30215")
                    .IsClustered(false);

                entity.ToTable("mbr_cls_plan");

                entity.HasIndex(e => e.EfctvDt, "IX_mbr_cls_plan")
                    .HasFillFactor(80);

                entity.HasIndex(e => new { e.GroupNmbr, e.McpNmbr, e.MoneyTypeNmbr, e.EfctvDt }, "xmbr_cls_plan");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.McpNmbr).HasColumnName("mcp_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.McpSeqNmbr).HasColumnName("mcp_seq_nmbr");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbRt).HasColumnName("cntrb_rt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.TerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("termination_dt");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithMany(p => p.MbrClsPlans)
                    .HasForeignKey(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mbr_cls_p__group__26A66E5A");

                entity.HasOne(d => d.MoneyTypeNmbrNavigation)
                    .WithMany(p => p.MbrClsPlans)
                    .HasForeignKey(d => d.MoneyTypeNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__mbr_cls_p__money__279A9293");
            });

            modelBuilder.Entity<McpType>(entity =>
            {
                entity.HasKey(e => e.McpNmbr)
                    .HasName("PK__mcp_type__634EBE90")
                    .IsClustered(false);

                entity.ToTable("mcp_type");

                entity.Property(e => e.McpNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("mcp_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.McpNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mcp_nm");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MnySrc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mny_src");

                entity.Property(e => e.LastChgDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_chg_dt");

                entity.Property(e => e.MnySrcNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mny_src_nm");

                entity.Property(e => e.MnySrcType).HasColumnName("Mny_src_type");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MoneyMvntComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("money_mvnt_comp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CompositionPct).HasColumnName("composition_pct");

                entity.Property(e => e.CurrentAsset).HasColumnName("current_asset");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NewAsset).HasColumnName("new_asset");
            });

            modelBuilder.Entity<MoneyType>(entity =>
            {
                entity.HasKey(e => e.MoneyTypeNmbr)
                    .HasName("PK__money_type__428392F9")
                    .IsClustered(false);

                entity.ToTable("money_type");

                entity.Property(e => e.MoneyTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("money_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<MppWdMaximum>(entity =>
            {
                entity.HasKey(e => new { e.BegPrd, e.EndPrd })
                    .HasName("PK__MPP_wd_maximum__08F5448B");

                entity.ToTable("MPP_wd_maximum");

                entity.Property(e => e.BegPrd).HasColumnName("beg_prd");

                entity.Property(e => e.EndPrd).HasColumnName("end_prd");

                entity.Property(e => e.MaxRate).HasColumnName("max_rate");
            });

            modelBuilder.Entity<MutasiTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mutasi_temp");

                entity.Property(e => e.Alamat).HasMaxLength(255);

                entity.Property(e => e.AlamatBank)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Bank");

                entity.Property(e => e.AtasNama)
                    .HasMaxLength(255)
                    .HasColumnName("Atas_Nama");

                entity.Property(e => e.BulanLahir)
                    .HasMaxLength(255)
                    .HasColumnName("Bulan_Lahir");

                entity.Property(e => e.BulanMutasi)
                    .HasMaxLength(255)
                    .HasColumnName("Bulan_Mutasi");

                entity.Property(e => e.Cabang).HasMaxLength(255);

                entity.Property(e => e.Hp)
                    .HasMaxLength(255)
                    .HasColumnName("HP");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos");

                entity.Property(e => e.Meninggal).HasMaxLength(255);

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Bank");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Peserta");

                entity.Property(e => e.NoPegawai)
                    .HasMaxLength(255)
                    .HasColumnName("No_Pegawai");

                entity.Property(e => e.NoPesertaDplk).HasColumnName("No_Peserta_DPLK");

                entity.Property(e => e.NomorRekening)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor_Rekening");

                entity.Property(e => e.PensiunDipercepat)
                    .HasMaxLength(255)
                    .HasColumnName("Pensiun_Dipercepat");

                entity.Property(e => e.PensiunNormal)
                    .HasMaxLength(255)
                    .HasColumnName("Pensiun_Normal");

                entity.Property(e => e.PesertaMandiri)
                    .HasMaxLength(255)
                    .HasColumnName("Peserta_Mandiri");

                entity.Property(e => e.PindahKe)
                    .HasMaxLength(255)
                    .HasColumnName("Pindah_Ke");

                entity.Property(e => e.TahunLahir).HasColumnName("Tahun_Lahir");

                entity.Property(e => e.TahunMutasi)
                    .HasMaxLength(255)
                    .HasColumnName("Tahun_Mutasi");

                entity.Property(e => e.TanggalLahir).HasColumnName("Tanggal_Lahir");

                entity.Property(e => e.TanggalMutasi)
                    .HasMaxLength(255)
                    .HasColumnName("Tanggal_Mutasi");

                entity.Property(e => e.Telp).HasMaxLength(255);

                entity.Property(e => e.TtdPejabatBerwenang)
                    .HasMaxLength(255)
                    .HasColumnName("TTD_Pejabat_Berwenang");
            });

            modelBuilder.Entity<Nab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nab");

                entity.HasIndex(e => new { e.EfctvDt, e.InvTypeNmbr }, "IX_nab_missing_342");

                entity.HasIndex(e => e.EfctvDt, "IX_nab_missing_413");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Nab1).HasColumnName("nab");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UnitSuspense).HasColumnName("unit_suspense");
            });

            modelBuilder.Entity<OptionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("option_type");

                entity.Property(e => e.OptionTypeNm)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("option_type_nm");

                entity.Property(e => e.OptionTypeNmbr).HasColumnName("option_type_nmbr");
            });

            modelBuilder.Entity<OverPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("over_payment");

                entity.Property(e => e.Comment)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNmbr).HasColumnName("Group_nmbr");

                entity.Property(e => e.OverPmt).HasColumnName("Over_pmt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Paid_dt");
            });

            modelBuilder.Entity<PayRspnType>(entity =>
            {
                entity.HasKey(e => e.PayRspnNmbr)
                    .HasName("PK__pay_rspn_type__446BDB6B")
                    .IsClustered(false);

                entity.ToTable("pay_rspn_type");

                entity.Property(e => e.PayRspnNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PayRspnNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pay_rspn_nm");
            });

            modelBuilder.Entity<Paycenter>(entity =>
            {
                entity.HasKey(e => new { e.ClientNmbr, e.PaycenterNmbr })
                    .HasName("PK__paycenter__465423DD")
                    .IsClustered(false);

                entity.ToTable("paycenter");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("contact_person");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MasterPaycenterNmbr).HasColumnName("master_paycenter_nmbr");

                entity.Property(e => e.PaycenterNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("paycenter_nm");

                entity.HasOne(d => d.ClientNmbrNavigation)
                    .WithMany(p => p.Paycenters)
                    .HasForeignKey(d => d.ClientNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__paycenter__clien__2982DB05");
            });

            modelBuilder.Entity<PaymentApprvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payment_apprv_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentApprvNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_apprv_nm");

                entity.Property(e => e.PaymentApprvNmbr).HasColumnName("payment_apprv_nmbr");
            });

            modelBuilder.Entity<PaymentHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payment_hst");

                entity.HasIndex(e => new { e.GroupNmbr, e.BillCntrbNmbr }, "IX_payment_hst_missing_143");

                entity.HasIndex(e => new { e.PaymentTrnsNmbr, e.PaymentApprvCd }, "IX_payment_hst_missing_53");

                entity.Property(e => e.BillCntrbNmbr).HasColumnName("bill_cntrb_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.PaymentApprvCd).HasColumnName("payment_apprv_cd");

                entity.Property(e => e.PaymentSeqNmbr).HasColumnName("payment_seq_nmbr");

                entity.Property(e => e.PaymentTrnsNmbr).HasColumnName("payment_trns_nmbr");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SuspnNmbr).HasColumnName("suspn_nmbr");

                entity.Property(e => e.SuspnRestAmt).HasColumnName("suspn_rest_amt");
            });

            modelBuilder.Entity<PaymentHst20221220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payment_hst20221220");

                entity.Property(e => e.BillCntrbNmbr).HasColumnName("bill_cntrb_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.PaymentApprvCd).HasColumnName("payment_apprv_cd");

                entity.Property(e => e.PaymentSeqNmbr).HasColumnName("payment_seq_nmbr");

                entity.Property(e => e.PaymentTrnsNmbr).HasColumnName("payment_trns_nmbr");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SuspnNmbr).HasColumnName("suspn_nmbr");

                entity.Property(e => e.SuspnRestAmt).HasColumnName("suspn_rest_amt");
            });

            modelBuilder.Entity<PaymentTrnsType>(entity =>
            {
                entity.HasKey(e => e.PaymentTrnsNmbr);

                entity.ToTable("payment_trns_type");

                entity.Property(e => e.PaymentTrnsNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("payment_trns_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentTrnsNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_trns_nm");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasKey(e => e.PaymentTypeNmbr)
                    .HasName("PK__payment_type__483C6C4F")
                    .IsClustered(false);

                entity.ToTable("payment_type");

                entity.Property(e => e.PaymentTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("payment_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_nm");
            });

            modelBuilder.Entity<PdpTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pdp_temp");

                entity.Property(e => e.AlamatKtp)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_KTP");

                entity.Property(e => e.AlamatPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Perusahaan");

                entity.Property(e => e.AlamatRumah)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Rumah");

                entity.Property(e => e.BulanLahir).HasColumnName("Bulan_Lahir");

                entity.Property(e => e.DanaPensiunAwal)
                    .HasMaxLength(255)
                    .HasColumnName("Dana_Pensiun_Awal");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Hp)
                    .HasMaxLength(255)
                    .HasColumnName("HP");

                entity.Property(e => e.JumlahAnak)
                    .HasMaxLength(255)
                    .HasColumnName("Jumlah_Anak");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos");

                entity.Property(e => e.KodePosKtp)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos_KTP");

                entity.Property(e => e.NamaIbuKandung)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ibu_Kandung");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Peserta");

                entity.Property(e => e.NoKtp).HasColumnName("No_KTP");

                entity.Property(e => e.NoPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("No_Peserta");

                entity.Property(e => e.NoPesertaDpAwal)
                    .HasMaxLength(255)
                    .HasColumnName("No_Peserta_DP_Awal");

                entity.Property(e => e.StatusBlmNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Blm_Nikah");

                entity.Property(e => e.StatusJandaDuda)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Janda_Duda");

                entity.Property(e => e.StatusNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Nikah");

                entity.Property(e => e.TahunLahir).HasColumnName("Tahun_Lahir");

                entity.Property(e => e.TanggalLahir).HasColumnName("Tanggal_Lahir");

                entity.Property(e => e.TelpRumah)
                    .HasMaxLength(255)
                    .HasColumnName("Telp_Rumah");

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(255)
                    .HasColumnName("Tempat_Lahir");

                entity.Property(e => e.UsiaPensiunNormal).HasColumnName("Usia_Pensiun_Normal");
            });

            modelBuilder.Entity<PengantarKartu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pengantar_kartu");

                entity.Property(e => e.AlamatKirim)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alamat_kirim");

                entity.Property(e => e.CerNmbr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.NoSurat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_surat");

                entity.Property(e => e.TglSurat)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_surat");
            });

            modelBuilder.Entity<PensionCert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pension_cert");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");
            });

            modelBuilder.Entity<PensionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PENSION_INFO");

                entity.Property(e => e.AccountNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_NM");

                entity.Property(e => e.AccountNmbr)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_NMBR");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_3");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BANK_NM");

                entity.Property(e => e.BillingSignature)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BILLING_SIGNATURE");

                entity.Property(e => e.Branch)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.ClaimSignature)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CLAIM_SIGNATURE");

                entity.Property(e => e.DplkNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DPLK_NM");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.LetterSignature)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LETTER_SIGNATURE");

                entity.Property(e => e.LevelJabatan)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LEVEL_JABATAN");

                entity.Property(e => e.PelaksanaTugas)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PELAKSANA_TUGAS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("PRODUCT_TYPE_NMBR");

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE");
            });

            modelBuilder.Entity<PercentAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("percent_asset");

                entity.Property(e => e.AssetTypeNmbr).HasColumnName("asset_type_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.Persen).HasColumnName("persen");
            });

            modelBuilder.Entity<Pesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("peserta");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeNmbr)
                    .HasName("PK__phone_type__4A24B4C1")
                    .IsClustered(false);

                entity.ToTable("phone_type");

                entity.Property(e => e.PhoneTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("phone_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PhoneTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("phone_type_nm");
            });

            modelBuilder.Entity<Pic>(entity =>
            {
                entity.ToTable("pic");

                entity.Property(e => e.PicId)
                    .ValueGeneratedNever()
                    .HasColumnName("pic_id");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PicName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pic_name");

                entity.Property(e => e.PicSignature)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pic_signature");
            });

            modelBuilder.Entity<PlanRiderType>(entity =>
            {
                entity.HasKey(e => e.PlanTypeNmbr);

                entity.ToTable("plan_rider_type");

                entity.Property(e => e.PlanTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("plan_type_nmbr");

                entity.Property(e => e.Benefit)
                    .HasColumnType("money")
                    .HasColumnName("benefit");

                entity.Property(e => e.Contribution)
                    .HasColumnType("money")
                    .HasColumnName("contribution");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PlanTypeNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("plan_type_nm");

                entity.Property(e => e.Premium)
                    .HasColumnType("money")
                    .HasColumnName("premium");

                entity.Property(e => e.PremiumTypeNmbr).HasColumnName("premium_type_nmbr");

                entity.Property(e => e.RiderTypeNmbr).HasColumnName("rider_type_nmbr");
            });

            modelBuilder.Entity<PreWithdrw>(entity =>
            {
                entity.HasKey(e => e.SeqNmbr);

                entity.ToTable("pre_withdrw");

                entity.HasIndex(e => new { e.CerNmbr, e.SubTrnsNmbr, e.WdStatusNmbr }, "IX_pre_withdrw_missing_292");

                entity.HasIndex(e => new { e.SeqNmbr, e.CreateDt, e.CerNmbr, e.SubTrnsNmbr }, "xPre_withdrw");

                entity.Property(e => e.SeqNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("seq_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CerNmbrMpp).HasColumnName("cer_nmbr_MPP");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.GsTerminateNmbr).HasColumnName("gs_terminate_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("received_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_Trns_nmbr");

                entity.Property(e => e.WdStatusNmbr).HasColumnName("wd_status_nmbr");

                entity.Property(e => e.WdStatusdocDt)
                    .HasColumnType("datetime")
                    .HasColumnName("wd_statusdoc_dt");
            });

            modelBuilder.Entity<PremiumMethod>(entity =>
            {
                entity.HasKey(e => e.PremiumMtdType);

                entity.ToTable("premium_method");

                entity.Property(e => e.PremiumMtdType)
                    .ValueGeneratedNever()
                    .HasColumnName("premium_mtd_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PremiumMtdNm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("premium_mtd_nm");
            });

            modelBuilder.Entity<PremiumType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("premium_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PremiumTypeNm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("premium_type_nm");

                entity.Property(e => e.PremiumTypeNmbr).HasColumnName("premium_type_nmbr");
            });

            modelBuilder.Entity<Prewithtemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prewithtemp");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");
            });

            modelBuilder.Entity<ProductCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_charge");

                entity.Property(e => e.BegPrd).HasColumnName("beg_prd");

                entity.Property(e => e.BillPct).HasColumnName("bill_pct");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.ChargeRt).HasColumnName("charge_rt");

                entity.Property(e => e.ChargeSeqNmbr).HasColumnName("charge_seq_nmbr");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.DeductPct).HasColumnName("deduct_pct");

                entity.Property(e => e.EndPrd).HasColumnName("end_prd");

                entity.Property(e => e.FreeCnt).HasColumnName("free_cnt");

                entity.Property(e => e.FreqTypeNmbr).HasColumnName("freq_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxCnt).HasColumnName("max_cnt");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.ProductType).HasColumnName("product_type");
            });

            modelBuilder.Entity<ProductSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("product_setup");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("additional_info");

                entity.Property(e => e.DefltValue)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("deflt_value");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("Product_type_nmbr");

                entity.Property(e => e.SetupTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("setup_type_nm");

                entity.Property(e => e.SetupTypeNmbr).HasColumnName("setup_type_nmbr");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeNmbr)
                    .HasName("PK__product_type__4FDD8E17")
                    .IsClustered(false);

                entity.ToTable("product_type");

                entity.Property(e => e.ProductTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("product_type_nmbr");

                entity.Property(e => e.MaxIssueAge).HasColumnName("max_issue_age");

                entity.Property(e => e.MinIssueAge).HasColumnName("min_issue_age");

                entity.Property(e => e.PrdAcronym)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("prd_acronym");

                entity.Property(e => e.ProductTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_type_nm");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceNmbr);

                entity.ToTable("province");

                entity.Property(e => e.ProvinceNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("province_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.ProvinceNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province_nm");
            });

            modelBuilder.Entity<PslType>(entity =>
            {
                entity.HasKey(e => e.PslTypeNmbr)
                    .HasName("PK__psl_type__68A93BE1")
                    .IsClustered(false);

                entity.ToTable("psl_type");

                entity.Property(e => e.PslTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("psl_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PslTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("psl_type_nm");
            });

            modelBuilder.Entity<PtcpExit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ptcp_exit");

                entity.Property(e => e.CerNmbr).HasColumnName("Cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Change_dt");

                entity.Property(e => e.ExitDt)
                    .HasColumnType("datetime")
                    .HasColumnName("exit_dt");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<RateRider>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rate_rider");

                entity.Property(e => e.Adb).HasColumnName("adb");

                entity.Property(e => e.Addb).HasColumnName("addb");

                entity.Property(e => e.Hcp).HasColumnName("hcp");

                entity.Property(e => e.Term).HasColumnName("term");

                entity.Property(e => e.Usia).HasColumnName("usia");
            });

            modelBuilder.Entity<RateTableDetail>(entity =>
            {
                entity.HasKey(e => new { e.RateTypeNmbr, e.RateSeqNmbr });

                entity.ToTable("rate_table_detail");

                entity.Property(e => e.RateTypeNmbr).HasColumnName("rate_type_nmbr");

                entity.Property(e => e.RateSeqNmbr).HasColumnName("rate_seq_nmbr");

                entity.Property(e => e.EndAmt).HasColumnName("end_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.RateAmt).HasColumnName("rate_amt");

                entity.Property(e => e.RatePct).HasColumnName("rate_pct");

                entity.Property(e => e.StartAmt).HasColumnName("start_amt");
            });

            modelBuilder.Entity<RateTableType>(entity =>
            {
                entity.HasKey(e => e.RateTypeNmbr);

                entity.ToTable("rate_table_type");

                entity.Property(e => e.RateTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("rate_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nm");

                entity.Property(e => e.RateTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rate_type_nm");
            });

            modelBuilder.Entity<Reconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reconciliation");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbDtlSeqNmbr).HasColumnName("cntrb_dtl_seq_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NewAmt).HasColumnName("new_amt");

                entity.Property(e => e.OldAmt).HasColumnName("old_amt");

                entity.Property(e => e.ReconNmbr).HasColumnName("recon_nmbr");
            });

            modelBuilder.Entity<RegisterMtdType>(entity =>
            {
                entity.HasKey(e => e.RegisterMtdNmbr);

                entity.ToTable("register_mtd_type");

                entity.Property(e => e.RegisterMtdNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("register_mtd_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.RegisterMtdNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("register_mtd_nm");
            });

            modelBuilder.Entity<RekapManfaatSiperdana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RekapManfaatSiperdana");

                entity.Property(e => e.AnnuityAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("annuity_acct_nm");

                entity.Property(e => e.AnnuityAcctNmbr)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("annuity_acct_nmbr");

                entity.Property(e => e.AnnuityBankAddr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("annuity_bank_addr");

                entity.Property(e => e.AnnuityBankNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("annuity_bank_nm");

                entity.Property(e => e.AnuitasTransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Anuitas Transfer Date");

                entity.Property(e => e.Biaya).HasColumnName("biaya");

                entity.Property(e => e.DariHasilInvestasi).HasColumnName("dari_hasil_investasi");

                entity.Property(e => e.DariIuran).HasColumnName("dari_iuran");

                entity.Property(e => e.JenisTransaksi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Jenis Transaksi");

                entity.Property(e => e.JumlahBayar).HasColumnName("jumlah_bayar");

                entity.Property(e => e.JumlahDibayar).HasColumnName("jumlah_dibayar");

                entity.Property(e => e.LumpsumAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nm");

                entity.Property(e => e.LumpsumAcctNmbr)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nmbr");

                entity.Property(e => e.LumpsumBankAddr)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_addr");

                entity.Property(e => e.LumpsumBankNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_nm");

                entity.Property(e => e.LumpsumTransferDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Lumpsum Transfer Date");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NoPegawai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("no_pegawai");

                entity.Property(e => e.NoPeserta).HasColumnName("no_peserta");

                entity.Property(e => e.Pajak).HasColumnName("pajak");

                entity.Property(e => e.RegistrationNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("registration_nmbr");

                entity.Property(e => e.TglLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_lahir");

                entity.Property(e => e.TglTransaksi)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_transaksi");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<ReturInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("retur_info");

                entity.Property(e => e.AcctNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("acct_nm");

                entity.Property(e => e.AcctNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("acct_nmbr");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("approved_by");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bank_address");

                entity.Property(e => e.BankId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bank_id");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CheckAmt).HasColumnName("check_amt");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("INV_TYPE_NMBR");

                entity.Property(e => e.PrepareBy)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("prepare_by");

                entity.Property(e => e.Regisid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("regisid");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.ReturDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retur_dt");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.SuspenseNmbr).HasColumnName("suspense_nmbr");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("trans_type");
            });

            modelBuilder.Entity<RfTableExt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RF_TABLE_EXT");

                entity.Property(e => e.AutogeneratedField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AUTOGENERATED_FIELD");

                entity.Property(e => e.HiddenField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HIDDEN_FIELD");

                entity.Property(e => e.PrimaryKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRIMARY_KEY");

                entity.Property(e => e.ReadonlyField)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("READONLY_FIELD");

                entity.Property(e => e.SubmitSp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBMIT_SP");

                entity.Property(e => e.SubmitSpField)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUBMIT_SP_FIELD");

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TABLENAME");
            });

            modelBuilder.Entity<RfTableReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RF_TABLE_REFERENCE");

                entity.Property(e => e.Colid).HasColumnName("COLID");

                entity.Property(e => e.Condition)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CONDITION");

                entity.Property(e => e.ConditionCreateby).HasColumnName("CONDITION_CREATEBY");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ORDERBY");

                entity.Property(e => e.Referfield1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERFIELD1");

                entity.Property(e => e.Referfield2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REFERFIELD2");

                entity.Property(e => e.Refertable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFERTABLE");

                entity.Property(e => e.Tablename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLENAME");
            });

            modelBuilder.Entity<RfUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RF_URL");

                entity.Property(e => e.Paramid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARAMID");

                entity.Property(e => e.Paramlink)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PARAMLINK");

                entity.Property(e => e.Paramname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PARAMNAME");
            });

            modelBuilder.Entity<Rfparameterall>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RFPARAMETERALL");

                entity.Property(e => e.Classid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CLASSID");

                entity.Property(e => e.Ismaker)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ISMAKER")
                    .IsFixedLength(true);

                entity.Property(e => e.Moduleid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MODULEID");

                entity.Property(e => e.Paramid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARAMID");

                entity.Property(e => e.Paramlink)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("PARAMLINK");

                entity.Property(e => e.Paramname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PARAMNAME");

                entity.Property(e => e.Paramtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PARAMTYPE");

                entity.Property(e => e.PgId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PG_ID");
            });

            modelBuilder.Entity<RiderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rider_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RiderTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("rider_type_nm");

                entity.Property(e => e.RiderTypeNmbr).HasColumnName("rider_type_nmbr");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.HasKey(e => e.RoleTypeNmbr)
                    .HasName("PK__role_type__793DFFAF");

                entity.ToTable("role_type");

                entity.Property(e => e.RoleTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("role_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RoleTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_type_nm");
            });

            modelBuilder.Entity<SearchFormCriterion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SEARCH_FORM_CRITERIA");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Fieldalias)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fieldalias");

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fieldname");

                entity.Property(e => e.Type)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SearchFormType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SEARCH_FORM_TYPE");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Sql)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("sql");
            });

            modelBuilder.Entity<SearchParameter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("search_parameter");

                entity.Property(e => e.FieldNm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("field_nm");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("field_type");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SecType>(entity =>
            {
                entity.HasKey(e => e.SecTypeNmbr);

                entity.ToTable("sec_type");

                entity.Property(e => e.SecTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("sec_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SecTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sec_type_nm");
            });

            modelBuilder.Entity<SecurityType>(entity =>
            {
                entity.HasKey(e => e.SecTypeNmbr);

                entity.ToTable("security_type");

                entity.Property(e => e.SecTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("sec_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SecTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sec_type_nm");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.CerNo).HasColumnName("cer_no");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(255)
                    .HasColumnName("employee_no");
            });

            modelBuilder.Entity<Sheet2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet2$");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");
            });

            modelBuilder.Entity<SiCalcType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("si_calc_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SiCalcTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("si_calc_type_nm");

                entity.Property(e => e.SiCalcTypeNmbr).HasColumnName("si_calc_type_nmbr");
            });

            modelBuilder.Entity<SiperdanaLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("siperdana_login");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("passwd");
            });

            modelBuilder.Entity<SlryHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("slry_history");

                entity.HasIndex(e => e.CerNmbr, "IX_slry_history_missing_754");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SlryAmt).HasColumnName("slry_amt");
            });

            modelBuilder.Entity<SpFirBck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sp_fir_bck");

                entity.Property(e => e.AcctVal)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("acct_val");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.MoneyTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Price)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("price");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<SpdAccgl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_ACCGL");

                entity.Property(e => e.AbleChangeperiod).HasColumnName("ABLE_CHANGEPERIOD");

                entity.Property(e => e.AppAddress)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APP_ADDRESS");

                entity.Property(e => e.CompanyAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_ADDRESS1");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_ADDRESS2");

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_FAX");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.CompanyNpwp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NPWP");

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_PHONE");

                entity.Property(e => e.CompanyPkpDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_PKP_DATE");

                entity.Property(e => e.CompanySignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_SIGN_NAME");

                entity.Property(e => e.CompanySignTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_SIGN_TITLE");

                entity.Property(e => e.Jurnalprefix)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JURNALPREFIX");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdAccountingreport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_ACCOUNTINGREPORTS");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LINK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SpdBigledger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_BIGLEDGER");

                entity.Property(e => e.CashCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastChangeBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDate).HasColumnType("datetime");

                entity.Property(e => e.NamaRekening)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekening)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowid)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ROWID");

                entity.Property(e => e.SubSidiary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdBigledgerV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SPD_BIGLEDGER_V");

                entity.Property(e => e.CashCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaRekening)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekening)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdCash>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CASH");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Neraca)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdCashcodeException>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CASHCODE_EXCEPTION");

                entity.Property(e => e.Cashcode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CASHCODE");
            });

            modelBuilder.Entity<SpdCertificateIuranInvestasiByperson>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CERTIFICATE_IURAN_INVESTASI_BYPERSON");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");
            });

            modelBuilder.Entity<SpdEmailSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_EMAIL_SETTING");

                entity.Property(e => e.Recipients)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("recipients");

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sender");

                entity.Property(e => e.Smtp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("smtp");
            });

            modelBuilder.Entity<SpdError>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_ERROR");

                entity.Property(e => e.Descr)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Part)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("part");

                entity.Property(e => e.TheDate).HasColumnType("datetime");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SpdFtp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_FTP");

                entity.Property(e => e.InDbftpIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IN_DBFTP_IP");

                entity.Property(e => e.InDbftpPort)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("IN_DBFTP_PORT");

                entity.Property(e => e.InDbftpPwd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IN_DBFTP_PWD");

                entity.Property(e => e.InDbftpUid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IN_DBFTP_UID");
            });

            modelBuilder.Entity<SpdGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GROUP");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");
            });

            modelBuilder.Entity<SpdGroupMenuaccess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GROUP_MENUACCESS");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.Paramid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARAMID");
            });

            modelBuilder.Entity<SpdIuranInvestasiByperson>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_IURAN_INVESTASI_BYPERSON");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntrb).HasColumnName("tu_cntrb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.Wd).HasColumnName("wd");

                entity.Property(e => e.WdTrmnt).HasColumnName("wd_trmnt");
            });

            modelBuilder.Entity<SpdIuranInvestasiBypersonTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_IURAN_INVESTASI_BYPERSON_temp");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntrb).HasColumnName("tu_cntrb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.Wd).HasColumnName("wd");
            });

            modelBuilder.Entity<SpdJournalsetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JOURNALSETUP");

                entity.Property(e => e.CredAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DebtAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("_spd_reports");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LINK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SpdReport1>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_REPORTS");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("LINK");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<SpdReportsParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_REPORTS_PARAM");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.ParamNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PARAM_NM");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<SpdScreenField>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_SCREEN_FIELD");

                entity.Property(e => e.Enable).HasColumnName("ENABLE");

                entity.Property(e => e.FieldDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIELD_DESC");

                entity.Property(e => e.FieldLen).HasColumnName("FIELD_LEN");

                entity.Property(e => e.FieldName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("FIELD_NAME");

                entity.Property(e => e.FieldPrimary).HasColumnName("FIELD_PRIMARY");

                entity.Property(e => e.FieldType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FIELD_TYPE");

                entity.Property(e => e.LookupQy)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("LOOKUP_QY");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TABLENAME");
            });

            modelBuilder.Entity<SpdScreenGeneric>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_SCREEN_GENERIC");

                entity.Property(e => e.ScreenDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SCREEN_DESC");

                entity.Property(e => e.ScreenId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SCREEN_ID");

                entity.Property(e => e.SelectQuery)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SELECT_QUERY");

                entity.Property(e => e.SubmitSp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBMIT_SP");
            });

            modelBuilder.Entity<SpdSubledger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_SUBLEDGER");

                entity.Property(e => e.CashCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastChangeBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastChangeDate).HasColumnType("datetime");

                entity.Property(e => e.NamaRekening)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekening)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekeningParent)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rowid)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("ROWID");

                entity.Property(e => e.SubSidiary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdSubledgerV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SPD_SUBLEDGER_V");

                entity.Property(e => e.CashCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Kas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NamaRekening)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekening)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekeningParent)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdSubsidiary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_SUBSIDIARY");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.CompanyAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_ADDRESS1");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_ADDRESS2");

                entity.Property(e => e.CompanyFax)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_FAX");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NAME");

                entity.Property(e => e.CompanyNpwp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_NPWP");

                entity.Property(e => e.CompanyPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_PHONE");

                entity.Property(e => e.CompanyPkpDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_PKP_DATE");

                entity.Property(e => e.CompanySignName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_SIGN_NAME");

                entity.Property(e => e.CompanySignTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY_SIGN_TITLE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<SpdUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_USERS");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.Lastactivity)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTACTIVITY");

                entity.Property(e => e.Lastlogin)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTLOGIN");

                entity.Property(e => e.Logged).HasColumnName("LOGGED");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("USERID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<SpdWebuser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_myLogin2");

                entity.ToTable("SPD_WEBUSER");

                entity.Property(e => e.UserId)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.FirstLogin).HasColumnType("datetime");

                entity.Property(e => e.IsLocked).HasColumnName("isLocked");

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Multiplicator).HasColumnName("multiplicator");

                entity.Property(e => e.Password).HasMaxLength(300);

                entity.Property(e => e.Rbdcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RBDCode")
                    .IsFixedLength(true);

                entity.Property(e => e.RefCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.UserLevel).HasDefaultValueSql("(0)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VfirstLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("VFirstLogin");

                entity.Property(e => e.WrongPass).HasColumnName("wrongPass");
            });

            modelBuilder.Entity<SporadicDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sporadic_detail");

                entity.HasIndex(e => e.CerNmbr, "IX_sporadic_detail_missing_6097");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_Type_nmbr");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_Trns_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_Type_nmbr");
            });

            modelBuilder.Entity<SporadicPmt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sporadic_pmt");

                entity.HasIndex(e => new { e.SeqNmbr, e.GroupNmbr, e.PaycenterNmbr, e.CreateDt, e.PaidDt, e.ReversalDt }, "xsporadic_pmt");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.JoinAccnFlg).HasColumnName("join_accn_flg");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PaidAmt).HasColumnName("paid_amt");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.ReversalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversal_dt");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.SporadicType).HasColumnName("sporadic_type");
            });

            modelBuilder.Entity<StatusType>(entity =>
            {
                entity.HasKey(e => e.StatusTypeNmbr)
                    .HasName("PK__status_type__5596676D")
                    .IsClustered(false);

                entity.ToTable("status_type");

                entity.Property(e => e.StatusTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("status_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.StatusTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status_type_nm");
            });

            modelBuilder.Entity<SumInsured>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sum_insured");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SumInsured1).HasColumnName("sum_insured");
            });

            modelBuilder.Entity<SunGlType>(entity =>
            {
                entity.HasKey(e => e.SunTypeNmbr);

                entity.ToTable("sun_gl_type");

                entity.Property(e => e.SunTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("sun_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SunTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sun_type_nm");
            });

            modelBuilder.Entity<SunMap>(entity =>
            {
                entity.HasKey(e => new { e.SeqNmbr, e.ProductType, e.SuspTypeNm, e.PayStsNm });

                entity.ToTable("sun_map");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_type");

                entity.Property(e => e.SuspTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("susp_type_nm");

                entity.Property(e => e.PayStsNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pay_sts_nm");

                entity.Property(e => e.AccNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_nmbr");

                entity.Property(e => e.ActyNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("acty_nmbr")
                    .IsFixedLength(true);

                entity.Property(e => e.DcActyNm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dc_acty_nm")
                    .IsFixedLength(true);

                entity.Property(e => e.DcInterNm)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("dc_inter_nm")
                    .IsFixedLength(true);

                entity.Property(e => e.InterNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inter_nmbr")
                    .IsFixedLength(true);

                entity.Property(e => e.InvAliasNm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv_alias_nm")
                    .IsFixedLength(true);

                entity.Property(e => e.InvTypeAcrNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_acr_nm");

                entity.Property(e => e.ProdAliasNm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("prod_alias_nm")
                    .IsFixedLength(true);

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("Trns_type_nmbr");
            });

            modelBuilder.Entity<SuratPengalihan>(entity =>
            {
                entity.HasKey(e => e.NoSurat);

                entity.ToTable("surat_pengalihan");

                entity.Property(e => e.NoSurat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_surat");

                entity.Property(e => e.Alamat)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("alamat");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LogDate)
                    .HasColumnType("datetime")
                    .HasColumnName("log_date");

                entity.Property(e => e.PicGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic_group");
            });

            modelBuilder.Entity<SuspenseHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("suspense_hst");

                entity.HasIndex(e => new { e.GroupNmbr, e.PaycenterNmbr, e.AdmApproveCd }, "IX_suspense_hst_missing_21");

                entity.HasIndex(e => new { e.SuspnNmbr, e.GroupNmbr, e.PaycenterNmbr, e.CreateDt, e.ReceivedDt }, "xsuspense_hst");

                entity.Property(e => e.AdmApproveCd).HasColumnName("adm_approve_cd");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.FinApproveCd).HasColumnName("fin_approve_cd");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.RcptvoucherFlg).HasColumnName("rcptvoucher_flg");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("received_dt");

                entity.Property(e => e.RefBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Bank");

                entity.Property(e => e.Remark)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SuspnAmt).HasColumnName("suspn_amt");

                entity.Property(e => e.SuspnDesc1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("suspn_desc1");

                entity.Property(e => e.SuspnDesc2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("suspn_desc2");

                entity.Property(e => e.SuspnNmbr).HasColumnName("suspn_nmbr");

                entity.Property(e => e.SuspnTypeNmbr).HasColumnName("suspn_type_nmbr");

                entity.Property(e => e.SuspnUseAmt).HasColumnName("suspn_use_amt");

                entity.Property(e => e.UseStatusCd).HasColumnName("use_status_cd");

                entity.Property(e => e.WaivedFlg).HasColumnName("waived_flg");
            });

            modelBuilder.Entity<SuspenseHst20221220>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("suspense_hst20221220");

                entity.Property(e => e.AdmApproveCd).HasColumnName("adm_approve_cd");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.FinApproveCd).HasColumnName("fin_approve_cd");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.RcptvoucherFlg).HasColumnName("rcptvoucher_flg");

                entity.Property(e => e.ReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("received_dt");

                entity.Property(e => e.RefBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Bank");

                entity.Property(e => e.Remark)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("remark");

                entity.Property(e => e.SuspnAmt).HasColumnName("suspn_amt");

                entity.Property(e => e.SuspnDesc1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("suspn_desc1");

                entity.Property(e => e.SuspnDesc2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("suspn_desc2");

                entity.Property(e => e.SuspnNmbr).HasColumnName("suspn_nmbr");

                entity.Property(e => e.SuspnTypeNmbr).HasColumnName("suspn_type_nmbr");

                entity.Property(e => e.SuspnUseAmt).HasColumnName("suspn_use_amt");

                entity.Property(e => e.UseStatusCd).HasColumnName("use_status_cd");

                entity.Property(e => e.WaivedFlg).HasColumnName("waived_flg");
            });

            modelBuilder.Entity<SuspenseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("suspense_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SuspnTypeNm)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("suspn_type_nm");

                entity.Property(e => e.SuspnTypeNmbr).HasColumnName("suspn_type_nmbr");
            });

            modelBuilder.Entity<SuspnAdmApprvType>(entity =>
            {
                entity.HasKey(e => e.AdmApprvTypeNmbr)
                    .HasName("PK__suspn_admApprv_t__0F2D40CE");

                entity.ToTable("suspn_admApprv_type");

                entity.Property(e => e.AdmApprvTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("admApprv_type_nmbr");

                entity.Property(e => e.AdmApprvTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("admApprv_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<SuspnApprvHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("suspn_apprv_hst");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.RefBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Bank");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.SuspDesc2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("susp_desc2");

                entity.Property(e => e.SuspnNmbr).HasColumnName("Suspn_nmbr");

                entity.Property(e => e.SuspnStatusCd).HasColumnName("suspn_status_cd");
            });

            modelBuilder.Entity<SuspnFinApprvType>(entity =>
            {
                entity.HasKey(e => e.FinApprvTypeNmbr)
                    .HasName("PK__suspn_finApprv_t__14E61A24");

                entity.ToTable("suspn_finApprv_type");

                entity.Property(e => e.FinApprvTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("finApprv_type_nmbr");

                entity.Property(e => e.FinApprvTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("finApprv_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");
            });

            modelBuilder.Entity<SuspnStatusType>(entity =>
            {
                entity.HasKey(e => e.SuspnStatusNmbr)
                    .HasName("PK__suspn_status_Typ__17C286CF");

                entity.ToTable("suspn_status_Type");

                entity.Property(e => e.SuspnStatusNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("suspn_status_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SuspnStatusNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("suspn_status_nm");
            });

            modelBuilder.Entity<SuspnUseStatusType>(entity =>
            {
                entity.HasKey(e => e.UseStatusNmbr)
                    .HasName("PK__suspn_useStatus___1A9EF37A");

                entity.ToTable("suspn_useStatus_type");

                entity.Property(e => e.UseStatusNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("use_status_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.UseStatusNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("use_status_nm");
            });

            modelBuilder.Entity<SwitchingRegistrationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SwitchingRegistrationTemp");

                entity.Property(e => e.Certificate).HasMaxLength(255);

                entity.Property(e => e.DestinationGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Destination_group");

                entity.Property(e => e.EePct1)
                    .HasMaxLength(255)
                    .HasColumnName("EE_Pct1");

                entity.Property(e => e.EePct2)
                    .HasMaxLength(255)
                    .HasColumnName("EE_Pct2");

                entity.Property(e => e.EePct3)
                    .HasMaxLength(255)
                    .HasColumnName("EE_Pct3");

                entity.Property(e => e.ErPct1)
                    .HasMaxLength(255)
                    .HasColumnName("ER_Pct1");

                entity.Property(e => e.ErPct2)
                    .HasMaxLength(255)
                    .HasColumnName("ER_Pct2");

                entity.Property(e => e.ErPct3)
                    .HasMaxLength(255)
                    .HasColumnName("ER_Pct3");

                entity.Property(e => e.FtPct1)
                    .HasMaxLength(255)
                    .HasColumnName("FT_Pct1");

                entity.Property(e => e.FtPct2)
                    .HasMaxLength(255)
                    .HasColumnName("FT_Pct2");

                entity.Property(e => e.FtPct3)
                    .HasMaxLength(255)
                    .HasColumnName("FT_Pct3");

                entity.Property(e => e.Hostname).HasMaxLength(50);

                entity.Property(e => e.InvDest1)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Dest1");

                entity.Property(e => e.InvDest2)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Dest2");

                entity.Property(e => e.InvDest3)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Dest3");

                entity.Property(e => e.InvOld1)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Old1");

                entity.Property(e => e.InvOld2)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Old2");

                entity.Property(e => e.InvOld3)
                    .HasMaxLength(255)
                    .HasColumnName("Inv_Old3");

                entity.Property(e => e.OldGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Old_group");

                entity.Property(e => e.SwitchAmt1)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Amt1");

                entity.Property(e => e.SwitchAmt2)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Amt2");

                entity.Property(e => e.SwitchAmt3)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Amt3");

                entity.Property(e => e.SwitchPct1)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Pct1");

                entity.Property(e => e.SwitchPct2)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Pct2");

                entity.Property(e => e.SwitchPct3)
                    .HasMaxLength(255)
                    .HasColumnName("Switch_Pct3");

                entity.Property(e => e.TuPct1)
                    .HasMaxLength(255)
                    .HasColumnName("TU_Pct1");

                entity.Property(e => e.TuPct2)
                    .HasMaxLength(255)
                    .HasColumnName("TU_Pct2");

                entity.Property(e => e.TuPct3)
                    .HasMaxLength(255)
                    .HasColumnName("TU_Pct3");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<SysMenuLst>(entity =>
            {
                entity.HasKey(e => e.SysMenuNum);

                entity.ToTable("sys_menu_lst");

                entity.Property(e => e.SysMenuNum)
                    .ValueGeneratedNever()
                    .HasColumnName("sys_menu_num");

                entity.Property(e => e.LastChngDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_chng_dt");

                entity.Property(e => e.SysMenuNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sys_menu_nm");
            });

            modelBuilder.Entity<TNotaDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_NotaDetail");

                entity.Property(e => e.Jml).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JmlKaryawan).HasColumnName("Jml_Karyawan");

                entity.Property(e => e.JmlKaryawanEnd).HasColumnName("Jml_Karyawan_End");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoNota)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("No_Nota");

                entity.Property(e => e.NoNotaDetail).HasColumnName("No_Nota_Detail");

                entity.Property(e => e.PenguranganKaryawan).HasColumnName("Pengurangan_Karyawan");

                entity.Property(e => e.TambahanKaryawan).HasColumnName("Tambahan_Karyawan");
            });

            modelBuilder.Entity<TNotaHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_NotaHeader");

                entity.Property(e => e.Alamat1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AtasNama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Atas_Nama");

                entity.Property(e => e.CabangBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cabang_Bank");

                entity.Property(e => e.JangkaPembayaran)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Jangka_Pembayaran");

                entity.Property(e => e.JmlKaryawan).HasColumnName("jml_Karyawan");

                entity.Property(e => e.JmlPembayaran)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Jml_Pembayaran");

                entity.Property(e => e.KantorPerwakilan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kantor_Perwakilan");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("Kode_Pos");

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Bank");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NoKontrak)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("No_Kontrak");

                entity.Property(e => e.NoNota)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("No_Nota");

                entity.Property(e => e.NoRekening)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("No_Rekening");

                entity.Property(e => e.NoSurat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("No_Surat");

                entity.Property(e => e.Penyetuju)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Perihal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TglJatuhTempo)
                    .HasColumnType("datetime")
                    .HasColumnName("Tgl_Jatuh_Tempo");

                entity.Property(e => e.TglTerbit)
                    .HasColumnType("datetime")
                    .HasColumnName("Tgl_Terbit");

                entity.Property(e => e.Up)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Dsa)
                    .HasMaxLength(10)
                    .HasColumnName("dsa")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TaccType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tacc_type");

                entity.Property(e => e.AccTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("acc_type_nm");

                entity.Property(e => e.AccTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("acc_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TaddressType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("taddress_type");

                entity.Property(e => e.AddrTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr_type_nm");

                entity.Property(e => e.AddrTypeNmbr).HasColumnName("addr_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TallowWithType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tallow_with_type");

                entity.Property(e => e.AllowWithNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("allow_with_nm");

                entity.Property(e => e.AllowWithNmbr).HasColumnName("allow_with_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TappStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tapp_status_type");

                entity.Property(e => e.AppStatusNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("app_status_nm");

                entity.Property(e => e.AppStatusNmbr).HasColumnName("app_status_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TapprovalLayerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tapproval_layer_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaxAmt).HasColumnName("max_amt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TrnsId).HasColumnName("trns_id");

                entity.Property(e => e.UserApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_approval_nm");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.TaxTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tax_type_nm");

                entity.Property(e => e.TaxTypeNmbr).HasColumnName("tax_type_nmbr");
            });

            modelBuilder.Entity<TaxWdType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tax_wd_type");

                entity.Property(e => e.FromAmt).HasColumnName("from_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NonNpwpPct).HasColumnName("non_npwp_pct");

                entity.Property(e => e.NpwpPct).HasColumnName("npwp_pct");

                entity.Property(e => e.TaxIdNmbr).HasColumnName("tax_id_nmbr");

                entity.Property(e => e.TaxTypeNmbr).HasColumnName("tax_type_nmbr");

                entity.Property(e => e.ToAmt).HasColumnName("to_amt");
            });

            modelBuilder.Entity<TbCntrbRdn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_cntrb_rdn");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetCntrb101).HasColumnName("net_cntrb_101");

                entity.Property(e => e.NetCntrb102).HasColumnName("net_cntrb_102");
            });

            modelBuilder.Entity<TbPenampung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbPenampung");

                entity.Property(e => e.Bulan).HasColumnName("bulan");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.Tahun)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRekBank>(entity =>
            {
                entity.HasKey(e => e.CodeBank);

                entity.ToTable("tbRekBank");

                entity.Property(e => e.CodeBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Code_Bank");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.Cabang)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rekening)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbankType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbank_type");

                entity.Property(e => e.BankTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("bank_type_nm");

                entity.Property(e => e.BankTypeNmbr).HasColumnName("bank_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TbeneRelationType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbene_relation_type");

                entity.Property(e => e.BeneRltnNmbr).HasColumnName("bene_rltn_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RelationNm)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("relation_nm");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TbeneType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbene_type");

                entity.Property(e => e.BeneTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("bene_type_nm");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.ParentBeneTypeNmbr).HasColumnName("parent_bene_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TblConfirmationLetter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_confirmation_letter");

                entity.Property(e => e.Address1)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.Autorized)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("autorized");

                entity.Property(e => e.AutorizedPosition)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("autorized_position");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.City)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contact_person");

                entity.Property(e => e.DateSurat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("date_Surat");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("dob");

                entity.Property(e => e.IdLetter)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID_letter");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Postal)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("postal");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userID");
            });

            modelBuilder.Entity<TblDbDirect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_db_direct");

                entity.HasIndex(e => new { e.CerNmbr, e.BatchId, e.ApprvNm }, "IX_tbl_db_direct_missing_97");

                entity.Property(e => e.AnnutyAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("annuty_acct_nm");

                entity.Property(e => e.AnnutyAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_acct_nmbr");

                entity.Property(e => e.AnnutyAmt).HasColumnName("annuty_amt");

                entity.Property(e => e.AnnutyBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_addr");

                entity.Property(e => e.AnnutyBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_key");

                entity.Property(e => e.AnnutyBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_nm");

                entity.Property(e => e.AnnutyDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_acct_nmbr");

                entity.Property(e => e.AnnutyDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("annuty_dbd_date");

                entity.Property(e => e.AnnutyDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_desc");

                entity.Property(e => e.AnnutyDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_rows");

                entity.Property(e => e.AnnutyDbdSeqNmbr).HasColumnName("annuty_dbd_seq_nmbr");

                entity.Property(e => e.ApprovalAmt).HasColumnName("approval_amt");

                entity.Property(e => e.ApprvNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apprv_nm");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LumpsumAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nm");

                entity.Property(e => e.LumpsumAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nmbr");

                entity.Property(e => e.LumpsumAmt).HasColumnName("lumpsum_amt");

                entity.Property(e => e.LumpsumBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_addr");

                entity.Property(e => e.LumpsumBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_key");

                entity.Property(e => e.LumpsumBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_nm");

                entity.Property(e => e.LumpsumDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_acct_nmbr");

                entity.Property(e => e.LumpsumDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lumpsum_dbd_date");

                entity.Property(e => e.LumpsumDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_desc");

                entity.Property(e => e.LumpsumDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_rows");

                entity.Property(e => e.LumpsumDbdSeqNmbr).HasColumnName("lumpsum_dbd_seq_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.RequestedNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requested_nm");

                entity.Property(e => e.Rtgs).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TblDbDirectBit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_db_direct_bit");

                entity.HasIndex(e => e.TrnsId, "IX_tbl_db_direct_bit_missing_93");

                entity.Property(e => e.ApprovalAmt).HasColumnName("approval_amt");

                entity.Property(e => e.ApprvNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apprv_nm");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.BitAcctNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bit_acct_nm");

                entity.Property(e => e.BitAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bit_acct_nmbr");

                entity.Property(e => e.BitAmt).HasColumnName("bit_amt");

                entity.Property(e => e.BitBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bit_bank_addr");

                entity.Property(e => e.BitBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bit_bank_key");

                entity.Property(e => e.BitBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bit_bank_nm");

                entity.Property(e => e.BitDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bit_dbd_acct_nmbr");

                entity.Property(e => e.BitDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("bit_dbd_date");

                entity.Property(e => e.BitDbdDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("bit_dbd_desc");

                entity.Property(e => e.BitDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bit_dbd_rows");

                entity.Property(e => e.BitDbdSeqNmbr).HasColumnName("bit_dbd_seq_nmbr");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeDst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_dst");

                entity.Property(e => e.InvTypeSrc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_src");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.RequestedNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requested_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNm)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nm");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TblDbDirectFeeTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_db_direct_fee_tax");

                entity.HasIndex(e => new { e.CerNmbr, e.BatchId, e.TrnsTypeNmbr, e.TrnsHstEfctvDt, e.InvTypeNmbr }, "IX_tbl_db_direct_fee_tax_missing_105");

                entity.Property(e => e.ApprovalAmt).HasColumnName("approval_amt");

                entity.Property(e => e.ApprvNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apprv_nm");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FeeAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("fee_acct_nm");

                entity.Property(e => e.FeeAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fee_acct_nmbr");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.FeeBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fee_bank_addr");

                entity.Property(e => e.FeeBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fee_bank_key");

                entity.Property(e => e.FeeBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fee_bank_nm");

                entity.Property(e => e.FeeDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fee_dbd_acct_nmbr");

                entity.Property(e => e.FeeDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fee_dbd_date");

                entity.Property(e => e.FeeDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fee_dbd_desc");

                entity.Property(e => e.FeeDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("fee_dbd_rows");

                entity.Property(e => e.FeeDbdSeqNmbr).HasColumnName("fee_dbd_seq_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.RequestedNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requested_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TaxAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("tax_acct_nm");

                entity.Property(e => e.TaxAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_acct_nmbr");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TaxBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tax_bank_addr");

                entity.Property(e => e.TaxBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_bank_key");

                entity.Property(e => e.TaxBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("tax_bank_nm");

                entity.Property(e => e.TaxDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_dbd_acct_nmbr");

                entity.Property(e => e.TaxDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("tax_dbd_date");

                entity.Property(e => e.TaxDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tax_dbd_desc");

                entity.Property(e => e.TaxDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("tax_dbd_rows");

                entity.Property(e => e.TaxDbdSeqNmbr).HasColumnName("tax_dbd_seq_nmbr");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TblDbDirectNotafikasi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_db_direct_Notafikasi");

                entity.HasIndex(e => new { e.CerNmbr, e.BatchId, e.ApprvNm }, "IX_tbl_db_direct_Notafikasi_missing_98");

                entity.Property(e => e.AnnutyAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("annuty_acct_nm");

                entity.Property(e => e.AnnutyAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_acct_nmbr");

                entity.Property(e => e.AnnutyAmt).HasColumnName("annuty_amt");

                entity.Property(e => e.AnnutyBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_addr");

                entity.Property(e => e.AnnutyBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_key");

                entity.Property(e => e.AnnutyBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("annuty_bank_nm");

                entity.Property(e => e.AnnutyDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_acct_nmbr");

                entity.Property(e => e.AnnutyDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("annuty_dbd_date");

                entity.Property(e => e.AnnutyDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_desc");

                entity.Property(e => e.AnnutyDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("annuty_dbd_rows");

                entity.Property(e => e.AnnutyDbdSeqNmbr).HasColumnName("annuty_dbd_seq_nmbr");

                entity.Property(e => e.ApprovalAmt).HasColumnName("approval_amt");

                entity.Property(e => e.ApprvNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apprv_nm");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FlagCetak)
                    .HasColumnName("Flag_Cetak")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FlagCm)
                    .HasColumnName("Flag_CM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LumpsumAcctNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nm");

                entity.Property(e => e.LumpsumAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_acct_nmbr");

                entity.Property(e => e.LumpsumAmt).HasColumnName("lumpsum_amt");

                entity.Property(e => e.LumpsumBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_addr");

                entity.Property(e => e.LumpsumBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_key");

                entity.Property(e => e.LumpsumBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_bank_nm");

                entity.Property(e => e.LumpsumDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_acct_nmbr");

                entity.Property(e => e.LumpsumDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lumpsum_dbd_date");

                entity.Property(e => e.LumpsumDbdDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_desc");

                entity.Property(e => e.LumpsumDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("lumpsum_dbd_rows");

                entity.Property(e => e.LumpsumDbdSeqNmbr).HasColumnName("lumpsum_dbd_seq_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.RequestedNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requested_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TblDbDirectSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_db_direct_switch");

                entity.HasIndex(e => new { e.CerNmbr, e.BatchId }, "IX_tbl_db_direct_switch_missing_76");

                entity.Property(e => e.ApprovalAmt).HasColumnName("approval_amt");

                entity.Property(e => e.ApprvNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apprv_nm");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CdvNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cdv_nmbr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeDst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_dst");

                entity.Property(e => e.InvTypeSrc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_src");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.RequestedNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requested_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.SwitchAcctNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("switch_acct_nm");

                entity.Property(e => e.SwitchAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("switch_acct_nmbr");

                entity.Property(e => e.SwitchAmt).HasColumnName("switch_amt");

                entity.Property(e => e.SwitchBankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("switch_bank_addr");

                entity.Property(e => e.SwitchBankKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("switch_bank_key");

                entity.Property(e => e.SwitchBankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("switch_bank_nm");

                entity.Property(e => e.SwitchDbdAcctNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("switch_dbd_acct_nmbr");

                entity.Property(e => e.SwitchDbdDate)
                    .HasColumnType("datetime")
                    .HasColumnName("switch_dbd_date");

                entity.Property(e => e.SwitchDbdDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("switch_dbd_desc");

                entity.Property(e => e.SwitchDbdRows)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("switch_dbd_rows");

                entity.Property(e => e.SwitchDbdSeqNmbr).HasColumnName("switch_dbd_seq_nmbr");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsTypeNm)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nm");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TblFppflpPerkiraan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fppflp_perkiraan");

                entity.HasIndex(e => new { e.Inv, e.Grp, e.TransTypeNmbr, e.SubTrns, e.SeqNmbr }, "IX_tbl_fppflp_perkiraan_missing_133");

                entity.HasIndex(e => e.SeqNmbr, "IX_tbl_fppflp_perkiraan_missing_490");

                entity.HasIndex(e => new { e.Fund, e.SeqNmbr }, "IX_tbl_fppflp_perkiraan_missing_674");

                entity.HasIndex(e => new { e.TrnsId, e.Inv, e.Slcode, e.Grp, e.GlCode, e.TransDate, e.SubTrns }, "xtbl_fppflp_perkiraan");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TblFppflpPerkiraan20230316>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fppflp_perkiraan_20230316");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TblFppflpPerkiraan20230316bak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fppflp_perkiraan_20230316bak");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TblFppflpPerkiraanTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fppflp_perkiraan_temp");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TblFppflpPerkiraancustody>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_fppflp_perkiraancustody");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblLogin");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<TboInvRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbo_inv_rate");

                entity.Property(e => e.BoInvTypeNmbr).HasColumnName("bo_inv_type_nmbr");

                entity.Property(e => e.FundManagerNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fund_manager_nm");

                entity.Property(e => e.InvPct).HasColumnName("inv_pct");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TboInvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbo_inv_type");

                entity.Property(e => e.BoInvTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bo_inv_type_nm");

                entity.Property(e => e.BoInvTypeNmbr).HasColumnName("bo_inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_id_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TchargeType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcharge_type");

                entity.Property(e => e.ChargeTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("charge_type_nm");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Tcitizenship>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcitizenship");

                entity.Property(e => e.CitizenshipCd).HasColumnName("citizenship_cd");

                entity.Property(e => e.CitizenshipNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("citizenship_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TcoiType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcoi_type");

                entity.Property(e => e.CoiTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("coi_type_nm");

                entity.Property(e => e.CoiTypeNmbr).HasColumnName("coi_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TcoiTypeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcoi_type_rate");

                entity.Property(e => e.CoiAge).HasColumnName("coi_age");

                entity.Property(e => e.CoiAmount).HasColumnName("coi_amount");

                entity.Property(e => e.CoiRate).HasColumnName("coi_rate");

                entity.Property(e => e.CoiTypeNmbr).HasColumnName("coi_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TcommRltnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcomm_rltn_type");

                entity.Property(e => e.CommRltnTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("comm_rltn_type_nm");

                entity.Property(e => e.CommRltnTypeNmbr).HasColumnName("comm_rltn_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TcommTitleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcomm_title_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TitleTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("title_type_nm");

                entity.Property(e => e.TitleTypeNmbr).HasColumnName("title_type_nmbr");
            });

            modelBuilder.Entity<TcommisionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcommision_type");

                entity.Property(e => e.CommisionTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("commision_type_nm");

                entity.Property(e => e.CommisionTypeNmbr).HasColumnName("commision_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Tcounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcounter");

                entity.Property(e => e.CounterNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("counter_nm");

                entity.Property(e => e.CounterNmbr).HasColumnName("counter_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.LastNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TcreditCardType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcredit_card_type");

                entity.Property(e => e.CreditCardNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("credit_card_nm");

                entity.Property(e => e.CreditCardTypeNmbr).HasColumnName("credit_card_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TcurrencyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tcurrency_type");

                entity.Property(e => e.CurrencyTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("currency_type_nm");

                entity.Property(e => e.CurrencyTypeNmbr).HasColumnName("currency_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TempAgen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_agen");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(255)
                    .HasColumnName("alamat");

                entity.Property(e => e.AtasNama)
                    .HasMaxLength(255)
                    .HasColumnName("atas_nama");

                entity.Property(e => e.Column1).HasMaxLength(255);

                entity.Property(e => e.KodeAgen).HasColumnName("kode_agen");

                entity.Property(e => e.KodeKantor).HasColumnName("kode_kantor");

                entity.Property(e => e.NamaAgen)
                    .HasMaxLength(255)
                    .HasColumnName("nama_agen");

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(255)
                    .HasColumnName("nama_bank");

                entity.Property(e => e.NamaJabatan)
                    .HasMaxLength(255)
                    .HasColumnName("nama_jabatan");

                entity.Property(e => e.NamaJd)
                    .HasMaxLength(255)
                    .HasColumnName("nama_jd");

                entity.Property(e => e.NamaKantor)
                    .HasMaxLength(255)
                    .HasColumnName("nama_kantor");

                entity.Property(e => e.NamaKota)
                    .HasMaxLength(255)
                    .HasColumnName("nama_kota");

                entity.Property(e => e.NoHandphone)
                    .HasMaxLength(255)
                    .HasColumnName("no_handphone");

                entity.Property(e => e.NoIdentitas).HasColumnName("no_identitas");

                entity.Property(e => e.NoRekening).HasColumnName("no_rekening");

                entity.Property(e => e.NoTelepon)
                    .HasMaxLength(255)
                    .HasColumnName("no_telepon");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(255)
                    .HasColumnName("npwp");

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(255)
                    .HasColumnName("tempat_lahir");

                entity.Property(e => e.TglLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_lahir");

                entity.Property(e => e.TglMulai)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_mulai");

                entity.Property(e => e.TglRegistrasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_registrasi");
            });

            modelBuilder.Entity<TempFundInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_fund_info");

                entity.Property(e => e.Asset)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvestmentDirection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Direction");

                entity.Property(e => e.InvestmentProportion).HasColumnName("Investment_Proportion");

                entity.Property(e => e.MoneyType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Money_Type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Price");
            });

            modelBuilder.Entity<TempFundInfo2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_fund_info_2");

                entity.Property(e => e.Asset)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvestmentDirection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Direction");

                entity.Property(e => e.InvestmentProportion).HasColumnName("Investment_Proportion");

                entity.Property(e => e.MoneyType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Money_Type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Price");
            });

            modelBuilder.Entity<TempFundInfo2Disct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_fund_info_2_disct");

                entity.Property(e => e.Asset)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvestmentDirection)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Direction");

                entity.Property(e => e.InvestmentProportion).HasColumnName("Investment_Proportion");

                entity.Property(e => e.MoneyType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Money_Type");

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Unit_Price");
            });

            modelBuilder.Entity<TempPengantarKartu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_pengantar_kartu");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");
            });

            modelBuilder.Entity<TempRealisasiKlaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_realisasi_klaim");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.AlamatPeserta)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("alamat_peserta");

                entity.Property(e => e.AtasNamaAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atas_nama_anuitas");

                entity.Property(e => e.AtasNamaLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atas_nama_lumpsum");

                entity.Property(e => e.Biaya).HasColumnName("biaya");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.InvestasiPemberiKerja).HasColumnName("investasi_pemberi_kerja");

                entity.Property(e => e.InvestasiPeserta).HasColumnName("investasi_peserta");

                entity.Property(e => e.IuranPemberiKerja).HasColumnName("iuran_pemberi_kerja");

                entity.Property(e => e.IuranPeserta).HasColumnName("iuran_peserta");

                entity.Property(e => e.JenisPenarikan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jenis_penarikan");

                entity.Property(e => e.JumlahAnuitas).HasColumnName("jumlah_anuitas");

                entity.Property(e => e.JumlahBayar).HasColumnName("jumlah_bayar");

                entity.Property(e => e.JumlahDiterima).HasColumnName("jumlah_diterima");

                entity.Property(e => e.JumlahLumpsum).HasColumnName("jumlah_lumpsum");

                entity.Property(e => e.KodeBankAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_bank_anuitas");

                entity.Property(e => e.KodeBankLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_bank_lumpsum");

                entity.Property(e => e.KodePegawai)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_pegawai");

                entity.Property(e => e.KodePenarikan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_penarikan");

                entity.Property(e => e.KodePerusahaan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_perusahaan");

                entity.Property(e => e.KodePerusahaanAsal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_perusahaan_asal");

                entity.Property(e => e.KodePeserta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kode_peserta");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_pos");

                entity.Property(e => e.MetodePengajuan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("metode_pengajuan");

                entity.Property(e => e.NamaBankAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_bank_anuitas");

                entity.Property(e => e.NamaBankLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_bank_lumpsum");

                entity.Property(e => e.NamaCabangAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_cabang_anuitas");

                entity.Property(e => e.NamaCabangLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_cabang_lumpsum");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.NamaPerusahaanAsal)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_perusahaan_asal");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NoPengajuan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_pengajuan");

                entity.Property(e => e.NoRekAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_rek_anuitas");

                entity.Property(e => e.NoRekLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_rek_lumpsum");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("npwp");

                entity.Property(e => e.Pajak).HasColumnName("pajak");

                entity.Property(e => e.Provinsi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provinsi");

                entity.Property(e => e.SourceType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source_type");

                entity.Property(e => e.SourceTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source_type_nm");

                entity.Property(e => e.StatusPengajuan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status_pengajuan");

                entity.Property(e => e.TanggalLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_lahir");

                entity.Property(e => e.TanggalPengajuan)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_pengajuan");

                entity.Property(e => e.TanggalTransaksi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_transaksi");

                entity.Property(e => e.TglBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_bayar");

                entity.Property(e => e.TrnsTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Withdrawal).HasColumnName("withdrawal");
            });

            modelBuilder.Entity<TempResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_result");

                entity.Property(e => e.AccValue).HasColumnName("acc_value");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EstValue).HasColumnName("est_value");

                entity.Property(e => e.Month).HasColumnName("_month");

                entity.Property(e => e.Year).HasColumnName("_year");
            });

            modelBuilder.Entity<TempSaldoDana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_saldo_dana");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntrb).HasColumnName("tu_cntrb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("updated_by");

                entity.Property(e => e.Wd).HasColumnName("wd");
            });

            modelBuilder.Entity<TempSaldoPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_saldo_peserta");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.EstFee).HasColumnName("est_fee");

                entity.Property(e => e.EstTax).HasColumnName("est_tax");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntb).HasColumnName("tu_cntb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.Wd).HasColumnName("wd");
            });

            modelBuilder.Entity<TempSuratPengalihan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_surat_pengalihan");

                entity.Property(e => e.UploadCounter).HasColumnName("upload_counter");
            });

            modelBuilder.Entity<TempTferPayUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_tfer_pay_update");

                entity.Property(e => e.Biaya).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasMaxLength(255);

                entity.Property(e => e.JenisPenarikan)
                    .HasMaxLength(255)
                    .HasColumnName("Jenis Penarikan");

                entity.Property(e => e.JumlahTransferAnuitas).HasColumnName("Jumlah Transfer Anuitas");

                entity.Property(e => e.JumlahTransferLumpsum).HasColumnName("Jumlah Transfer Lumpsum");

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Bank");

                entity.Property(e => e.NamaBank1)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Bank1");

                entity.Property(e => e.NamaPenerima)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Penerima");

                entity.Property(e => e.NamaPenerima1)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Penerima1");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Peserta");

                entity.Property(e => e.Net).HasMaxLength(255);

                entity.Property(e => e.NoPeserta).HasColumnName("No Peserta");

                entity.Property(e => e.NomorRekening).HasColumnName("Nomor Rekening");

                entity.Property(e => e.NomorRekening1)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor Rekening1");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP");

                entity.Property(e => e.Pajak).HasMaxLength(255);
            });

            modelBuilder.Entity<TempUploadPayrollContribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_UPLOAD_Payroll_contribution");

                entity.Property(e => e.Bulan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CerNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConEe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConEE");

                entity.Property(e => e.ConEr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConER");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("dob");

                entity.Property(e => e.Ft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FT");

                entity.Property(e => e.GroupNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("hostname");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.Tahun)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopUp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TopUP");
            });

            modelBuilder.Entity<TempVico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_vico");

                entity.Property(e => e.Asset).HasColumnName("asset");

                entity.Property(e => e.BirthDt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("birth_dt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.PeriodDt)
                    .HasColumnType("datetime")
                    .HasColumnName("period_dt");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UnitPrice).HasColumnName("unit_price");
            });

            modelBuilder.Entity<TempVicoMasterlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_vico_masterlist");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.EeCntrb).HasColumnName("ee_cntrb");

                entity.Property(e => e.EeIr).HasColumnName("ee_ir");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.ErCntrb).HasColumnName("er_cntrb");

                entity.Property(e => e.ErIr).HasColumnName("er_ir");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.FtCntrb).HasColumnName("ft_cntrb");

                entity.Property(e => e.FtIr).HasColumnName("ft_ir");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.TaEe).HasColumnName("ta_ee");

                entity.Property(e => e.TaEr).HasColumnName("ta_er");

                entity.Property(e => e.TuCntrb).HasColumnName("tu_cntrb");

                entity.Property(e => e.TuIr).HasColumnName("tu_ir");

                entity.Property(e => e.Wd).HasColumnName("wd");

                entity.Property(e => e.WdTrmnt).HasColumnName("wd_trmnt");
            });

            modelBuilder.Entity<TempWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempWD");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TempfeeWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempfeeWD");

                entity.Property(e => e.AdmFeeAmt).HasColumnName("adm_fee_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ExchgrtAmt).HasColumnName("exchgrt_amt");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.InvFeeAmt).HasColumnName("inv_fee_amt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.OtherFeeAmt).HasColumnName("other_fee_amt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.SurrdrAmt).HasColumnName("surrdr_amt");

                entity.Property(e => e.Tax23Amt).HasColumnName("tax23_amt");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<Tempgajistar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempgajistar");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");
            });

            modelBuilder.Entity<TempinvWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempinvWD");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<Tempnab>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempnab");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Nab).HasColumnName("nab");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UnitSuspense).HasColumnName("unit_suspense");
            });

            modelBuilder.Entity<TemporariTrnsHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporari_trns_hst");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TemporariTrnsHstInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temporari_trns_hst_inv");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<Tempunitprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempunitprice");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<TestDplkAkun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testDPLK_akun");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .HasColumnName("email");

                entity.Property(e => e.IdAkun)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_akun");

                entity.Property(e => e.IdNumber)
                    .HasMaxLength(20)
                    .HasColumnName("idNumber");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.Nama)
                    .HasMaxLength(100)
                    .HasColumnName("nama");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");
            });

            modelBuilder.Entity<TestDplkRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testDPLK_Role");

                entity.Property(e => e.IdRole).HasColumnName("id_role");

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(10)
                    .HasColumnName("role_code");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<TexceptionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("texception_type");

                entity.Property(e => e.ExceptionTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Exception_type_nm");

                entity.Property(e => e.ExceptionTypeNmbr).HasColumnName("Exception_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TferPayInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tfer_pay_info");

                entity.HasIndex(e => e.TferTypeNmbr, "IX_tfer_pay_info_missing_39");

                entity.HasIndex(e => e.CerNmbr, "IX_tfer_pay_info_missing_6086");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr }, "IX_tfer_pay_info_missing_81");

                entity.HasIndex(e => new { e.TferTypeNmbr, e.TrnsSeqNmbr, e.CerNmbr }, "xtfer_pay_info");

                entity.Property(e => e.AcctNm)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("acct_nm");

                entity.Property(e => e.AcctNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("acct_nmbr");

                entity.Property(e => e.BankAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_addr");

                entity.Property(e => e.BankBiNmbr)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("bank_bi_nmbr");

                entity.Property(e => e.BankCentralNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_central_nm");

                entity.Property(e => e.BankNm)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.BranchAddr)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("branch_addr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.Note)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.SumInsured).HasColumnName("sum_insured");

                entity.Property(e => e.TaxDctNmbr).HasColumnName("tax_dct_nmbr");

                entity.Property(e => e.TferAmt).HasColumnName("tfer_amt");

                entity.Property(e => e.TferTypeNmbr).HasColumnName("tfer_type_nmbr");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<TferPayInfo2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tfer_pay_info_2");

                entity.Property(e => e.AcctNm).HasColumnName("acct_nm");

                entity.Property(e => e.AcctNmbr).HasColumnName("acct_nmbr");

                entity.Property(e => e.BankAddr).HasColumnName("bank_addr");

                entity.Property(e => e.BankBiNmbr).HasColumnName("bank_bi_nmbr");

                entity.Property(e => e.BankCentralNm).HasColumnName("bank_central_nm");

                entity.Property(e => e.BankNm).HasColumnName("bank_nm");

                entity.Property(e => e.BranchAddr).HasColumnName("branch_addr");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.SumInsured).HasColumnName("sum_insured");

                entity.Property(e => e.TaxDctNmbr).HasColumnName("tax_dct_nmbr");

                entity.Property(e => e.TferAmt).HasColumnName("tfer_amt");

                entity.Property(e => e.TferTypeNmbr).HasColumnName("tfer_type_nmbr");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<TferType>(entity =>
            {
                entity.HasKey(e => e.TferTypeNmbr)
                    .HasName("PK__tfer_type__5B4F40C3")
                    .IsClustered(false);

                entity.ToTable("tfer_type");

                entity.Property(e => e.TferTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("tfer_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.TferTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tfer_type_nm");
            });

            modelBuilder.Entity<Tferpayinfo20220207>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tferpayinfo20220207$");

                entity.Property(e => e.JenisPenarikan)
                    .HasMaxLength(255)
                    .HasColumnName("Jenis Penarikan");

                entity.Property(e => e.JumlahTransferAnuitas).HasColumnName("Jumlah Transfer Anuitas");

                entity.Property(e => e.JumlahTransferLumpsum).HasColumnName("Jumlah Transfer Lumpsum");

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Bank");

                entity.Property(e => e.NamaBank1)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Bank1");

                entity.Property(e => e.NamaPenerima)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Penerima");

                entity.Property(e => e.NamaPenerima1)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Penerima1");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Peserta");

                entity.Property(e => e.NoPeserta).HasColumnName("No Peserta");

                entity.Property(e => e.NomorRekening).HasColumnName("Nomor Rekening");

                entity.Property(e => e.NomorRekening1)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor Rekening1");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP");
            });

            modelBuilder.Entity<TfrequencyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tfrequency_type");

                entity.Property(e => e.FreqTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("freq_type_nm");

                entity.Property(e => e.FreqTypeNmbr).HasColumnName("freq_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TfundSrcType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tfund_src_type");

                entity.Property(e => e.FundSrcNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("fund_src_nm");

                entity.Property(e => e.FundSrcNmbr).HasColumnName("fund_src_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ThistoriKomisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("THistoriKomisi");

                entity.Property(e => e.ChargeRt).HasColumnName("charge_rt");

                entity.Property(e => e.CntrbEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cntrb_efctv_dt");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CommisionType).HasColumnName("commision_type");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.FlgPaid).HasColumnName("flg_paid");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Iuran).HasColumnName("iuran");

                entity.Property(e => e.KdAgen)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("kd_agen");

                entity.Property(e => e.KodeKomisi)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kode_komisi");

                entity.Property(e => e.PaidDt)
                    .HasColumnType("datetime")
                    .HasColumnName("paid_dt");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");
            });

            modelBuilder.Entity<TidType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tid_type");

                entity.Property(e => e.IdentityNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("identity_nm");

                entity.Property(e => e.IdentityType).HasColumnName("identity_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TinvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tinv_type");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.InvTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldInvType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_inv_type");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TitleType>(entity =>
            {
                entity.HasKey(e => e.TitleTypeNmbr)
                    .HasName("PK__title_type__2057CCD0");

                entity.ToTable("title_type");

                entity.Property(e => e.TitleTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("title_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.TitleTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title_type_nm");
            });

            modelBuilder.Entity<TjobLvlType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tjob_lvl_type");

                entity.Property(e => e.JobLvlNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Job_lvl_nm");

                entity.Property(e => e.JobLvlNmbr).HasColumnName("job_lvl_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TjobVctnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tjob_vctn_type");

                entity.Property(e => e.JobVctnNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("job_vctn_nm");

                entity.Property(e => e.JobVctnNmbr).HasColumnName("job_vctn_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TkomisiPesertaMandiri>(entity =>
            {
                entity.HasKey(e => e.CerNmbr);

                entity.ToTable("tkomisi_peserta_mandiri");

                entity.Property(e => e.CerNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_agen");

                entity.Property(e => e.KomisiTahun1).HasColumnName("komisi_tahun_1");

                entity.Property(e => e.KomisiTahun2).HasColumnName("komisi_tahun_2");

                entity.Property(e => e.NamaAgen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_agen");

                entity.Property(e => e.NamaDanaPensiun)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_dana_pensiun");

                entity.Property(e => e.NamaPemohon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_pemohon");

                entity.Property(e => e.NilaiDanaAwal).HasColumnName("nilai_dana_awal");

                entity.Property(e => e.NilaiIuran).HasColumnName("nilai_iuran");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.TglBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_bayar");
            });

            modelBuilder.Entity<Tkuitansi>(entity =>
            {
                entity.HasKey(e => e.IdKuitansi);

                entity.ToTable("tkuitansi");

                entity.Property(e => e.IdKuitansi)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasColumnName("id_kuitansi");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("alamat");

                entity.Property(e => e.AnKuitansi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("an_kuitansi");

                entity.Property(e => e.DtEtr)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_etr");

                entity.Property(e => e.DtUpd)
                    .HasColumnType("datetime")
                    .HasColumnName("dt_upd");

                entity.Property(e => e.HostEtr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("host_etr");

                entity.Property(e => e.HostUpd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("host_upd");

                entity.Property(e => e.KodePerusahaan)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kode_perusahaan");

                entity.Property(e => e.KodePeserta)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("kode_peserta");

                entity.Property(e => e.NamaPenandatangan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_penandatangan");

                entity.Property(e => e.NoKontrak)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("no_kontrak");

                entity.Property(e => e.PenjelasanKuitansi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("penjelasan_kuitansi");

                entity.Property(e => e.TglKuitansi)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_kuitansi");

                entity.Property(e => e.TotalKuitansi)
                    .HasColumnType("money")
                    .HasColumnName("total_kuitansi");

                entity.Property(e => e.UpKuitansi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("up_kuitansi");

                entity.Property(e => e.UserEtr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_etr");

                entity.Property(e => e.UserUpd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_upd");
            });

            modelBuilder.Entity<TmailAddrType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmail_addr_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MailAddrNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail_addr_nm");

                entity.Property(e => e.MailAddrOpt).HasColumnName("mail_addr_opt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmaritalStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmarital_status_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaritalStatusNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("marital_status_nm");

                entity.Property(e => e.MaritalStatusNmbr).HasColumnName("marital_status_nmbr");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmaturityType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmaturity_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaturityTypeNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("maturity_type_nm");

                entity.Property(e => e.MaturityTypeNmbr).HasColumnName("maturity_type_nmbr");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmcpType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmcp_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.McpNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mcp_nm");

                entity.Property(e => e.McpNmbr).HasColumnName("mcp_nmbr");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmnySrc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmny_src");

                entity.Property(e => e.LastChgDt)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_chg_dt");

                entity.Property(e => e.MnySrcNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mny_src_nm");

                entity.Property(e => e.MnySrcType).HasColumnName("Mny_src_type");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmoneyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmoney_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TmoveGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmove_group");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");
            });

            modelBuilder.Entity<TmpCerCntrb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_cer_cntrb");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.CntrbAmt).HasColumnName("cntrb_amt");

                entity.Property(e => e.CntrbRt).HasColumnName("cntrb_rt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.McpNmbr).HasColumnName("mcp_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.UseGrpCd).HasColumnName("use_grp_cd");
            });

            modelBuilder.Entity<TmpCerInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_cer_inv");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.UnitCount).HasColumnName("unit_count");
            });

            modelBuilder.Entity<TmpCerInvDrct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_cer_inv_drct");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.Percentage).HasColumnName("percentage");
            });

            modelBuilder.Entity<TmpCerStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_cer_status");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("change_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.StatusTypeNmbr).HasColumnName("status_type_nmbr");
            });

            modelBuilder.Entity<TmpCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_certificate");

                entity.Property(e => e.AppReceiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("app_receive_dt");

                entity.Property(e => e.AppStatusNmbr).HasColumnName("app_status_nmbr");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CerNmbrOpf).HasColumnName("cer_nmbr_opf");

                entity.Property(e => e.CitizenshipCd).HasColumnName("citizenship_cd");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.CompletionDt)
                    .HasColumnType("datetime")
                    .HasColumnName("completion_dt");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.Employee2Nmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee2_nmbr");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.EmploymentDt)
                    .HasColumnType("datetime")
                    .HasColumnName("employment_dt");

                entity.Property(e => e.FirstPremiumFlg).HasColumnName("first_premium_flg");

                entity.Property(e => e.FundSrcNmbr).HasColumnName("fund_src_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.JobVctnNmbr).HasColumnName("job_vctn_nmbr");

                entity.Property(e => e.KitDeliveryDt)
                    .HasColumnType("datetime")
                    .HasColumnName("kit_delivery_dt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MaturityDt)
                    .HasColumnType("datetime")
                    .HasColumnName("maturity_dt");

                entity.Property(e => e.OldCerNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_cer_nmbr");

                entity.Property(e => e.OthDppkFlg).HasColumnName("oth_DPPK_flg");

                entity.Property(e => e.PaycenterNmbr).HasColumnName("paycenter_nmbr");

                entity.Property(e => e.PaymentTypeNmbr).HasColumnName("payment_type_nmbr");

                entity.Property(e => e.PinPrintDt)
                    .HasColumnType("datetime")
                    .HasColumnName("pin_print_dt");

                entity.Property(e => e.RetirementAge).HasColumnName("retirement_age");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");

                entity.Property(e => e.TerminationDt)
                    .HasColumnType("datetime")
                    .HasColumnName("termination_dt");
            });

            modelBuilder.Entity<TmpClaimRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_claim_register");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClaimAmount).HasColumnName("claim_amount");

                entity.Property(e => e.CrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cr_date");

                entity.Property(e => e.CrId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.RegisterMtdNmbr).HasColumnName("register_mtd_nmbr");

                entity.Property(e => e.SubTrnsType).HasColumnName("sub_trns_type");
            });

            modelBuilder.Entity<TmpClaimRegisterTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_claim_register_track");

                entity.Property(e => e.CrId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.TrackDate)
                    .HasColumnType("datetime")
                    .HasColumnName("track_date");

                entity.Property(e => e.TrackTypeNmbr).HasColumnName("track_type_nmbr");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<TmpClaimRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_claim_request");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("batch_id");

                entity.Property(e => e.CrId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cr_id");

                entity.Property(e => e.Takenby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("takenby");

                entity.Property(e => e.Takendate)
                    .HasColumnType("datetime")
                    .HasColumnName("takendate");

                entity.Property(e => e.Thedate)
                    .HasColumnType("datetime")
                    .HasColumnName("thedate");
            });

            modelBuilder.Entity<TmpCycleCertificateCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_cycle_certificate_charge");

                entity.Property(e => e.AssetAmt).HasColumnName("asset_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ChargeAmt).HasColumnName("charge_amt");

                entity.Property(e => e.ChargeTypeNmbr).HasColumnName("charge_type_nmbr");

                entity.Property(e => e.CycleDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycle_dt");

                entity.Property(e => e.DeductedAmt).HasColumnName("deducted_amt");

                entity.Property(e => e.DeductedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deducted_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.LastChargeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_charge_dt");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<TmpTblFppflpPerkiraan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_tbl_fppflp_perkiraan");

                entity.Property(e => e.Amont).HasColumnName("amont");

                entity.Property(e => e.ApprovalDt)
                    .HasColumnType("datetime")
                    .HasColumnName("approval_dt");

                entity.Property(e => e.ApprovalNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_nm");

                entity.Property(e => e.Ccy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(4000)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Credit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("credit");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Debet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("debet");

                entity.Property(e => e.Descr)
                    .HasMaxLength(4000)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GeneratedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("generated_dt");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(4000)
                    .HasColumnName("keterangan");

                entity.Property(e => e.ModeTrans)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mode_trans");

                entity.Property(e => e.Refcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("refcode");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TransTypeNmbr).HasColumnName("trans_type_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<TmpchanCerInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpchan_cer_inv");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.UnitCount).HasColumnName("unit_count");
            });

            modelBuilder.Entity<TokaiTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tokai_temp");

                entity.Property(e => e.Agama).HasMaxLength(255);

                entity.Property(e => e.AlamatKtp)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_KTP");

                entity.Property(e => e.AlamatPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Perusahaan");

                entity.Property(e => e.AlamatTempatTinggal)
                    .HasMaxLength(255)
                    .HasColumnName("Alamat_Tempat_Tinggal");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Hp)
                    .HasMaxLength(255)
                    .HasColumnName("HP");

                entity.Property(e => e.IuranKaryawan).HasColumnName("Iuran_karyawan");

                entity.Property(e => e.JumlahAnak)
                    .HasMaxLength(255)
                    .HasColumnName("Jumlah_Anak");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos");

                entity.Property(e => e.KodePos1)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos1");

                entity.Property(e => e.KodePos2)
                    .HasMaxLength(255)
                    .HasColumnName("Kode_Pos2");

                entity.Property(e => e.NamaIbuKandung)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Ibu Kandung");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama_Peserta");

                entity.Property(e => e.NoKtpSim)
                    .HasMaxLength(255)
                    .HasColumnName("No_KTP/SIM");

                entity.Property(e => e.NoPesertaNik).HasColumnName("No_Peserta/NIK");

                entity.Property(e => e.NpwpPerusahaan)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Perusahaan");

                entity.Property(e => e.NpwpPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("NPWP_Peserta");

                entity.Property(e => e.PesertaKumpulan).HasColumnName("Peserta_Kumpulan");

                entity.Property(e => e.StatusBlmNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Blm_Nikah");

                entity.Property(e => e.StatusJandaDuda)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Janda_Duda");

                entity.Property(e => e.StatusNikah)
                    .HasMaxLength(255)
                    .HasColumnName("Status_Nikah");

                entity.Property(e => e.TandaTanganPerusahaanOleh)
                    .HasMaxLength(255)
                    .HasColumnName("Tanda_Tangan_Perusahaan_Oleh");

                entity.Property(e => e.TandaTanganPesertaOleh)
                    .HasMaxLength(255)
                    .HasColumnName("Tanda_Tangan_Peserta_Oleh");

                entity.Property(e => e.Tanggal1).HasMaxLength(255);

                entity.Property(e => e.Tanggal2).HasMaxLength(255);

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(255)
                    .HasColumnName("Tempat_lahir");

                entity.Property(e => e.TlpRumah)
                    .HasMaxLength(255)
                    .HasColumnName("Tlp_Rumah");

                entity.Property(e => e.UsiaPensiunNormal).HasColumnName("Usia_Pensiun_Normal");
            });

            modelBuilder.Entity<TpayRspnType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpay_rspn_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PayRspnNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("pay_rspn_nm");

                entity.Property(e => e.PayRspnNmbr).HasColumnName("pay_rspn_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpaymentApprvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpayment_apprv_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentApprvNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_apprv_nm");

                entity.Property(e => e.PaymentApprvNmbr).HasColumnName("payment_apprv_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpaymentTrnsType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpayment_trns_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentTrnsNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_trns_nm");

                entity.Property(e => e.PaymentTrnsNmbr).HasColumnName("payment_trns_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpaymentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpayment_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PaymentNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("payment_nm");

                entity.Property(e => e.PaymentTypeNmbr).HasColumnName("payment_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TphoneType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tphone_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PhoneTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("phone_type_nm");

                entity.Property(e => e.PhoneTypeNmbr).HasColumnName("phone_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Tpic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpic");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PicName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pic_name");

                entity.Property(e => e.PicSignature)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pic_signature");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpremiumMethod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpremium_method");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PremiumMtdNm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("premium_mtd_nm");

                entity.Property(e => e.PremiumMtdType).HasColumnName("premium_mtd_type");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpremiumType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpremium_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PremiumTypeNm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("premium_type_nm");

                entity.Property(e => e.PremiumTypeNmbr).HasColumnName("premium_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TproductType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tproduct_type");

                entity.Property(e => e.MaxIssueAge).HasColumnName("max_issue_age");

                entity.Property(e => e.MinIssueAge).HasColumnName("min_issue_age");

                entity.Property(e => e.PrdAcronym)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("prd_acronym");

                entity.Property(e => e.ProductTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_type_nm");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("product_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<Tprovince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tprovince");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.ProvinceNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province_nm");

                entity.Property(e => e.ProvinceNmbr).HasColumnName("province_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TpslType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tpsl_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.PslTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("psl_type_nm");

                entity.Property(e => e.PslTypeNmbr).HasColumnName("psl_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TrateTableDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trate_table_detail");

                entity.Property(e => e.EndAmt).HasColumnName("end_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.RateAmt).HasColumnName("rate_amt");

                entity.Property(e => e.RatePct).HasColumnName("rate_pct");

                entity.Property(e => e.RateSeqNmbr).HasColumnName("rate_seq_nmbr");

                entity.Property(e => e.RateTypeNmbr).HasColumnName("rate_type_nmbr");

                entity.Property(e => e.StartAmt).HasColumnName("start_amt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TrateTableType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trate_table_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nm");

                entity.Property(e => e.RateTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rate_type_nm");

                entity.Property(e => e.RateTypeNmbr).HasColumnName("rate_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TriderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trider_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RiderTypeNm)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rider_type_nm");

                entity.Property(e => e.RiderTypeNmbr).HasColumnName("rider_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TrnsAdminGantung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_admin_gantung");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsDocType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_doc_type");

                entity.Property(e => e.DocTypeNmbr).HasColumnName("doc_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Mandatory).HasColumnName("mandatory");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TrnsHst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst");

                entity.HasIndex(e => new { e.CerNmbr, e.MoneyTypeNmbr, e.TrnsTypeNmbr, e.SubTrnsNmbr }, "IX_trns_hst_missing_1022");

                entity.HasIndex(e => new { e.CerNmbr, e.ReversalFlg, e.CompletedFlg, e.TrnsHstEfctvDt }, "IX_trns_hst_missing_212");

                entity.HasIndex(e => e.BatchId, "IX_trns_hst_missing_315");

                entity.HasIndex(e => new { e.TrnsHstEfctvDt, e.ProcessedFlg, e.CompletedFlg }, "IX_trns_hst_missing_5");

                entity.HasIndex(e => new { e.TrnsTypeNmbr, e.TrnsHstEfctvDt }, "IX_trns_hst_missing_5836");

                entity.HasIndex(e => new { e.TrnsTypeNmbr, e.BatchId }, "IX_trns_hst_missing_87");

                entity.HasIndex(e => new { e.CerNmbr, e.TrnsTypeNmbr, e.TrnsHstEfctvDt }, "IX_trns_hst_missing_909");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr, e.MoneyTypeNmbr, e.TrnsTypeNmbr, e.SubTrnsNmbr, e.TrnsHstEfctvDt }, "idxtrns_hst");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsHst20230216>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_20230216");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsHstCleannet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_cleannet");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsHstFee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_fee");

                entity.HasIndex(e => new { e.CerNmbr, e.TrnsTypeNmbr, e.SubTrnsNmbr }, "IX_trns_hst_fee_missing_17");

                entity.HasIndex(e => new { e.CerNmbr, e.MoneyTypeNmbr }, "IX_trns_hst_fee_missing_5");

                entity.Property(e => e.AdmFeeAmt).HasColumnName("adm_fee_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ExchgrtAmt).HasColumnName("exchgrt_amt");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.InvFeeAmt).HasColumnName("inv_fee_amt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.OtherFeeAmt).HasColumnName("other_fee_amt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.SurrdrAmt).HasColumnName("surrdr_amt");

                entity.Property(e => e.Tax23Amt).HasColumnName("tax23_amt");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TrnsHstFeeSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_fee_switch");

                entity.Property(e => e.AdmFeeAmt).HasColumnName("adm_fee_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ExchgrtAmt).HasColumnName("exchgrt_amt");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.InvFeeAmt).HasColumnName("inv_fee_amt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.OtherFeeAmt).HasColumnName("other_fee_amt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.SurrdrAmt).HasColumnName("surrdr_amt");

                entity.Property(e => e.Tax23Amt).HasColumnName("tax23_amt");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TrnsHstFeeWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_fee_WD");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr, e.TrnsTypeNmbr, e.SubTrnsNmbr, e.MoneyTypeNmbr }, "xtrns_hst_fee_wd");

                entity.Property(e => e.AdmFeeAmt).HasColumnName("adm_fee_amt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ExchgrtAmt).HasColumnName("exchgrt_amt");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.InvFeeAmt).HasColumnName("inv_fee_amt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.OtherFeeAmt).HasColumnName("other_fee_amt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.SurrdrAmt).HasColumnName("surrdr_amt");

                entity.Property(e => e.Tax23Amt).HasColumnName("tax23_amt");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TrnsHstInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr, e.MoneyTypeNmbr }, "IX_trns_hst_inv_missing_180");

                entity.HasIndex(e => e.CerNmbr, "IX_trns_hst_inv_missing_25");

                entity.HasIndex(e => e.InvTypeNmbr, "IX_trns_hst_inv_missing_397");

                entity.HasIndex(e => e.CerNmbr, "IX_trns_hst_inv_missing_487");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInv20230216>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_20230216");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInvClean20230327>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_clean_20230327");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInvCleannet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_cleannet");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInvSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_switch");

                entity.HasIndex(e => e.CerNmbr, "IX_trns_hst_inv_switch_missing_29");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInvTempv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_tempv");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstInvWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_inv_WD");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr, e.MoneyTypeNmbr, e.InvTypeNmbr }, "xtrns_hst_inv_wd");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.UnitCnt).HasColumnName("unit_cnt");
            });

            modelBuilder.Entity<TrnsHstSwitch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_switch");

                entity.HasIndex(e => new { e.CerNmbr, e.TrnsTypeNmbr, e.CompletedFlg, e.BatchId }, "IX_trns_hst_switch_missing_31");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsHstTempv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_tempv");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsHstWd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_hst_WD");

                entity.HasIndex(e => new { e.TrnsSeqNmbr, e.CerNmbr, e.TrnsTypeNmbr, e.SubTrnsNmbr, e.TrnsHstEfctvDt }, "xtrns_hst_wd");

                entity.Property(e => e.BatchId).HasColumnName("batch_id");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompletedFlg).HasColumnName("completed_flg");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.ProcessedFlg).HasColumnName("processed_flg");

                entity.Property(e => e.ProcessorId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("processor_id");

                entity.Property(e => e.ReversalFlg).HasColumnName("reversal_flg");

                entity.Property(e => e.ReversedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("reversed_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsHstChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_change_dt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.VestedAmt).HasColumnName("vested_amt");
            });

            modelBuilder.Entity<TrnsPost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trns_post");

                entity.Property(e => e.CreditPost).HasColumnName("credit_post");

                entity.Property(e => e.DebetPost).HasColumnName("debet_post");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TrnsType>(entity =>
            {
                entity.HasKey(e => new { e.TrnsTypeNmbr, e.SubTrnsNmbr })
                    .HasName("PK__trns_type__62F0628B");

                entity.ToTable("trns_type");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");
            });

            modelBuilder.Entity<TroleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trole_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.RoleTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("role_type_nm");

                entity.Property(e => e.RoleTypeNmbr).HasColumnName("role_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TsecType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsec_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SecTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sec_type_nm");

                entity.Property(e => e.SecTypeNmbr).HasColumnName("sec_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TsecurityType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsecurity_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SecTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sec_type_nm");

                entity.Property(e => e.SecTypeNmbr).HasColumnName("sec_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TsiCalcType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsi_calc_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.SiCalcTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("si_calc_type_nm");

                entity.Property(e => e.SiCalcTypeNmbr).HasColumnName("si_calc_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TstatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tstatus_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.StatusTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status_type_nm");

                entity.Property(e => e.StatusTypeNmbr).HasColumnName("status_type_nmbr");
            });

            modelBuilder.Entity<TsunGlType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsun_gl_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SunTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sun_type_nm");

                entity.Property(e => e.SunTypeNmbr).HasColumnName("sun_type_nmbr");
            });

            modelBuilder.Entity<TsuspenseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsuspense_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SuspnTypeNm)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("suspn_type_nm");

                entity.Property(e => e.SuspnTypeNmbr).HasColumnName("suspn_type_nmbr");
            });

            modelBuilder.Entity<TsuspnAdmApprvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsuspn_admApprv_type");

                entity.Property(e => e.AdmApprvTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("admApprv_type_nm");

                entity.Property(e => e.AdmApprvTypeNmbr).HasColumnName("admApprv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TsuspnFinApprvType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsuspn_finApprv_type");

                entity.Property(e => e.FinApprvTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("finApprv_type_nm");

                entity.Property(e => e.FinApprvTypeNmbr).HasColumnName("finApprv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<TsuspnStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsuspn_status_Type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SuspnStatusNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("suspn_status_nm");

                entity.Property(e => e.SuspnStatusNmbr).HasColumnName("suspn_status_nmbr");
            });

            modelBuilder.Entity<TsuspnUseStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tsuspn_useStatus_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UseStatusNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("use_status_nm");

                entity.Property(e => e.UseStatusNmbr).HasColumnName("use_status_nmbr");
            });

            modelBuilder.Entity<TtaxType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttax_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TaxTypeNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("tax_type_nm");

                entity.Property(e => e.TaxTypeNmbr).HasColumnName("tax_type_nmbr");
            });

            modelBuilder.Entity<TtaxWdType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttax_wd_type");

                entity.Property(e => e.FromAmt).HasColumnName("from_amt");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.NonNpwpPct).HasColumnName("non_npwp_pct");

                entity.Property(e => e.NpwpPct).HasColumnName("npwp_pct");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TaxIdNmbr).HasColumnName("tax_id_nmbr");

                entity.Property(e => e.TaxTypeNmbr).HasColumnName("tax_type_nmbr");

                entity.Property(e => e.ToAmt).HasColumnName("to_amt");
            });

            modelBuilder.Entity<TtempKomisi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TTempKomisi");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.Agama)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("agama");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("alamat");

                entity.Property(e => e.AtasNama)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atas_nama");

                entity.Property(e => e.Cabang)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("cabang");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Foto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("foto");

                entity.Property(e => e.HostEntry)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("host_entry");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ID_AGEN");

                entity.Property(e => e.IdRegistrasi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_registrasi");

                entity.Property(e => e.JenisAgen).HasColumnName("jenis_agen");

                entity.Property(e => e.JenisKelamin)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("jenis_kelamin");

                entity.Property(e => e.JenisPajak)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jenis_pajak");

                entity.Property(e => e.KodeAgen)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kode_agen");

                entity.Property(e => e.KodeAgenPerekrut)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kode_agen_perekrut");

                entity.Property(e => e.KodeAtasan)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("kode_atasan");

                entity.Property(e => e.KodeBank)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("kode_bank");

                entity.Property(e => e.KodeJabatan)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kode_jabatan");

                entity.Property(e => e.KodeKantor)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kode_kantor");

                entity.Property(e => e.KodeKota)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("kode_kota");

                entity.Property(e => e.KodeStatusKawin)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("kode_status_kawin");

                entity.Property(e => e.NamaAgen)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_agen");

                entity.Property(e => e.NamaDanaPensiun)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Dana_Pensiun");

                entity.Property(e => e.NamaJabatan)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nama_jabatan");

                entity.Property(e => e.NamaPemohon)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Pemohon");

                entity.Property(e => e.NamaTim)
                    .IsUnicode(false)
                    .HasColumnName("nama_tim");

                entity.Property(e => e.NameAgen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_agen");

                entity.Property(e => e.NilaiIuran).HasColumnName("Nilai_Iuran");

                entity.Property(e => e.NoCdv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_cdv");

                entity.Property(e => e.NoHandphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_handphone");

                entity.Property(e => e.NoIdentitas)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_identitas");

                entity.Property(e => e.NoLisensi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_lisensi");

                entity.Property(e => e.NoRekening)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("no_rekening");

                entity.Property(e => e.NoTelepon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_telepon");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("npwp");

                entity.Property(e => e.Pendidikan)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("pendidikan");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.Sam)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("sam");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusFaktur).HasColumnName("status_faktur");

                entity.Property(e => e.StatusPkp).HasColumnName("status_pkp");

                entity.Property(e => e.TanggalBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_bayar");

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tempat_lahir");

                entity.Property(e => e.TglAkhir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_akhir");

                entity.Property(e => e.TglAkhirNpwp)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_akhir_npwp");

                entity.Property(e => e.TglAwalNpwp)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_awal_npwp");

                entity.Property(e => e.TglEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_entry");

                entity.Property(e => e.TglLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_lahir");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.UserEntry)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("user_entry");
            });

            modelBuilder.Entity<TtferType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttfer_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TferTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tfer_type_nm");

                entity.Property(e => e.TferTypeNmbr).HasColumnName("tfer_type_nmbr");
            });

            modelBuilder.Entity<TtitleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttitle_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TitleTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title_type_nm");

                entity.Property(e => e.TitleTypeNmbr).HasColumnName("title_type_nmbr");
            });

            modelBuilder.Entity<TtrnsType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ttrns_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TvaCurrencyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tva_currency_type");

                entity.Property(e => e.CurrencyTypeNmbr)
                    .HasMaxLength(50)
                    .HasColumnName("currency_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.VaNmbr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("va_nmbr");
            });

            modelBuilder.Entity<TvaDplkType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tva_dplk_type");

                entity.Property(e => e.DplkNmbr).HasColumnName("dplk_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.VaNmbr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("va_nmbr");
            });

            modelBuilder.Entity<TvaProductType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tva_product_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("product_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .IsFixedLength(true);

                entity.Property(e => e.VaNmbr)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("va_nmbr");
            });

            modelBuilder.Entity<TvestingType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tvesting_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.VestTypeNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("vest_type_nm");

                entity.Property(e => e.VestTypeNmbr).HasColumnName("vest_type_nmbr");
            });

            modelBuilder.Entity<TwdDocType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("twd_doc_type");

                entity.Property(e => e.AcronymNm)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("acronym_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WdDocNm)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("wd_doc_nm");

                entity.Property(e => e.WdDocNmbr).HasColumnName("wd_doc_nmbr");
            });

            modelBuilder.Entity<TwdStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("twd_status_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_Dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WdStatusNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("wd_status_nm");

                entity.Property(e => e.WdStatusNmbr).HasColumnName("wd_status_nmbr");
            });

            modelBuilder.Entity<TwdTransferType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("twd_transfer_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WdTransferNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("wd_transfer_nm");

                entity.Property(e => e.WdTransferNmbr).HasColumnName("wd_transfer_nmbr");
            });

            modelBuilder.Entity<TwithSourceType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("twith_source_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.WithSrcTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("with_src_type_nm");

                entity.Property(e => e.WithSrcTypeNmbr).HasColumnName("with_src_type_nmbr");
            });

            modelBuilder.Entity<UnitPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("unit_price");

                entity.HasIndex(e => new { e.InvTypeNmbr, e.EfctvDt }, "IX_unit_price_missing_164");

                entity.HasIndex(e => e.EfctvDt, "_dta_index_unit_price_9_922486365__K1");

                entity.Property(e => e.ApprovalFlg).HasColumnName("approval_flg");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<UploadJoinAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_join_account");

                entity.Property(e => e.CerNmbrDst).HasColumnName("cer_nmbr_dst");

                entity.Property(e => e.CerNmbrSrc).HasColumnName("cer_nmbr_src");

                entity.Property(e => e.FundOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fund_option");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");
            });

            modelBuilder.Entity<UploadMandiriIi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_mandiriII");

                entity.HasIndex(e => new { e.ClientNmbr, e.ClientNm }, "IX_upload_mandiriII_missing_30");

                entity.HasIndex(e => e.CerNmbr, "IX_upload_mandiriII_missing_36");

                entity.HasIndex(e => e.UploadCounter, "IX_upload_mandiriII_missing_6129");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.Birthplace)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("birthplace");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClaimRegistrationId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("claim_registration_id");

                entity.Property(e => e.ClaimTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("claim_type_nm");

                entity.Property(e => e.ClaimTypeNmbr).HasColumnName("claim_type_nmbr");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.ConfirmationLetterDt)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmation_letter_dt");

                entity.Property(e => e.ConfirmationLetterNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("confirmation_letter_nmbr");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.DocReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("doc_received_dt");

                entity.Property(e => e.DpAsal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dp_asal");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.EmployeeNo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("employee_no");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Ktp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KTP");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Mainaddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mainaddress");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Npwp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NPWP");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RekNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rek_nm");

                entity.Property(e => e.RekNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rek_nmbr");

                entity.Property(e => e.SalesNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_nm");

                entity.Property(e => e.UploadCounter).HasColumnName("upload_counter");

                entity.Property(e => e.UploadDt)
                    .HasColumnType("datetime")
                    .HasColumnName("upload_dt");

                entity.Property(e => e.UploadPicNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("upload_pic_nm");
            });

            modelBuilder.Entity<UploadMandiriIiBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_mandiriII_bak");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BankNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_nm");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClaimRegistrationId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("claim_registration_id");

                entity.Property(e => e.ClaimTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("claim_type_nm");

                entity.Property(e => e.ClaimTypeNmbr).HasColumnName("claim_type_nmbr");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.ConfirmationLetterDt)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmation_letter_dt");

                entity.Property(e => e.ConfirmationLetterNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("confirmation_letter_nmbr");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.DocReceivedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("doc_received_dt");

                entity.Property(e => e.DpAsal)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dp_asal");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Ktp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KTP");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Mainaddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("mainaddress");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Npwp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NPWP");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.RekNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rek_nm");

                entity.Property(e => e.RekNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rek_nmbr");

                entity.Property(e => e.SalesNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_nm");

                entity.Property(e => e.UploadCounter).HasColumnName("upload_counter");

                entity.Property(e => e.UploadDt)
                    .HasColumnType("datetime")
                    .HasColumnName("upload_dt");

                entity.Property(e => e.UploadPicNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("upload_pic_nm");
            });

            modelBuilder.Entity<UploadMandiriIiClaim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_mandiriII_claim");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.AppReceiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("app_receive_dt");

                entity.Property(e => e.ClaimTypeNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("claim_type_nm");

                entity.Property(e => e.ClientNm)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Nip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nip");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Npwp)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("npwp");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");

                entity.Property(e => e.SalesNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_nm");

                entity.Property(e => e.TransferMethod).HasColumnName("transfer_method");
            });

            modelBuilder.Entity<UploadMandiriIiClaimTran>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_mandiriII_claim_trans");

                entity.Property(e => e.AnnuityPct).HasColumnName("annuity_pct");

                entity.Property(e => e.AtasNamaAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atas_nama_anuitas");

                entity.Property(e => e.AtasNamaLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("atas_nama_lumpsum");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.KodeBankAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_bank_anuitas");

                entity.Property(e => e.KodeBankLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_bank_lumpsum");

                entity.Property(e => e.NamaBankAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_bank_anuitas");

                entity.Property(e => e.NamaBankLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_bank_lumpsum");

                entity.Property(e => e.NamaCabangAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_cabang_anuitas");

                entity.Property(e => e.NamaCabangLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nama_cabang_lumpsum");

                entity.Property(e => e.NoRekAnuitas)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_rek_anuitas");

                entity.Property(e => e.NoRekLumpsum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("no_rek_lumpsum");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");
            });

            modelBuilder.Entity<UploadMutasiDana>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_mutasi_dana");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.DestinationCer).HasColumnName("destination_cer");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");

                entity.Property(e => e.SourceCer).HasColumnName("source_cer");
            });

            modelBuilder.Entity<UploadNab>(entity =>
            {
                entity.HasKey(e => new { e.EfctvDt, e.InvTypeNmbr });

                entity.ToTable("Upload_NAB");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.Nab).HasColumnName("nab");

                entity.Property(e => e.SuspenseUnit).HasColumnName("suspense_unit");
            });

            modelBuilder.Entity<UploadNewParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_NEW_PARTICIPANT");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType).HasColumnName("Address_Type");

                entity.Property(e => e.ApplicationReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Application_Received_date");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.BeneficiaryDob1)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_1");

                entity.Property(e => e.BeneficiaryDob2)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_2");

                entity.Property(e => e.BeneficiaryDob3)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_3");

                entity.Property(e => e.BeneficiaryDob4)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_4");

                entity.Property(e => e.BeneficiaryDob5)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_5");

                entity.Property(e => e.BeneficiaryName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_1");

                entity.Property(e => e.BeneficiaryName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_2");

                entity.Property(e => e.BeneficiaryName3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_3");

                entity.Property(e => e.BeneficiaryName4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_4");

                entity.Property(e => e.BeneficiaryName5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_5");

                entity.Property(e => e.BeneficiaryRelation1).HasColumnName("Beneficiary_Relation_1");

                entity.Property(e => e.BeneficiaryRelation2).HasColumnName("Beneficiary_Relation_2");

                entity.Property(e => e.BeneficiaryRelation3).HasColumnName("Beneficiary_Relation_3");

                entity.Property(e => e.BeneficiaryRelation4).HasColumnName("Beneficiary_Relation_4");

                entity.Property(e => e.BeneficiaryRelation5).HasColumnName("Beneficiary_Relation_5");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Client_Name");

                entity.Property(e => e.CompletedFlag).HasColumnName("Completed_flag");

                entity.Property(e => e.ContributionAmountEr).HasColumnName("Contribution_Amount_ER");

                entity.Property(e => e.ContributionAmountFt).HasColumnName("Contribution_Amount_FT");

                entity.Property(e => e.ContributionAmountMbr).HasColumnName("Contribution_Amount_Mbr");

                entity.Property(e => e.ContributionAmountTu).HasColumnName("Contribution_Amount_TU");

                entity.Property(e => e.ContributionRateEr).HasColumnName("Contribution_Rate_ER");

                entity.Property(e => e.ContributionRateFt).HasColumnName("Contribution_Rate_FT");

                entity.Property(e => e.ContributionRateMbr).HasColumnName("Contribution_Rate_Mbr");

                entity.Property(e => e.ContributionRateTu).HasColumnName("Contribution_Rate_TU");

                entity.Property(e => e.CoverageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Coverage_Date");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DobLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB_Location");

                entity.Property(e => e.EmploymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Employment_Date");

                entity.Property(e => e.EmploymentLevel).HasColumnName("Employment_Level");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FundSource).HasColumnName("Fund_Source");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNumber).HasColumnName("Group_Number");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Number");

                entity.Property(e => e.IdentityType).HasColumnName("Identity_Type");

                entity.Property(e => e.InvestmentRate1).HasColumnName("Investment_Rate_1");

                entity.Property(e => e.InvestmentRate2).HasColumnName("Investment_Rate_2");

                entity.Property(e => e.InvestmentRate3).HasColumnName("Investment_Rate_3");

                entity.Property(e => e.InvestmentRate4).HasColumnName("Investment_Rate_4");

                entity.Property(e => e.InvestmentRate5).HasColumnName("Investment_Rate_5");

                entity.Property(e => e.InvestmentType1).HasColumnName("Investment_Type_1");

                entity.Property(e => e.InvestmentType2).HasColumnName("Investment_Type_2");

                entity.Property(e => e.InvestmentType3).HasColumnName("Investment_Type_3");

                entity.Property(e => e.InvestmentType4).HasColumnName("Investment_Type_4");

                entity.Property(e => e.InvestmentType5).HasColumnName("Investment_Type_5");

                entity.Property(e => e.JobType).HasColumnName("Job_Type");

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Maiden_Name");

                entity.Property(e => e.Mail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.MaritalStatus).HasColumnName("Marital_Status");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Phone");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Office_Phone");

                entity.Property(e => e.OldCerNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_cer_nmbr");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Postal_Code");

                entity.Property(e => e.RetirementAge).HasColumnName("Retirement_Age");

                entity.Property(e => e.SalaryAmount).HasColumnName("Salary_Amount");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name");

                entity.Property(e => e.SumInsured).HasColumnName("Sum_Insured");

                entity.Property(e => e.TaxIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tax_ID_Number");
            });

            modelBuilder.Entity<UploadNewParticipantMoneyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_NEW_PARTICIPANT_MONEY_TYPE");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType).HasColumnName("Address_Type");

                entity.Property(e => e.ApplicationReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Application_Received_date");

                entity.Property(e => e.BeneTypeNmbr).HasColumnName("bene_type_nmbr");

                entity.Property(e => e.BeneficiaryDob1)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_1");

                entity.Property(e => e.BeneficiaryDob2)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_2");

                entity.Property(e => e.BeneficiaryDob3)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_3");

                entity.Property(e => e.BeneficiaryDob4)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_4");

                entity.Property(e => e.BeneficiaryDob5)
                    .HasColumnType("datetime")
                    .HasColumnName("Beneficiary_DOB_5");

                entity.Property(e => e.BeneficiaryName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_1");

                entity.Property(e => e.BeneficiaryName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_2");

                entity.Property(e => e.BeneficiaryName3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_3");

                entity.Property(e => e.BeneficiaryName4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_4");

                entity.Property(e => e.BeneficiaryName5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_5");

                entity.Property(e => e.BeneficiaryRelation1).HasColumnName("Beneficiary_Relation_1");

                entity.Property(e => e.BeneficiaryRelation2).HasColumnName("Beneficiary_Relation_2");

                entity.Property(e => e.BeneficiaryRelation3).HasColumnName("Beneficiary_Relation_3");

                entity.Property(e => e.BeneficiaryRelation4).HasColumnName("Beneficiary_Relation_4");

                entity.Property(e => e.BeneficiaryRelation5).HasColumnName("Beneficiary_Relation_5");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Client_Name");

                entity.Property(e => e.CompletedFlag).HasColumnName("Completed_flag");

                entity.Property(e => e.ContributionAmountEr).HasColumnName("Contribution_Amount_ER");

                entity.Property(e => e.ContributionAmountFt).HasColumnName("Contribution_Amount_FT");

                entity.Property(e => e.ContributionAmountMbr).HasColumnName("Contribution_Amount_Mbr");

                entity.Property(e => e.ContributionAmountTu).HasColumnName("Contribution_Amount_TU");

                entity.Property(e => e.ContributionRateEr).HasColumnName("Contribution_Rate_ER");

                entity.Property(e => e.ContributionRateFt).HasColumnName("Contribution_Rate_FT");

                entity.Property(e => e.ContributionRateMbr).HasColumnName("Contribution_Rate_Mbr");

                entity.Property(e => e.ContributionRateTu).HasColumnName("Contribution_Rate_TU");

                entity.Property(e => e.CoverageDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Coverage_Date");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DobLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB_Location");

                entity.Property(e => e.EmploymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Employment_Date");

                entity.Property(e => e.EmploymentLevel).HasColumnName("Employment_Level");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FundSource).HasColumnName("Fund_Source");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNumber).HasColumnName("Group_Number");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Number");

                entity.Property(e => e.IdentityType).HasColumnName("Identity_Type");

                entity.Property(e => e.InvestmentRate1).HasColumnName("Investment_Rate_1");

                entity.Property(e => e.InvestmentRate10).HasColumnName("Investment_Rate_10");

                entity.Property(e => e.InvestmentRate11).HasColumnName("Investment_Rate_11");

                entity.Property(e => e.InvestmentRate12).HasColumnName("Investment_Rate_12");

                entity.Property(e => e.InvestmentRate13).HasColumnName("Investment_Rate_13");

                entity.Property(e => e.InvestmentRate14).HasColumnName("Investment_Rate_14");

                entity.Property(e => e.InvestmentRate15).HasColumnName("Investment_Rate_15");

                entity.Property(e => e.InvestmentRate2).HasColumnName("Investment_Rate_2");

                entity.Property(e => e.InvestmentRate3).HasColumnName("Investment_Rate_3");

                entity.Property(e => e.InvestmentRate4).HasColumnName("Investment_Rate_4");

                entity.Property(e => e.InvestmentRate5).HasColumnName("Investment_Rate_5");

                entity.Property(e => e.InvestmentRate6).HasColumnName("Investment_Rate_6");

                entity.Property(e => e.InvestmentRate7).HasColumnName("Investment_Rate_7");

                entity.Property(e => e.InvestmentRate8).HasColumnName("Investment_Rate_8");

                entity.Property(e => e.InvestmentRate9).HasColumnName("Investment_Rate_9");

                entity.Property(e => e.InvestmentType1).HasColumnName("Investment_Type_1");

                entity.Property(e => e.InvestmentType10).HasColumnName("Investment_Type_10");

                entity.Property(e => e.InvestmentType11).HasColumnName("Investment_Type_11");

                entity.Property(e => e.InvestmentType12).HasColumnName("Investment_Type_12");

                entity.Property(e => e.InvestmentType13).HasColumnName("Investment_Type_13");

                entity.Property(e => e.InvestmentType14).HasColumnName("Investment_Type_14");

                entity.Property(e => e.InvestmentType15).HasColumnName("Investment_Type_15");

                entity.Property(e => e.InvestmentType2).HasColumnName("Investment_Type_2");

                entity.Property(e => e.InvestmentType3).HasColumnName("Investment_Type_3");

                entity.Property(e => e.InvestmentType4).HasColumnName("Investment_Type_4");

                entity.Property(e => e.InvestmentType5).HasColumnName("Investment_Type_5");

                entity.Property(e => e.InvestmentType6).HasColumnName("Investment_Type_6");

                entity.Property(e => e.InvestmentType7).HasColumnName("Investment_Type_7");

                entity.Property(e => e.InvestmentType8).HasColumnName("Investment_Type_8");

                entity.Property(e => e.InvestmentType9).HasColumnName("Investment_Type_9");

                entity.Property(e => e.JobType).HasColumnName("Job_Type");

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Maiden_Name");

                entity.Property(e => e.Mail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.MaritalStatus).HasColumnName("Marital_Status");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Phone");

                entity.Property(e => e.MoneyType1).HasColumnName("Money_Type_1");

                entity.Property(e => e.MoneyType10).HasColumnName("Money_Type_10");

                entity.Property(e => e.MoneyType11).HasColumnName("Money_Type_11");

                entity.Property(e => e.MoneyType12).HasColumnName("Money_Type_12");

                entity.Property(e => e.MoneyType13).HasColumnName("Money_Type_13");

                entity.Property(e => e.MoneyType14).HasColumnName("Money_Type_14");

                entity.Property(e => e.MoneyType15).HasColumnName("Money_Type_15");

                entity.Property(e => e.MoneyType2).HasColumnName("Money_Type_2");

                entity.Property(e => e.MoneyType3).HasColumnName("Money_Type_3");

                entity.Property(e => e.MoneyType4).HasColumnName("Money_Type_4");

                entity.Property(e => e.MoneyType5).HasColumnName("Money_Type_5");

                entity.Property(e => e.MoneyType6).HasColumnName("Money_Type_6");

                entity.Property(e => e.MoneyType7).HasColumnName("Money_Type_7");

                entity.Property(e => e.MoneyType8).HasColumnName("Money_Type_8");

                entity.Property(e => e.MoneyType9).HasColumnName("Money_Type_9");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Office_Phone");

                entity.Property(e => e.OldCerNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_cer_nmbr");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Postal_Code");

                entity.Property(e => e.RetirementAge).HasColumnName("Retirement_Age");

                entity.Property(e => e.SalaryAmount).HasColumnName("Salary_Amount");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name");

                entity.Property(e => e.SumInsured).HasColumnName("Sum_Insured");

                entity.Property(e => e.TaxIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tax_ID_Number");
            });

            modelBuilder.Entity<UploadPayrollContribution>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_Payroll_contribution");

                entity.Property(e => e.Bulan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CerNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConEe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConEE");

                entity.Property(e => e.ConEr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConER");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("dob");

                entity.Property(e => e.Ft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FT");

                entity.Property(e => e.GroupNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasMaxLength(100)
                    .HasColumnName("hostname");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.Tahun)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TopUp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TopUP");
            });

            modelBuilder.Entity<UploadRollover>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_ROLLOVER");

                entity.Property(e => e.CerNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConEe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConEE");

                entity.Property(e => e.ConEr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConER");

                entity.Property(e => e.ConTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ConTU");

                entity.Property(e => e.Ft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FT");

                entity.Property(e => e.FtType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FT_Type");

                entity.Property(e => e.GroupNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IrEe)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IR_EE");

                entity.Property(e => e.IrEr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IR_ER");

                entity.Property(e => e.IrFt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IR_FT");

                entity.Property(e => e.IrTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IR_TU");

                entity.Property(e => e.PaycenterNbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Paycenter_Nbr");
            });

            modelBuilder.Entity<UploadSuspense>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_SUSPENSE");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.ReceivedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("received_date");

                entity.Property(e => e.RefBank)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ref_Bank");

                entity.Property(e => e.SuspenseDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("suspense_desc");

                entity.Property(e => e.SuspenseType).HasColumnName("suspense_type");
            });

            modelBuilder.Entity<UploadUpdateDeliveryDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_UPDATE_DELIVERY_DATE");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("hostname");

                entity.Property(e => e.KitDeliveryDt)
                    .HasColumnType("datetime")
                    .HasColumnName("kit_delivery_dt");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pic");
            });

            modelBuilder.Entity<UploadUpdateParticipant>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_UPDATE_PARTICIPANT");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Address_Type");

                entity.Property(e => e.ApplicationReceivedDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Application_Received_date");

                entity.Property(e => e.BeneTypeNmbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bene_type_nmbr");

                entity.Property(e => e.BeneficiaryDob1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_1");

                entity.Property(e => e.BeneficiaryDob2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_2");

                entity.Property(e => e.BeneficiaryDob3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_3");

                entity.Property(e => e.BeneficiaryDob4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_4");

                entity.Property(e => e.BeneficiaryDob5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_5");

                entity.Property(e => e.BeneficiaryName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_1");

                entity.Property(e => e.BeneficiaryName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_2");

                entity.Property(e => e.BeneficiaryName3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_3");

                entity.Property(e => e.BeneficiaryName4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_4");

                entity.Property(e => e.BeneficiaryName5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_5");

                entity.Property(e => e.BeneficiaryRelation1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_1");

                entity.Property(e => e.BeneficiaryRelation2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_2");

                entity.Property(e => e.BeneficiaryRelation3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_3");

                entity.Property(e => e.BeneficiaryRelation4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_4");

                entity.Property(e => e.BeneficiaryRelation5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_5");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Certificate_number");

                entity.Property(e => e.Citizenship)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Client_Name");

                entity.Property(e => e.CommisionTypeNmbr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("commision_type_nmbr");

                entity.Property(e => e.CompletedFlag)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Completed_flag");

                entity.Property(e => e.ContributionAmountFt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_FT");

                entity.Property(e => e.ContributionAmountMbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_Mbr");

                entity.Property(e => e.ContributionAmountSpsr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_Spsr");

                entity.Property(e => e.ContributionAmountTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_TU");

                entity.Property(e => e.ContributionRateFt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_FT");

                entity.Property(e => e.ContributionRateMbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_Mbr");

                entity.Property(e => e.ContributionRateSpsr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_Spsr");

                entity.Property(e => e.ContributionRateTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_TU");

                entity.Property(e => e.CoverageDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Coverage_Date");

                entity.Property(e => e.Dob)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.DobLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB_Location");

                entity.Property(e => e.EmploymentDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Employment_Date");

                entity.Property(e => e.EmploymentLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Employment_Level");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FundSource)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fund_Source");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Group_Number");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Number");

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Type");

                entity.Property(e => e.InvestmentEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Efctv_date");

                entity.Property(e => e.InvestmentRate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_1");

                entity.Property(e => e.InvestmentRate2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_2");

                entity.Property(e => e.InvestmentRate3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_3");

                entity.Property(e => e.InvestmentRate4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_4");

                entity.Property(e => e.InvestmentRate5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_5");

                entity.Property(e => e.InvestmentType1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type_1");

                entity.Property(e => e.InvestmentType2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type_2");

                entity.Property(e => e.InvestmentType3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type_3");

                entity.Property(e => e.InvestmentType4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type_4");

                entity.Property(e => e.InvestmentType5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Type_5");

                entity.Property(e => e.JobType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Job_Type");

                entity.Property(e => e.KitDeliveryDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Kit_delivery_date");

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Maiden_Name");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Phone");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Office_Phone");

                entity.Property(e => e.Paycenter)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Postal_Code");

                entity.Property(e => e.PremiumTypeNmbr)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("premium_type_nmbr");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RetirementAge)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Retirement_Age");

                entity.Property(e => e.SalaryAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Amount");

                entity.Property(e => e.SalaryEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Salary_efctv_date");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_name");

                entity.Property(e => e.StatusEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Status_Efctv_date");

                entity.Property(e => e.StatusType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Status_Type");

                entity.Property(e => e.SumInsured)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sum_Insured");

                entity.Property(e => e.SumInsuredEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sum_Insured_efctv_date");

                entity.Property(e => e.TaxIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tax_ID_Number");
            });

            modelBuilder.Entity<UploadUpdateParticipantMoneyType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UPLOAD_UPDATE_PARTICIPANT_MONEY_TYPE");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Address_Type");

                entity.Property(e => e.ApplicationReceivedDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Application_Received_date");

                entity.Property(e => e.BeneTypeNmbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("bene_type_nmbr");

                entity.Property(e => e.BeneficiaryDob1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_1");

                entity.Property(e => e.BeneficiaryDob2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_2");

                entity.Property(e => e.BeneficiaryDob3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_3");

                entity.Property(e => e.BeneficiaryDob4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_4");

                entity.Property(e => e.BeneficiaryDob5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_DOB_5");

                entity.Property(e => e.BeneficiaryName1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_1");

                entity.Property(e => e.BeneficiaryName2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_2");

                entity.Property(e => e.BeneficiaryName3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_3");

                entity.Property(e => e.BeneficiaryName4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_4");

                entity.Property(e => e.BeneficiaryName5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Name_5");

                entity.Property(e => e.BeneficiaryRelation1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_1");

                entity.Property(e => e.BeneficiaryRelation2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_2");

                entity.Property(e => e.BeneficiaryRelation3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_3");

                entity.Property(e => e.BeneficiaryRelation4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_4");

                entity.Property(e => e.BeneficiaryRelation5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Beneficiary_Relation_5");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CertificateNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Certificate_number");

                entity.Property(e => e.Citizenship)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Client_Name");

                entity.Property(e => e.CompletedFlag)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Completed_flag");

                entity.Property(e => e.ContributionAmountFt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_FT");

                entity.Property(e => e.ContributionAmountMbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_Mbr");

                entity.Property(e => e.ContributionAmountSpsr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_Spsr");

                entity.Property(e => e.ContributionAmountTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Amount_TU");

                entity.Property(e => e.ContributionRateFt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_FT");

                entity.Property(e => e.ContributionRateMbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_Mbr");

                entity.Property(e => e.ContributionRateSpsr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_Spsr");

                entity.Property(e => e.ContributionRateTu)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Contribution_Rate_TU");

                entity.Property(e => e.CoverageDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Coverage_Date");

                entity.Property(e => e.Dob)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.DobLocation)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOB_Location");

                entity.Property(e => e.EmploymentDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Employment_Date");

                entity.Property(e => e.EmploymentLevel)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Employment_Level");

                entity.Property(e => e.Fax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FundSource)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Fund_Source");

                entity.Property(e => e.Gender)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Group_Number");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Home_Phone");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Number");

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Identity_Type");

                entity.Property(e => e.InvestmentEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Efctv_date");

                entity.Property(e => e.InvestmentRate1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_1");

                entity.Property(e => e.InvestmentRate10)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_10");

                entity.Property(e => e.InvestmentRate11)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_11");

                entity.Property(e => e.InvestmentRate12)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_12");

                entity.Property(e => e.InvestmentRate13)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_13");

                entity.Property(e => e.InvestmentRate14)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_14");

                entity.Property(e => e.InvestmentRate15)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_15");

                entity.Property(e => e.InvestmentRate2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_2");

                entity.Property(e => e.InvestmentRate3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_3");

                entity.Property(e => e.InvestmentRate4)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_4");

                entity.Property(e => e.InvestmentRate5)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_5");

                entity.Property(e => e.InvestmentRate6)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_6");

                entity.Property(e => e.InvestmentRate7)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_7");

                entity.Property(e => e.InvestmentRate8)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_8");

                entity.Property(e => e.InvestmentRate9)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Investment_Rate_9");

                entity.Property(e => e.InvestmentType1).HasColumnName("Investment_Type_1");

                entity.Property(e => e.InvestmentType10).HasColumnName("Investment_Type_10");

                entity.Property(e => e.InvestmentType11).HasColumnName("Investment_Type_11");

                entity.Property(e => e.InvestmentType12).HasColumnName("Investment_Type_12");

                entity.Property(e => e.InvestmentType13).HasColumnName("Investment_Type_13");

                entity.Property(e => e.InvestmentType14).HasColumnName("Investment_Type_14");

                entity.Property(e => e.InvestmentType15).HasColumnName("Investment_Type_15");

                entity.Property(e => e.InvestmentType2).HasColumnName("Investment_Type_2");

                entity.Property(e => e.InvestmentType3).HasColumnName("Investment_Type_3");

                entity.Property(e => e.InvestmentType4).HasColumnName("Investment_Type_4");

                entity.Property(e => e.InvestmentType5).HasColumnName("Investment_Type_5");

                entity.Property(e => e.InvestmentType6).HasColumnName("Investment_Type_6");

                entity.Property(e => e.InvestmentType7).HasColumnName("Investment_Type_7");

                entity.Property(e => e.InvestmentType8).HasColumnName("Investment_Type_8");

                entity.Property(e => e.InvestmentType9).HasColumnName("Investment_Type_9");

                entity.Property(e => e.JobType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Job_Type");

                entity.Property(e => e.KitDeliveryDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Kit_delivery_date");

                entity.Property(e => e.MaidenName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Maiden_Name");

                entity.Property(e => e.Mail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Mobile_Phone");

                entity.Property(e => e.MoneyType1).HasColumnName("Money_Type_1");

                entity.Property(e => e.MoneyType10).HasColumnName("Money_Type_10");

                entity.Property(e => e.MoneyType11).HasColumnName("Money_Type_11");

                entity.Property(e => e.MoneyType12).HasColumnName("Money_Type_12");

                entity.Property(e => e.MoneyType13).HasColumnName("Money_Type_13");

                entity.Property(e => e.MoneyType14).HasColumnName("Money_Type_14");

                entity.Property(e => e.MoneyType15).HasColumnName("Money_Type_15");

                entity.Property(e => e.MoneyType2).HasColumnName("Money_Type_2");

                entity.Property(e => e.MoneyType3).HasColumnName("Money_Type_3");

                entity.Property(e => e.MoneyType4).HasColumnName("Money_Type_4");

                entity.Property(e => e.MoneyType5).HasColumnName("Money_Type_5");

                entity.Property(e => e.MoneyType6).HasColumnName("Money_Type_6");

                entity.Property(e => e.MoneyType7).HasColumnName("Money_Type_7");

                entity.Property(e => e.MoneyType8).HasColumnName("Money_Type_8");

                entity.Property(e => e.MoneyType9).HasColumnName("Money_Type_9");

                entity.Property(e => e.Nip)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.OfficePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Office_Phone");

                entity.Property(e => e.Paycenter)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Postal_Code");

                entity.Property(e => e.Province)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RetirementAge)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Retirement_Age");

                entity.Property(e => e.SalaryAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Amount");

                entity.Property(e => e.SalaryEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Salary_efctv_date");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_name");

                entity.Property(e => e.StatusEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Status_Efctv_date");

                entity.Property(e => e.StatusType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Status_Type");

                entity.Property(e => e.SumInsured)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sum_Insured");

                entity.Property(e => e.SumInsuredEfctvDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Sum_Insured_efctv_date");

                entity.Property(e => e.TaxIdNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Tax_ID_Number");
            });

            modelBuilder.Entity<Uploadlumpsum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("uploadlumpsum$");

                entity.Property(e => e.Fee).HasColumnType("money");

                entity.Property(e => e.NamaBank)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Bank");

                entity.Property(e => e.NamaPenerima)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Penerima");

                entity.Property(e => e.NamaPeserta)
                    .HasMaxLength(255)
                    .HasColumnName("Nama Peserta");

                entity.Property(e => e.NoPeserta).HasColumnName("No Peserta");

                entity.Property(e => e.NomorRekening)
                    .HasMaxLength(255)
                    .HasColumnName("Nomor Rekening");
            });

            modelBuilder.Entity<UsrActvy>(entity =>
            {
                entity.HasKey(e => new { e.UsrId, e.ActvyDt });

                entity.ToTable("usr_actvy");

                entity.Property(e => e.UsrId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("usr_id");

                entity.Property(e => e.ActvyDt)
                    .HasColumnType("datetime")
                    .HasColumnName("actvy_dt");

                entity.Property(e => e.ActvyNm)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("actvy_nm");
            });

            modelBuilder.Entity<UsrLst>(entity =>
            {
                entity.HasKey(e => new { e.ProdTypeNum, e.JobFcnNum, e.UsrId })
                    .HasName("PK_usr_list");

                entity.ToTable("usr_lst");

                entity.Property(e => e.ProdTypeNum).HasColumnName("prod_type_num");

                entity.Property(e => e.JobFcnNum).HasColumnName("job_fcn_num");

                entity.Property(e => e.UsrId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_id");

                entity.Property(e => e.ExpireDt)
                    .HasColumnType("datetime")
                    .HasColumnName("expire_dt");

                entity.Property(e => e.LastChngDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_chng_dt");

                entity.Property(e => e.LockedFlg)
                    .HasColumnName("locked_flg")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UsrNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("usr_nm");
            });

            modelBuilder.Entity<VClaimRequest1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CLAIM_REQUEST_1");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY NAME");

                entity.Property(e => e.Dob)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REG ID");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SALES NAME");

                entity.Property(e => e.TakenBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAKEN BY");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS TYPE");

                entity.Property(e => e.TrnsId).HasColumnName("TRNS ID");
            });

            modelBuilder.Entity<VClaimRequest2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CLAIM_REQUEST_2");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY NAME");

                entity.Property(e => e.Dob)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REG ID");

                entity.Property(e => e.TakenBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAKEN BY");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS TYPE");

                entity.Property(e => e.TrnsId).HasColumnName("TRNS ID");
            });

            modelBuilder.Entity<VClaimRequest3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CLAIM_REQUEST_3");

                entity.Property(e => e.Batch)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BATCH");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY NAME");

                entity.Property(e => e.Dob)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REG ID");

                entity.Property(e => e.TakenBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAKEN BY");

                entity.Property(e => e.TheDate).HasColumnType("datetime");

                entity.Property(e => e.TheDate1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("THE DATE");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS TYPE");

                entity.Property(e => e.TrnsId).HasColumnName("TRNS ID");
            });

            modelBuilder.Entity<VClaimRequest4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CLAIM_REQUEST_4");

                entity.Property(e => e.Batch)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BATCH");

                entity.Property(e => e.ClaimStatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLAIM STATUS");

                entity.Property(e => e.CompanyId).HasColumnName("COMPANY ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY NAME");

                entity.Property(e => e.Dob)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("DOB");

                entity.Property(e => e.Name)
                    .HasMaxLength(117)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("REG ID");

                entity.Property(e => e.TakenBy)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TAKEN BY");

                entity.Property(e => e.TheDate).HasColumnType("datetime");

                entity.Property(e => e.TheDate1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("THE DATE");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRANS TYPE");

                entity.Property(e => e.TrnsId).HasColumnName("TRNS ID");
            });

            modelBuilder.Entity<VDplkRider>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DPLK_RIDER");

                entity.Property(e => e.AlamatEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("alamat_email");

                entity.Property(e => e.AlamatPeserta)
                    .HasMaxLength(452)
                    .IsUnicode(false)
                    .HasColumnName("alamat_peserta");

                entity.Property(e => e.BillingPeriode)
                    .HasColumnType("datetime")
                    .HasColumnName("billing_periode");

                entity.Property(e => e.Deskripsi)
                    .HasMaxLength(4000)
                    .HasColumnName("deskripsi");

                entity.Property(e => e.FundAllocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fund_allocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JenisKomisi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_komisi");

                entity.Property(e => e.JenisPremi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jenis_premi");

                entity.Property(e => e.JenisRider)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_rider");

                entity.Property(e => e.JumlahValuasi).HasColumnName("Jumlah_valuasi");

                entity.Property(e => e.KdPerusahaan).HasColumnName("kd_perusahaan");

                entity.Property(e => e.KodePeserta).HasColumnName("kode_peserta");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(4000)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NomorCrv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_CRV");

                entity.Property(e => e.NomorFlp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_FLP");

                entity.Property(e => e.NomorPegawai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("nomor_pegawai");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TanggalJurnal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tanggal_jurnal");

                entity.Property(e => e.TanggalLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_lahir");

                entity.Property(e => e.TanggalMulai)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_mulai");

                entity.Property(e => e.TanggalPensiun)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_pensiun");

                entity.Property(e => e.TanggalValuasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_valuasi");
            });

            modelBuilder.Entity<VKomisiDplkRider>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_KOMISI_DPLK_RIDER");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.DanaAwal).HasColumnName("dana_awal");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.FlagKomisi).HasColumnName("flag_komisi");

                entity.Property(e => e.Iuran).HasColumnName("iuran");

                entity.Property(e => e.JenisKomisi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_komisi");

                entity.Property(e => e.JenisPremi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jenis_premi");

                entity.Property(e => e.JenisRider)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_rider");

                entity.Property(e => e.JumlahValuasi).HasColumnName("Jumlah_valuasi");

                entity.Property(e => e.KdPerusahaan).HasColumnName("kd_perusahaan");

                entity.Property(e => e.KodePeserta).HasColumnName("kode_peserta");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(4000)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NomorCrv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_CRV");

                entity.Property(e => e.NomorFlp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_FLP");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.PremiSetahun).HasColumnName("premi_setahun");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name");

                entity.Property(e => e.TahunKomisi)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("tahun_komisi");

                entity.Property(e => e.TanggalValuasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_valuasi");

                entity.Property(e => e.TglEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_entry");
            });

            modelBuilder.Entity<VKomisiDplkRiderBck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_KOMISI_DPLK_RIDER_Bck");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.DanaAwal).HasColumnName("dana_awal");

                entity.Property(e => e.FlagKomisi).HasColumnName("flag_komisi");

                entity.Property(e => e.Iuran).HasColumnName("iuran");

                entity.Property(e => e.JenisKomisi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_komisi");

                entity.Property(e => e.JenisPremi)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("jenis_premi");

                entity.Property(e => e.JenisRider)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("jenis_rider");

                entity.Property(e => e.JumlahValuasi).HasColumnName("Jumlah_valuasi");

                entity.Property(e => e.KdPerusahaan).HasColumnName("kd_perusahaan");

                entity.Property(e => e.KodePeserta).HasColumnName("kode_peserta");

                entity.Property(e => e.NamaPerusahaan)
                    .HasMaxLength(4000)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.NamaPeserta)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_peserta");

                entity.Property(e => e.NomorCrv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_CRV");

                entity.Property(e => e.NomorFlp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nomor_FLP");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sales_Name");

                entity.Property(e => e.TahunKomisi)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("tahun_komisi");

                entity.Property(e => e.TanggalValuasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_valuasi");

                entity.Property(e => e.TglEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_entry");
            });

            modelBuilder.Entity<VaCurrencyType>(entity =>
            {
                entity.HasKey(e => e.VaNmbr);

                entity.ToTable("va_currency_type");

                entity.Property(e => e.VaNmbr)
                    .HasMaxLength(50)
                    .HasColumnName("va_nmbr");

                entity.Property(e => e.CurrencyTypeNmbr)
                    .HasMaxLength(50)
                    .HasColumnName("currency_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<VaDplkType>(entity =>
            {
                entity.HasKey(e => e.VaNmbr);

                entity.ToTable("va_dplk_type");

                entity.Property(e => e.VaNmbr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("va_nmbr");

                entity.Property(e => e.DplkNmbr).HasColumnName("dplk_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<VaGroup>(entity =>
            {
                entity.HasKey(e => e.VaAccnNmbr);

                entity.ToTable("va_group");

                entity.Property(e => e.VaAccnNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("va_accn_nmbr");

                entity.Property(e => e.ActiveDt)
                    .HasColumnType("datetime")
                    .HasColumnName("active_dt");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.CreateDt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_dt");

                entity.Property(e => e.DeletedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("deleted_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isdeleted).HasColumnName("isdeleted");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");
            });

            modelBuilder.Entity<VaProductType>(entity =>
            {
                entity.HasKey(e => e.VaNmbr);

                entity.ToTable("va_product_type");

                entity.Property(e => e.VaNmbr)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("va_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("product_type_nmbr");
            });

            modelBuilder.Entity<VestingType>(entity =>
            {
                entity.HasKey(e => e.VestTypeNmbr);

                entity.ToTable("vesting_type");

                entity.Property(e => e.VestTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("vest_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.VestTypeNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("vest_type_nm");
            });

            modelBuilder.Entity<ViewAssetPesertum>(entity =>
            {
                entity.HasKey(e => new { e.CerNmbr, e.MoneyTypeNmbr, e.InvTypeNmbr });

                entity.ToTable("view_asset_peserta");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.MoneyTypeNmbr).HasColumnName("money_type_nmbr");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.AcctVal).HasColumnName("acct_val");

                entity.Property(e => e.Contrib).HasColumnName("contrib");

                entity.Property(e => e.Distrib).HasColumnName("distrib");

                entity.Property(e => e.Earning).HasColumnName("earning");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.NetContrib).HasColumnName("net_contrib");

                entity.Property(e => e.PeriodDt)
                    .HasColumnType("datetime")
                    .HasColumnName("period_dt");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<ViewIndAkumulasiIuran>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_akumulasi_iuran");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.MoneyTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<ViewIndAkumulasiPenarikan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_akumulasi_Penarikan");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.MoneyTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<ViewIndClaimTracker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_claim_tracker");

                entity.Property(e => e.AnuitasAmt).HasColumnName("anuitas_amt");

                entity.Property(e => e.BankAnuitas)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Bank_anuitas");

                entity.Property(e => e.BankLumpsum)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("Bank_lumpsum");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.KodeRegistrasi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Kode_registrasi");

                entity.Property(e => e.LumpsumAmt).HasColumnName("Lumpsum_amt");

                entity.Property(e => e.NetAmt).HasColumnName("net_amt");

                entity.Property(e => e.PersetujuanRegistrasi)
                    .HasColumnType("datetime")
                    .HasColumnName("persetujuan_registrasi");

                entity.Property(e => e.PersetujuanTransfer)
                    .HasColumnType("datetime")
                    .HasColumnName("persetujuan_transfer");

                entity.Property(e => e.RegisterClaim)
                    .HasColumnType("datetime")
                    .HasColumnName("register_claim");

                entity.Property(e => e.RekAnuitas)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("rek_anuitas");

                entity.Property(e => e.RekLumpsum)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("rek_lumpsum");

                entity.Property(e => e.RekNameAnuitas)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("rek_name_anuitas");

                entity.Property(e => e.RekNameLumpsum)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("rek_name_lumpsum");

                entity.Property(e => e.SiapDiProses)
                    .HasColumnType("datetime")
                    .HasColumnName("siap_di_proses");

                entity.Property(e => e.Tax).HasColumnName("tax");
            });

            modelBuilder.Entity<ViewIndHargaUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_harga_unit");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<ViewIndPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_peserta");

                entity.Property(e => e.AddrTypeNm)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("addr_type_nm");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.BeneNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bene_nm");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyCode).HasColumnName("company_code");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_addr");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.IdentityNmbr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("identity_nmbr");

                entity.Property(e => e.MaidenNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("maiden_nm");

                entity.Property(e => e.MobilePhoneNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_phone_nmbr");

                entity.Property(e => e.PostalCd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("postal_cd");

                entity.Property(e => e.ProvinceNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("province_nm");

                entity.Property(e => e.ProvinceNmbr).HasColumnName("province_nmbr");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");
            });

            modelBuilder.Entity<ViewIndPilihanInvestasi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_pilihan_investasi");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.InvTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.MoneyTypeNm)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("money_type_nm");

                entity.Property(e => e.Percentage).HasColumnName("percentage");
            });

            modelBuilder.Entity<ViewIndSaldoPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ind_saldo_peserta");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.Harga).HasColumnName("harga");

                entity.Property(e => e.InvTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.InvTypeNmbr).HasColumnName("inv_type_nmbr");

                entity.Property(e => e.SaldoValuasi).HasColumnName("saldo_valuasi");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<ViewIuran>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_iuran");

                entity.Property(e => e.AsalDanaDari)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("asal_dana_dari");

                entity.Property(e => e.DeskripsiBankTransfer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("deskripsi_bank_transfer");

                entity.Property(e => e.JumlahDana)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("jumlah_dana");

                entity.Property(e => e.PeriodeIuran)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("periode_iuran");

                entity.Property(e => e.Proses)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("proses");

                entity.Property(e => e.TanggalAlokasi)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("tanggal_alokasi");

                entity.Property(e => e.TanggalProcess)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("tanggal_process");

                entity.Property(e => e.TglTerimaDana)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("tgl_terima_dana");
            });

            modelBuilder.Entity<ViewIuranInvest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_iuran_invest");

                entity.Property(e => e.AsalDanaDari)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("asal_dana_dari");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.DeskripsiBankTransfer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("deskripsi_bank_transfer");

                entity.Property(e => e.JumlahDana)
                    .HasColumnType("money")
                    .HasColumnName("jumlah_dana");

                entity.Property(e => e.PeriodeIuran)
                    .HasColumnType("datetime")
                    .HasColumnName("periode_iuran");

                entity.Property(e => e.Proses)
                    .HasColumnType("datetime")
                    .HasColumnName("proses");

                entity.Property(e => e.TanggalAlokasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_alokasi");

                entity.Property(e => e.TanggalProcess)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_process");

                entity.Property(e => e.TglTerimaDana)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_terima_dana");
            });

            modelBuilder.Entity<ViewIuranInvestVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_iuran_invest_vw");

                entity.Property(e => e.AsalDanaDari)
                    .IsRequired()
                    .HasMaxLength(125)
                    .IsUnicode(false)
                    .HasColumnName("asal_dana_dari");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.DeskripsiBankTransfer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("deskripsi_bank_transfer");

                entity.Property(e => e.JumlahDana)
                    .HasColumnType("money")
                    .HasColumnName("jumlah_dana");

                entity.Property(e => e.PeriodeIuran)
                    .HasColumnType("datetime")
                    .HasColumnName("periode_iuran");

                entity.Property(e => e.Proses)
                    .HasColumnType("datetime")
                    .HasColumnName("proses");

                entity.Property(e => e.TanggalAlokasi)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_alokasi");

                entity.Property(e => e.TanggalProcess)
                    .HasColumnType("datetime")
                    .HasColumnName("tanggal_process");

                entity.Property(e => e.TglTerimaDana)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_terima_dana");
            });

            modelBuilder.Entity<ViewKlaimPaid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_klaim_paid");

                entity.Property(e => e.AnActnm)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("an_actnm");

                entity.Property(e => e.AnActno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("an_actno");

                entity.Property(e => e.AnAmt).HasColumnName("an_amt");

                entity.Property(e => e.AnBank)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("an_bank");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LsActnm)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ls_actnm");

                entity.Property(e => e.LsActno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ls_actno");

                entity.Property(e => e.LsAmt).HasColumnName("ls_amt");

                entity.Property(e => e.LsBank)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ls_bank");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<ViewKlaimRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_klaim_register");

                entity.Property(e => e.AnActnm)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("an_actnm");

                entity.Property(e => e.AnActno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("an_actno");

                entity.Property(e => e.AnAmt).HasColumnName("an_amt");

                entity.Property(e => e.AnBank)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("an_bank");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FeeAmt).HasColumnName("fee_amt");

                entity.Property(e => e.GrossAmt).HasColumnName("gross_amt");

                entity.Property(e => e.LsActnm)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ls_actnm");

                entity.Property(e => e.LsActno)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ls_actno");

                entity.Property(e => e.LsAmt).HasColumnName("ls_amt");

                entity.Property(e => e.LsBank)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ls_bank");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TaxAmt).HasColumnName("tax_amt");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsSeqNmbr).HasColumnName("trns_seq_nmbr");
            });

            modelBuilder.Entity<ViewPesertaDplk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_peserta_dplk");

                entity.Property(e => e.Address)
                    .HasMaxLength(783)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.ApuPpt)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("APU PPT");

                entity.Property(e => e.BirthDt)
                    .HasColumnType("datetime")
                    .HasColumnName("birth_dt");

                entity.Property(e => e.Branch)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("branch");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CitizenshipNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("citizenship_nm");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.ClientNmbr).HasColumnName("client_nmbr");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.DobPlace)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("dob_place");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmailAddr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_addr");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.IdentityNmbr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("identity_nmbr");

                entity.Property(e => e.MaritalStatusNm)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("marital_status_nm");

                entity.Property(e => e.MaturityDt)
                    .HasColumnType("datetime")
                    .HasColumnName("maturity_dt");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mobile_phone");

                entity.Property(e => e.Passwd)
                    .HasMaxLength(255)
                    .HasColumnName("passwd");

                entity.Property(e => e.ProductType).HasColumnName("product_type");

                entity.Property(e => e.ProductTypeNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_type_nm");

                entity.Property(e => e.RetirementAge).HasColumnName("retirement_age");

                entity.Property(e => e.RetirementDt)
                    .HasColumnType("datetime")
                    .HasColumnName("retirement_dt");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_name");

                entity.Property(e => e.StatusEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("status_efctv_dt");

                entity.Property(e => e.StatusTypeNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("status_type_nm");

                entity.Property(e => e.StatusTypeNmbr).HasColumnName("status_type_nmbr");

                entity.Property(e => e.TaxIdNmbr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tax_id_nmbr");

                entity.Property(e => e.TglLahir)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("tgl_lahir");

                entity.Property(e => e.UsiaMasuk).HasColumnName("usia_masuk");
            });

            modelBuilder.Entity<ViewTblCorMasterList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_tbl_cor_master_list");

                entity.Property(e => e.AdminFeeDanLainnya).HasColumnName("admin_fee_dan_lainnya");

                entity.Property(e => e.HasilInvestasiDppk).HasColumnName("hasil_investasi_DPPK");

                entity.Property(e => e.HasilInvestasiPerusahaan).HasColumnName("hasil_investasi_Perusahaan");

                entity.Property(e => e.HasilInvestasiPeserta).HasColumnName("hasil_investasi_peserta");

                entity.Property(e => e.HasilInvestasiTambahan).HasColumnName("hasil_investasi_Tambahan");

                entity.Property(e => e.KumDanaAwalInvestasiPerusahaan).HasColumnName("kum_dana_awal_investasi_Perusahaan");

                entity.Property(e => e.KumDanaAwalInvestasiPeserta).HasColumnName("kum_dana_awal_investasi_peserta");

                entity.Property(e => e.KumDanaAwalIuranPerusahaan).HasColumnName("kum_dana_awal_iuran_Perusahaan");

                entity.Property(e => e.KumDanaAwalIuranPeserta).HasColumnName("kum_dana_awal_iuran_peserta");

                entity.Property(e => e.KumDppk).HasColumnName("kum_DPPK");

                entity.Property(e => e.KumManfaat).HasColumnName("Kum_manfaat");

                entity.Property(e => e.KumpulanIuranPerusahaan).HasColumnName("kumpulan_iuran_perusahaan");

                entity.Property(e => e.KumpulanIuranPeserta).HasColumnName("kumpulan_iuran_peserta");

                entity.Property(e => e.Lokasi)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("lokasi");

                entity.Property(e => e.NamaPegawai)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_pegawai");

                entity.Property(e => e.NamaPerusahaan)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_perusahaan");

                entity.Property(e => e.Nip)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("nip");

                entity.Property(e => e.NoPeserta).HasColumnName("no_peserta");

                entity.Property(e => e.NoPesertaLama)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("no_peserta_lama");

                entity.Property(e => e.PeriodeKeuangan)
                    .HasColumnType("datetime")
                    .HasColumnName("periode_keuangan");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.TglLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_lahir");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            modelBuilder.Entity<ViewTblCorPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_tbl_cor_peserta");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.DanaAwalDppk).HasColumnName("Dana_Awal_DPPK");

                entity.Property(e => e.DanaAwalInvestasiPerusahaan).HasColumnName("Dana_Awal_Investasi_Perusahaan");

                entity.Property(e => e.DanaAwalInvestasiPeserta).HasColumnName("Dana_Awal_Investasi_Peserta");

                entity.Property(e => e.DanaAwalPerusahaan).HasColumnName("Dana_Awal_Perusahaan");

                entity.Property(e => e.DanaAwalPeserta).HasColumnName("Dana_Awal_Peserta");

                entity.Property(e => e.DanaAwalTambahan).HasColumnName("Dana_Awal_Tambahan");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.IuranDppk).HasColumnName("Iuran_DPPK");

                entity.Property(e => e.IuranKaryawan).HasColumnName("Iuran_karyawan");

                entity.Property(e => e.IuranPerusahaan).HasColumnName("Iuran_perusahaan");

                entity.Property(e => e.IuranTambahan).HasColumnName("Iuran_Tambahan");

                entity.Property(e => e.TotalAsetKelolaan).HasColumnName("Total_Aset_Kelolaan");

                entity.Property(e => e.TotalKaryawanAlih).HasColumnName("Total_Karyawan_Alih");

                entity.Property(e => e.TotalKaryawanPensiun).HasColumnName("Total_Karyawan_Pensiun");

                entity.Property(e => e.TotalParticipant).HasColumnName("Total_Participant");

                entity.Property(e => e.TotalPembayaranPensiun).HasColumnName("Total_Pembayaran_Pensiun");
            });

            modelBuilder.Entity<VirtualAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("virtual_account");

                entity.Property(e => e.CerNmbr)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.VAccNmbr)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("v_acc_nmbr");
            });

            modelBuilder.Entity<VuPesertum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vu_peserta");

                entity.Property(e => e.AlamatPeserta)
                    .HasMaxLength(535)
                    .IsUnicode(false)
                    .HasColumnName("ALAMAT_PESERTA");

                entity.Property(e => e.KodePerusahaan).HasColumnName("KODE_PERUSAHAAN");

                entity.Property(e => e.KodePeserta).HasColumnName("KODE_PESERTA");

                entity.Property(e => e.KodePos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("KODE_POS");

                entity.Property(e => e.NamaIbuKandung)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("NAMA_IBU_KANDUNG");

                entity.Property(e => e.NamaPerusahaan)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("NAMA_PERUSAHAAN");

                entity.Property(e => e.NamaPeserta)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("NAMA_PESERTA");

                entity.Property(e => e.TanggalLahir)
                    .HasColumnType("datetime")
                    .HasColumnName("TANGGAL_LAHIR");

                entity.Property(e => e.TanggalMulai)
                    .HasColumnType("datetime")
                    .HasColumnName("TANGGAL_MULAI");

                entity.Property(e => e.TanggalPensiun)
                    .HasColumnType("datetime")
                    .HasColumnName("TANGGAL_PENSIUN");

                entity.Property(e => e.Telpon)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELPON");
            });

            modelBuilder.Entity<VwCashBasisGroupCommission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_cash_basis_group_commission");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CntrbEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("cntrb_efctv_dt");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Iuran).HasColumnName("iuran");

                entity.Property(e => e.Komisi1).HasColumnName("komisi_1");

                entity.Property(e => e.Komisi2).HasColumnName("komisi_2");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_name");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<VwKomisiCashBasisIndividu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Komisi_Cash_Basis_Individu");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.ContribAmont).HasColumnName("contrib_amont");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.Komisi).HasColumnName("komisi");

                entity.Property(e => e.OldAgentNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_agent_nmbr");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<VwKomisiDplk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Komisi_DPLK");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ID_AGEN");

                entity.Property(e => e.IdRegistrasi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_registrasi");

                entity.Property(e => e.NamaAgen)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("nama_agen");

                entity.Property(e => e.NamaDanaPensiun)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Dana_Pensiun");

                entity.Property(e => e.NamaPemohon)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Pemohon");

                entity.Property(e => e.NilaiIuran).HasColumnName("Nilai_Iuran");

                entity.Property(e => e.NoCdv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_cdv");

                entity.Property(e => e.TanggalBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_bayar");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<VwKomisiGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Komisi_Group");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CntrbSeqNmbr).HasColumnName("cntrb_seq_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.FlagKomisi1).HasColumnName("flag_komisi_1");

                entity.Property(e => e.FlagKomisi2).HasColumnName("flag_komisi_2");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id_agen");

                entity.Property(e => e.KomisiTahun1).HasColumnName("komisi_tahun_1");

                entity.Property(e => e.KomisiTahun2).HasColumnName("komisi_tahun_2");

                entity.Property(e => e.NamaDanaPensiun)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_dana_pensiun");

                entity.Property(e => e.NamaPemohon)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("nama_pemohon");

                entity.Property(e => e.NilaiDanaAwal).HasColumnName("nilai_dana_awal");

                entity.Property(e => e.NilaiIuran).HasColumnName("nilai_iuran");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<VwKomisiPengalihan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Komisi_Pengalihan");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ID_AGEN");

                entity.Property(e => e.IdRegistrasi)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Id_registrasi");

                entity.Property(e => e.NamaDanaPensiun)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Dana_Pensiun");

                entity.Property(e => e.NamaPemohon)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("Nama_Pemohon");

                entity.Property(e => e.NameAgen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_agen");

                entity.Property(e => e.NilaiIuran).HasColumnName("Nilai_Iuran");

                entity.Property(e => e.NoCdv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No_cdv");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.TanggalBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("Tanggal_bayar");

                entity.Property(e => e.TglEntry)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_entry");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");
            });

            modelBuilder.Entity<VwKomisiPesertaMandiri>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_Komisi_Peserta_Mandiri");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.FlagKomisi1).HasColumnName("flag_komisi_1");

                entity.Property(e => e.FlagKomisi2).HasColumnName("flag_komisi_2");

                entity.Property(e => e.IdAgen)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id_agen");

                entity.Property(e => e.KomisiTahun1).HasColumnName("komisi_tahun_1");

                entity.Property(e => e.KomisiTahun2).HasColumnName("komisi_tahun_2");

                entity.Property(e => e.NamaAgen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_agen");

                entity.Property(e => e.NamaDanaPensiun)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_dana_pensiun");

                entity.Property(e => e.NamaPemohon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nama_pemohon");

                entity.Property(e => e.NilaiDanaAwal).HasColumnName("nilai_dana_awal");

                entity.Property(e => e.NilaiIuran).HasColumnName("nilai_iuran");

                entity.Property(e => e.PersenKomisi).HasColumnName("persen_komisi");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");

                entity.Property(e => e.TglBayar)
                    .HasColumnType("datetime")
                    .HasColumnName("tgl_bayar");
            });

            modelBuilder.Entity<VwSuratPengantarKartuPerusahaan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_surat_pengantar_kartu_perusahaan");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address2");

                entity.Property(e => e.Address3)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("address3");

                entity.Property(e => e.BirthDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("birth_dt");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.ClientNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("client_nm");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_person");

                entity.Property(e => e.EfctvDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EmployeeNmbr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_nmbr");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.RetireDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("retire_dt");
            });

            modelBuilder.Entity<VwTransPertamina>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_trans_pertamina");

                entity.Property(e => e.CerNmbr).HasColumnName("cer_nmbr");

                entity.Property(e => e.CompanyNm)
                    .IsRequired()
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Cycledt)
                    .HasColumnType("datetime")
                    .HasColumnName("cycledt");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.TrnsHstEfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_hst_efctv_dt");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<VwYearlyGroupCommission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_yearly_group_commission");

                entity.Property(e => e.AdminFee).HasColumnName("admin_fee");

                entity.Property(e => e.CommisionFlg).HasColumnName("commision_flg");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("end_date");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.JumlahIuran).HasColumnName("jumlah_iuran");

                entity.Property(e => e.Komisi).HasColumnName("komisi");

                entity.Property(e => e.SalesName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sales_name");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");
            });

            modelBuilder.Entity<WdAccumulator>(entity =>
            {
                entity.HasKey(e => new { e.GroupNmbr, e.EfctvDt })
                    .HasName("PK__wd_accumulator__0618D7E0");

                entity.ToTable("wd_accumulator");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.EfctvDt)
                    .HasColumnType("datetime")
                    .HasColumnName("efctv_dt");

                entity.Property(e => e.ActVal).HasColumnName("act_val");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.SurrdrAmt).HasColumnName("surrdr_amt");

                entity.Property(e => e.WdAmt).HasColumnName("wd_amt");

                entity.HasOne(d => d.GroupNmbrNavigation)
                    .WithMany(p => p.WdAccumulators)
                    .HasForeignKey(d => d.GroupNmbr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_wd_accumulator_group_nmbr");
            });

            modelBuilder.Entity<WdDocList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wd_doc_list");

                entity.Property(e => e.SeqNmbr).HasColumnName("seq_nmbr");

                entity.Property(e => e.WdDocNmbr).HasColumnName("wd_doc_nmbr");
            });

            modelBuilder.Entity<WdDocSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wd_doc_setup");

                entity.Property(e => e.ProductTypeNmbr).HasColumnName("product_Type_nmbr");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.WdDocNmbr).HasColumnName("wd_doc_nmbr");
            });

            modelBuilder.Entity<WdDocType>(entity =>
            {
                entity.HasKey(e => e.WdDocNmbr)
                    .HasName("PK__wd_doc_type__3EDC53F0");

                entity.ToTable("wd_doc_type");

                entity.Property(e => e.WdDocNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("wd_doc_nmbr");

                entity.Property(e => e.AcronymNm)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("acronym_nm");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.WdDocNm)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("wd_doc_nm");
            });

            modelBuilder.Entity<WdStatusType>(entity =>
            {
                entity.HasKey(e => e.WdStatusNmbr)
                    .HasName("PK__wd_status_type__2610A626");

                entity.ToTable("wd_status_type");

                entity.Property(e => e.WdStatusNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("wd_status_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_Dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.WdStatusNm)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("wd_status_nm");
            });

            modelBuilder.Entity<WdTransferType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("wd_transfer_type");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.WdTransferNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("wd_transfer_nm");

                entity.Property(e => e.WdTransferNmbr).HasColumnName("wd_transfer_nmbr");
            });

            modelBuilder.Entity<WithSourceType>(entity =>
            {
                entity.HasKey(e => e.WithSrcTypeNmbr)
                    .HasName("PK__with_source_type__68A93BE1")
                    .IsClustered(false);

                entity.ToTable("with_source_type");

                entity.Property(e => e.WithSrcTypeNmbr)
                    .ValueGeneratedNever()
                    .HasColumnName("with_src_type_nmbr");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.OldTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("old_type_nmbr");

                entity.Property(e => e.WithSrcTypeNm)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("with_src_type_nm");
            });

            modelBuilder.Entity<XJurnalPosting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("xJurnalPosting");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Dc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GL_code");

                entity.Property(e => e.LastChangeDt)
                    .HasColumnType("datetime")
                    .HasColumnName("last_change_dt");

                entity.Property(e => e.Remark1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("remark1");

                entity.Property(e => e.Remark2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("remark2");

                entity.Property(e => e.TrnsDt)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_dt");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nmbr");

                entity.Property(e => e.UserNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_nm");
            });

            modelBuilder.Entity<YearlyCommissionFlag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("yearly_commission_flag");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GroupNmbr).HasColumnName("group_nmbr");

                entity.Property(e => e.KodeKomisi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("kode_komisi");

                entity.Property(e => e.TahunKe).HasColumnName("tahun_ke");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
