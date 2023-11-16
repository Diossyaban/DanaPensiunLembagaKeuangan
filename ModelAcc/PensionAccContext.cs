using System;
using DPLK.ModelAcc.dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DPLK.ModelAcc
{
    public partial class PensionAccContext : DbContext
    {
        public PensionAccContext()
        {
        }

        public PensionAccContext(DbContextOptions<PensionAccContext> options)
            : base(options)
        {
        }
        public DbSet<FundData> FundDatas { get; set; }

        public virtual DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public virtual DbSet<Cashcode> Cashcodes { get; set; }
        public virtual DbSet<CategorySalesFor1997> CategorySalesFor1997s { get; set; }
        public virtual DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public virtual DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public virtual DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public virtual DbSet<OrdersQry> OrdersQries { get; set; }
        public virtual DbSet<ProductSalesFor1997> ProductSalesFor1997s { get; set; }
        public virtual DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public virtual DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public virtual DbSet<QuarterlyOrder> QuarterlyOrders { get; set; }
        public virtual DbSet<RfUrl> RfUrls { get; set; }
        public virtual DbSet<SalesByCategory> SalesByCategories { get; set; }
        public virtual DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public virtual DbSet<Sheet1> Sheet1s { get; set; }
        public virtual DbSet<SpdAccgl> SpdAccgls { get; set; }
        public virtual DbSet<SpdBankFund> SpdBankFunds { get; set; }
        public virtual DbSet<SpdBankMaster> SpdBankMasters { get; set; }
        public virtual DbSet<SpdBigledgerV> SpdBigledgerVs { get; set; }
        public virtual DbSet<SpdCash> SpdCashes { get; set; }
        public virtual DbSet<SpdCashcodeException> SpdCashcodeExceptions { get; set; }
        public virtual DbSet<SpdCdvDbdirect> SpdCdvDbdirects { get; set; }
        public virtual DbSet<SpdClosedperiod> SpdClosedperiods { get; set; }
        public virtual DbSet<SpdCrvcdvCorrespondence> SpdCrvcdvCorrespondences { get; set; }
        public virtual DbSet<SpdCrvcdvTrnsType> SpdCrvcdvTrnsTypes { get; set; }
        public virtual DbSet<SpdCurrency> SpdCurrencies { get; set; }
        public virtual DbSet<SpdEq> SpdEqs { get; set; }
        public virtual DbSet<SpdError> SpdErrors { get; set; }
        public virtual DbSet<SpdFtp> SpdFtps { get; set; }
        public virtual DbSet<SpdFundKonsolidasiMapping> SpdFundKonsolidasiMappings { get; set; }
        public virtual DbSet<SpdFundMapping> SpdFundMappings { get; set; }
        public virtual DbSet<SpdFundbank> SpdFundbanks { get; set; }
        public virtual DbSet<SpdFx> SpdFxes { get; set; }
        public virtual DbSet<SpdGenericReport1> SpdGenericReport1s { get; set; }
        public virtual DbSet<SpdGenericReport1BalanceFormula> SpdGenericReport1BalanceFormulas { get; set; }
        public virtual DbSet<SpdGenericReport1Formula> SpdGenericReport1Formulas { get; set; }
        public virtual DbSet<SpdGenericReport1Formula2> SpdGenericReport1Formula2s { get; set; }
        public virtual DbSet<SpdGenericReport1Item> SpdGenericReport1Items { get; set; }
        public virtual DbSet<SpdGenericReport1Result> SpdGenericReport1Results { get; set; }
        public virtual DbSet<SpdGlCompanyList> SpdGlCompanyLists { get; set; }
        public virtual DbSet<SpdGlDetail> SpdGlDetails { get; set; }
        public virtual DbSet<SpdGlDetail0621> SpdGlDetail0621s { get; set; }
        public virtual DbSet<SpdGlDetail2018> SpdGlDetail2018s { get; set; }
        public virtual DbSet<SpdGlDetail2021> SpdGlDetail2021s { get; set; }
        public virtual DbSet<SpdGlDetail2022> SpdGlDetail2022s { get; set; }
        public virtual DbSet<SpdGlDetail20220210> SpdGlDetail20220210s { get; set; }
        public virtual DbSet<SpdGlDetail20220222> SpdGlDetail20220222s { get; set; }
        public virtual DbSet<SpdGlDetail20220223> SpdGlDetail20220223s { get; set; }
        public virtual DbSet<SpdGlDetail2a> SpdGlDetail2as { get; set; }
        public virtual DbSet<SpdGlDetailBackupFendy> SpdGlDetailBackupFendies { get; set; }
        public virtual DbSet<SpdGlDetailBak20220602> SpdGlDetailBak20220602s { get; set; }
        public virtual DbSet<SpdGlDetailBk> SpdGlDetailBks { get; set; }
        public virtual DbSet<SpdGlDetailMigrasi> SpdGlDetailMigrasis { get; set; }
        public virtual DbSet<SpdGlDetailTemp> SpdGlDetailTemps { get; set; }
        public virtual DbSet<SpdGlDetailtemp1> SpdGlDetailtemps1 { get; set; }
        public virtual DbSet<SpdGlMaster> SpdGlMasters { get; set; }
        public virtual DbSet<SpdGlMasterTm> SpdGlMasterTms { get; set; }
        public virtual DbSet<SpdGlMasterTmBk> SpdGlMasterTmBks { get; set; }
        public virtual DbSet<SpdGlMasterTmBkNur> SpdGlMasterTmBkNurs { get; set; }
        public virtual DbSet<SpdGroup> SpdGroups { get; set; }
        public virtual DbSet<SpdGroupMenuaccess> SpdGroupMenuaccesses { get; set; }
        public virtual DbSet<SpdGroupSubaccount> SpdGroupSubaccounts { get; set; }
        public virtual DbSet<SpdInvCoa> SpdInvCoas { get; set; }
        public virtual DbSet<SpdInvestBank> SpdInvestBanks { get; set; }
        public virtual DbSet<SpdJournalsetup> SpdJournalsetups { get; set; }
        public virtual DbSet<SpdJurnal> SpdJurnals { get; set; }
        public virtual DbSet<SpdJurnalAdd> SpdJurnalAdds { get; set; }
        public virtual DbSet<SpdJurnalDeleted> SpdJurnalDeleteds { get; set; }
        public virtual DbSet<SpdJurnalDeletedbyreq> SpdJurnalDeletedbyreqs { get; set; }
        public virtual DbSet<SpdJurnalKonsolidasi> SpdJurnalKonsolidasis { get; set; }
        public virtual DbSet<SpdJurnalKonsolidasiMapping> SpdJurnalKonsolidasiMappings { get; set; }
        public virtual DbSet<SpdJurnalKonsolidasiMappingTest2023> SpdJurnalKonsolidasiMappingTest2023s { get; set; }
        public virtual DbSet<SpdJurnalOpenMaster> SpdJurnalOpenMasters { get; set; }
        public virtual DbSet<SpdJurnalRdnBackup> SpdJurnalRdnBackups { get; set; }
        public virtual DbSet<SpdJurnalReject> SpdJurnalRejects { get; set; }
        public virtual DbSet<SpdJurnalTemp> SpdJurnalTemps { get; set; }
        public virtual DbSet<SpdJurnalTemp20220510> SpdJurnalTemp20220510s { get; set; }
        public virtual DbSet<SpdJurnalTemp3> SpdJurnalTemp3s { get; set; }
        public virtual DbSet<SpdJurnalTempBck> SpdJurnalTempBcks { get; set; }
        public virtual DbSet<SpdJurnalTempDelete> SpdJurnalTempDeletes { get; set; }
        public virtual DbSet<SpdJurnalTempPre> SpdJurnalTempPres { get; set; }
        public virtual DbSet<SpdJurnalTempTest2023> SpdJurnalTempTest2023s { get; set; }
        public virtual DbSet<SpdMenulist> SpdMenulists { get; set; }
        public virtual DbSet<SpdMm> SpdMms { get; set; }
        public virtual DbSet<SpdNf> SpdNfs { get; set; }
        public virtual DbSet<SpdNf2> SpdNf2s { get; set; }
        public virtual DbSet<SpdPvrReport> SpdPvrReports { get; set; }
        public virtual DbSet<SpdPvrReportItem> SpdPvrReportItems { get; set; }
        public virtual DbSet<SpdPvrReportItemsAsset> SpdPvrReportItemsAssets { get; set; }
        public virtual DbSet<SpdPvrReportItemsLiability> SpdPvrReportItemsLiabilities { get; set; }
        public virtual DbSet<SpdPvrReportValue> SpdPvrReportValues { get; set; }
        public virtual DbSet<SpdReport> SpdReports { get; set; }
        public virtual DbSet<SpdSubledgerV> SpdSubledgerVs { get; set; }
        public virtual DbSet<SpdTransaction> SpdTransactions { get; set; }
        public virtual DbSet<SpdTransactionEmergency> SpdTransactionEmergencies { get; set; }
        public virtual DbSet<SpdTransactionTemp> SpdTransactionTemps { get; set; }
        public virtual DbSet<SpdUser> SpdUsers { get; set; }
        public virtual DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public virtual DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        public virtual DbSet<TestSpdJurnalTemp> TestSpdJurnalTemps { get; set; }
        public virtual DbSet<TestSpdJurnalTemp2> TestSpdJurnalTemp2s { get; set; }
        public virtual DbSet<TmpJurn> TmpJurns { get; set; }
        public virtual DbSet<VBank> VBanks { get; set; }
        public virtual DbSet<VBankBalance> VBankBalances { get; set; }
        public virtual DbSet<VCoaJurnalsetup> VCoaJurnalsetups { get; set; }
        public virtual DbSet<VCrvcdv> VCrvcdvs { get; set; }
        public virtual DbSet<VCrvcdv2> VCrvcdv2s { get; set; }
        public virtual DbSet<VCrvcdv3> VCrvcdv3s { get; set; }
        public virtual DbSet<VCrvcdv4> VCrvcdv4s { get; set; }
        public virtual DbSet<VCrvcdv5> VCrvcdv5s { get; set; }
        public virtual DbSet<VFlpfppCrvcdv> VFlpfppCrvcdvs { get; set; }
        public virtual DbSet<VGlMasterTm> VGlMasterTms { get; set; }
        public virtual DbSet<VGlReport> VGlReports { get; set; }
        public virtual DbSet<VInvFlpfpp> VInvFlpfpps { get; set; }
        public virtual DbSet<VJournalSpdSubsidiarygroup> VJournalSpdSubsidiarygroups { get; set; }
        public virtual DbSet<VJurnalMemorialTemp> VJurnalMemorialTemps { get; set; }
        public virtual DbSet<VJurnalOverview> VJurnalOverviews { get; set; }
        public virtual DbSet<VJurnalRequestDeleteOverview> VJurnalRequestDeleteOverviews { get; set; }
        public virtual DbSet<VUnapproveTransaction> VUnapproveTransactions { get; set; }
        public virtual DbSet<VUnapproveTransactionBatch> VUnapproveTransactionBatches { get; set; }
        public virtual DbSet<VUndeletedJurnal> VUndeletedJurnals { get; set; }
        public virtual DbSet<XspdJurnalKonsolidasiMapping> XspdJurnalKonsolidasiMappings { get; set; }
        public virtual DbSet<XspdJurnalTemp> XspdJurnalTemps { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<FundData>().HasNoKey();

            modelBuilder.Entity<AlphabeticalListOfProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Alphabetical list of products");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<Cashcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CASHCODE");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CODE");
            });

            modelBuilder.Entity<CategorySalesFor1997>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Category Sales for 1997");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.CategorySales).HasColumnType("money");
            });

            modelBuilder.Entity<CurrentProductList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Current Product List");

                entity.Property(e => e.ProductId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CustomerAndSuppliersByCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer and Suppliers by City");

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ContactName).HasMaxLength(30);

                entity.Property(e => e.Relationship)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoices");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .IsFixedLength(true);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ExtendedPrice).HasColumnType("money");

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.Salesperson)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.Property(e => e.ShipAddress).HasMaxLength(60);

                entity.Property(e => e.ShipCity).HasMaxLength(15);

                entity.Property(e => e.ShipCountry).HasMaxLength(15);

                entity.Property(e => e.ShipName).HasMaxLength(40);

                entity.Property(e => e.ShipPostalCode).HasMaxLength(10);

                entity.Property(e => e.ShipRegion).HasMaxLength(15);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipperName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<OrderDetailsExtended>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Order Details Extended");

                entity.Property(e => e.ExtendedPrice).HasColumnType("money");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<OrderSubtotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Order Subtotals");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Subtotal).HasColumnType("money");
            });

            modelBuilder.Entity<OrdersQry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Orders Qry");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShipAddress).HasMaxLength(60);

                entity.Property(e => e.ShipCity).HasMaxLength(15);

                entity.Property(e => e.ShipCountry).HasMaxLength(15);

                entity.Property(e => e.ShipName).HasMaxLength(40);

                entity.Property(e => e.ShipPostalCode).HasMaxLength(10);

                entity.Property(e => e.ShipRegion).HasMaxLength(15);

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductSalesFor1997>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Product Sales for 1997");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ProductSales).HasColumnType("money");
            });

            modelBuilder.Entity<ProductsAboveAveragePrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Products Above Average Price");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<ProductsByCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Products by Category");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.QuantityPerUnit).HasMaxLength(20);
            });

            modelBuilder.Entity<QuarterlyOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Quarterly Orders");

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.CompanyName).HasMaxLength(40);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(5)
                    .HasColumnName("CustomerID")
                    .IsFixedLength(true);
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

            modelBuilder.Entity<SalesByCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Sales by Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ProductSales).HasColumnType("money");
            });

            modelBuilder.Entity<SalesTotalsByAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Sales Totals by Amount");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SaleAmount).HasColumnType("money");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Code).HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .HasMaxLength(255)
                    .HasColumnName("CURR");

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner).HasColumnName("OWNER");

                entity.Property(e => e.Slcode).HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
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

            modelBuilder.Entity<SpdBankFund>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spd_bank_fund");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");
            });

            modelBuilder.Entity<SpdBankMaster>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_BANK_MASTER");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Account)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Branch)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Company)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COMPANY");

                entity.Property(e => e.Createby)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Currency)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCY");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.Lastchangeby)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LASTCHANGEBY");

                entity.Property(e => e.Lastchangedate)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTCHANGEDATE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.ShortDescr)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SHORT_DESCR");

                entity.Property(e => e.Startbalance).HasColumnName("STARTBALANCE");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZIPCODE");
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

                entity.Property(e => e.SubSidiary)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdCash>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_CASH");

                entity.Property(e => e.Code)
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

            modelBuilder.Entity<SpdCdvDbdirect>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CDV_DBDIRECT");

                entity.Property(e => e.Apprdate)
                    .HasColumnType("datetime")
                    .HasColumnName("apprdate");

                entity.Property(e => e.Dbtext)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("dbtext");

                entity.Property(e => e.Field1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field1");

                entity.Property(e => e.Field10)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field10");

                entity.Property(e => e.Field11)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field11");

                entity.Property(e => e.Field12)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field12");

                entity.Property(e => e.Field13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("field13");

                entity.Property(e => e.Field14)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field14");

                entity.Property(e => e.Field15)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("field15");

                entity.Property(e => e.Field2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field2");

                entity.Property(e => e.Field3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field3");

                entity.Property(e => e.Field4)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field4");

                entity.Property(e => e.Field5)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field5");

                entity.Property(e => e.Field6)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field6");

                entity.Property(e => e.Field7)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field7");

                entity.Property(e => e.Field8)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("field8");

                entity.Property(e => e.Field9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("field9");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");
            });

            modelBuilder.Entity<SpdClosedperiod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CLOSEDPERIOD");

                entity.Property(e => e.Createby)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CREATEBY");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATEDATE");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdCrvcdvCorrespondence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CRVCDV_CORRESPONDENCE");

                entity.HasIndex(e => e.TrnsId, "IX_SPD_CRVCDV_CORRESPONDENCE_missing_157");

                entity.Property(e => e.Corr)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("corr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");
            });

            modelBuilder.Entity<SpdCrvcdvTrnsType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_CRVCDV_TRNS_TYPE");

                entity.Property(e => e.Crvcdv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("crvcdv");

                entity.Property(e => e.SubTrnsNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsTypeNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdCurrency>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_CURRENCY");

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<SpdEq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_EQ");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");
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

            modelBuilder.Entity<SpdFundKonsolidasiMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_FUND_KONSOLIDASI_MAPPING");

                entity.Property(e => e.DescrGrouper)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr_grouper");

                entity.Property(e => e.Grouper)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grouper");

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("owner");
            });

            modelBuilder.Entity<SpdFundMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_FUND_MAPPING");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.DescrFund)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr_fund");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");
            });

            modelBuilder.Entity<SpdFundbank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_FUNDBANK");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");
            });

            modelBuilder.Entity<SpdFx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_FX");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");
            });

            modelBuilder.Entity<SpdGenericReport1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.DescrEng)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descr_eng");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SpdGenericReport1BalanceFormula>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1_balance_formula");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("descr");
            });

            modelBuilder.Entity<SpdGenericReport1Formula>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1_formula");

                entity.Property(e => e.Adding).HasColumnName("adding");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.DiffYear).HasColumnName("diff_year");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<SpdGenericReport1Formula2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1_formula2");

                entity.Property(e => e.Adding).HasColumnName("adding");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Seq2).HasColumnName("seq2");
            });

            modelBuilder.Entity<SpdGenericReport1Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1_ITEMS");

                entity.Property(e => e.Bold).HasColumnName("bold");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.DescrEng)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descr_eng");

                entity.Property(e => e.Formula).HasColumnName("formula");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Space).HasColumnName("space");

                entity.Property(e => e.Underline).HasColumnName("underline");
            });

            modelBuilder.Entity<SpdGenericReport1Result>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GENERIC_REPORT1_result");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Monthperiod).HasColumnName("monthperiod");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Yearperiod).HasColumnName("yearperiod");
            });

            modelBuilder.Entity<SpdGlCompanyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_COMPANY_LIST");

                entity.Property(e => e.GroupNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("group_nmbr");

                entity.Property(e => e.InvType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv_type");
            });

            modelBuilder.Entity<SpdGlDetail>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Slcode, e.Owner, e.Curr, e.Yearperiod, e.Monthperiod })
                    .HasName("PK__SPD_GL_DETAIL__1758727B");

                entity.ToTable("SPD_GL_DETAIL");

                entity.HasIndex(e => new { e.Monthperiod, e.Yearperiod, e.Owner }, "IX_SPD_GL_DETAIL_missing_209");

                entity.HasIndex(e => e.Slcode, "IX_SPD_GL_DETAIL_missing_36");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.Owner)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Curr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");
            });

            modelBuilder.Entity<SpdGlDetail0621>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL0621");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail2018>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_2018");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL2021");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL2022");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail20220210>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL20220210");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail20220222>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_20220222");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail20220223>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_20220223");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetail2a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL2a");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetailBackupFendy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_BACKUP_FENDY");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetailBak20220602>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_BAK20220602");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetailBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_BK");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Curr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("curr");

                entity.Property(e => e.EndC).HasColumnName("end_c");

                entity.Property(e => e.EndD).HasColumnName("end_d");

                entity.Property(e => e.Monthperiod).HasColumnName("monthperiod");

                entity.Property(e => e.MovC).HasColumnName("mov_c");

                entity.Property(e => e.MovD).HasColumnName("mov_d");

                entity.Property(e => e.Owner)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.StartC).HasColumnName("start_c");

                entity.Property(e => e.StartD).HasColumnName("start_d");

                entity.Property(e => e.Yearperiod).HasColumnName("yearperiod");
            });

            modelBuilder.Entity<SpdGlDetailMigrasi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_MIGRASI");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.OldOwner)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OLD_OWNER");

                entity.Property(e => e.Owner)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetailTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAIL_TEMP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlDetailtemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_DETAILTEMP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Curr)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURR")
                    .IsFixedLength(true);

                entity.Property(e => e.EndC).HasColumnName("END_C");

                entity.Property(e => e.EndD).HasColumnName("END_D");

                entity.Property(e => e.Monthperiod).HasColumnName("MONTHPERIOD");

                entity.Property(e => e.MovC).HasColumnName("MOV_C");

                entity.Property(e => e.MovD).HasColumnName("MOV_D");

                entity.Property(e => e.Owner)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OWNER");

                entity.Property(e => e.Slcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLCODE");

                entity.Property(e => e.StartC).HasColumnName("START_C");

                entity.Property(e => e.StartD).HasColumnName("START_D");

                entity.Property(e => e.Yearperiod).HasColumnName("YEARPERIOD");
            });

            modelBuilder.Entity<SpdGlMaster>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_GL_MASTER");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Cash)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CASH");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.Parentcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PARENTCODE");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SpdGlMasterTm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_MASTER_TM");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.Gd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GD")
                    .IsFixedLength(true);

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Parent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SpdGlMasterTmBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_MASTER_TM_BK");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.Gd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GD")
                    .IsFixedLength(true);

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Parent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SpdGlMasterTmBkNur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_GL_MASTER_TM_BK_NUR");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.Gd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("GD")
                    .IsFixedLength(true);

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Parent)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("parent");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.Type).HasColumnName("type");
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

            modelBuilder.Entity<SpdGroupSubaccount>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.Subsidiary });

                entity.ToTable("SPD_GROUP_SUBACCOUNT");

                entity.Property(e => e.Code)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Subsidiary)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoRekeningParent)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdInvCoa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_INV_COA");

                entity.Property(e => e.Coa)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("coa");
            });
            modelBuilder.Entity<SpdInvestBank>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SPD_INVEST_BANK");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.DestinationCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
            //modelBuilder.Entity<SpdInvestBank>(entity =>
            //{
            //    entity.HasKey(e => e.Id); 

            //    entity.ToTable("SPD_INVEST_BANK");

            //    entity.Property(e => e.Id)
            //        .HasColumnName("Id"); 

            //    entity.Property(e => e.AccNo)
            //        .HasMaxLength(50)
            //        .IsUnicode(false);

            //    entity.Property(e => e.BankName)
            //        .HasMaxLength(255)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Branch)
            //        .HasMaxLength(255)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Code)
            //        .HasMaxLength(10)
            //        .IsUnicode(false)
            //        .HasColumnName("code");

            //    entity.Property(e => e.DestinationCode)
            //        .HasMaxLength(100)
            //        .IsUnicode(false);
            //});


            modelBuilder.Entity<SpdJournalsetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JOURNALSETUP");

                entity.Property(e => e.Acc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC")
                    .IsFixedLength(true);

                entity.Property(e => e.Inv).HasColumnName("inv");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.TrnsTypeNmbr)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL");

                entity.HasIndex(e => e.Debet, "IX_SPD_JURNAL_missing_544");

                entity.HasIndex(e => e.Credit, "IX_SPD_JURNAL_missing_546");

                entity.HasIndex(e => e.DateJurnal, "IX_SPD_JURNAL_missing_64");

                entity.HasIndex(e => new { e.TrnsId, e.GlCode, e.Slcode, e.TrnsTypeNmbr, e.Inv, e.Company, e.Grp }, "xspd_jurnal");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalAdd>(entity =>
            {
                entity.HasKey(e => new { e.TrnsId, e.GlCode, e.SubTrnsNmbr })
                    .HasName("PK_SPD_JURNAL_ADD_1");

                entity.ToTable("SPD_JURNAL_ADD");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trans_date");
            });

            modelBuilder.Entity<SpdJurnalDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_DELETED");

                entity.Property(e => e.ApproveDeleteBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveDeleteDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestDeleteBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDeleteDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalDeletedbyreq>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_DELETEDBYREQ");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate)
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())", false);

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalKonsolidasi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_KONSOLIDASI");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalKonsolidasiMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_KONSOLIDASI_MAPPING");

                entity.HasIndex(e => e.Status, "IX_SPD_JURNAL_KONSOLIDASI_MAPPING_missing_206");

                entity.HasIndex(e => e.LastTrnsId, "IX_SPD_JURNAL_KONSOLIDASI_MAPPING_missing_215");

                entity.HasIndex(e => e.OldTrnsId, "IX_SPD_JURNAL_KONSOLIDASI_MAPPING_missing_253");

                entity.HasIndex(e => new { e.NewTrnsId, e.OldTrnsId, e.LastTrnsId }, "xspd_jurnal_konsolidasi_mapping");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("approveby");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("approvedate");

                entity.Property(e => e.LastTrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("last_trns_id");

                entity.Property(e => e.NewTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("new_trns_id");

                entity.Property(e => e.OldTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("old_trns_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SpdJurnalKonsolidasiMappingTest2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_jurnal_konsolidasi_mapping_test2023");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("approveby");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("approvedate");

                entity.Property(e => e.LastTrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("last_trns_id");

                entity.Property(e => e.NewTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("new_trns_id");

                entity.Property(e => e.OldTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("old_trns_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SpdJurnalOpenMaster>(entity =>
            {
                entity.HasKey(e => e.TrnsId)
                    .HasName("PK__SPD_JURNAL_OPEN___184C96B4");

                entity.ToTable("SPD_JURNAL_OPEN_MASTER");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.Descr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.Userid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SpdJurnalRdnBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spd_jurnal_rdn_backup");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalReject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_REJECT");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTemp>(entity =>
            {


                entity.HasKey(e => e.TrnsId);
                entity.ToTable("SPD_JURNAL_TEMP");

                entity.HasIndex(e => e.TrnsId, "IX_SPD_JURNAL_TEMP");

                entity.HasIndex(e => new { e.Inv, e.Slcode, e.Description }, "IX_SPD_JURNAL_TEMP_missing_1");

                entity.HasIndex(e => e.Inv, "IX_SPD_JURNAL_TEMP_missing_250");

                entity.HasIndex(e => new { e.TrnsTypeNmbr, e.SubTrnsNmbr, e.Inv, e.Company, e.Grp }, "IX_SPD_JURNAL_TEMP_missing_489");

                entity.HasIndex(e => new { e.TrnsId, e.Slcode, e.GlCode, e.Grp }, "xspd_jurnal_temp");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTemp20220510>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_TEMP20220510");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTemp3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spd_jurnal_temp3");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTempBck>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spd_jurnal_temp_bck");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTempDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_TEMP_DELETE");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTempPre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_JURNAL_TEMP_PRE");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdJurnalTempTest2023>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_Jurnal_temp_test2023");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<SpdMenulist>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.ToTable("SPD_MENULIST");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MENU_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("APPLICATION");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LINK");

                entity.Property(e => e.Lvl).HasColumnName("LVL");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MENU_NAME");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.RootId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ROOT_ID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SpdMm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_MM");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");
            });

            modelBuilder.Entity<SpdNf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_NF");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");
            });

            modelBuilder.Entity<SpdNf2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_NF2");

                entity.Property(e => e.Oldfund)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("oldfund");
            });

            modelBuilder.Entity<SpdPvrReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_PVR_REPORT");

                entity.Property(e => e.Owner)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.ReportCode).HasColumnName("report_code");

                entity.Property(e => e.Thedate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("thedate");
            });

            modelBuilder.Entity<SpdPvrReportItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_PVR_REPORT_items");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Parentcode).HasColumnName("parentcode");

                entity.Property(e => e.ReportCode).HasColumnName("report_code");

                entity.Property(e => e.Seq).HasColumnName("seq");
            });

            modelBuilder.Entity<SpdPvrReportItemsAsset>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_PVR_REPORT_items_assets");

                entity.Property(e => e.Descr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.MarketValue).HasColumnName("market_value");

                entity.Property(e => e.ReportCode).HasColumnName("report_code");
            });

            modelBuilder.Entity<SpdPvrReportItemsLiability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_PVR_REPORT_items_liabilities");

                entity.Property(e => e.Descr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.MarketValue).HasColumnName("market_value");

                entity.Property(e => e.ReportCode).HasColumnName("report_code");
            });

            modelBuilder.Entity<SpdPvrReportValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_PVR_REPORT_values");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Parentcode).HasColumnName("parentcode");

                entity.Property(e => e.ReportCode).HasColumnName("report_code");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Value1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("value1");

                entity.Property(e => e.Value2)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("value2");

                entity.Property(e => e.Value3).HasColumnName("value3");

                entity.Property(e => e.Value4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("value4");

                entity.Property(e => e.Value5).HasColumnName("value5");

                entity.Property(e => e.Value6).HasColumnName("value6");

                entity.Property(e => e.Value7).HasColumnName("value7");

                entity.Property(e => e.Value8).HasColumnName("value8");

                entity.Property(e => e.Value9).HasColumnName("value9");
            });

            modelBuilder.Entity<SpdReport>(entity =>
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
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
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

                entity.Property(e => e.SubSidiary)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpdTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_TRANSACTION");

                entity.HasIndex(e => e.Remark1, "IX_SPD_TRANSACTION_missing_89");

                entity.HasIndex(e => new { e.TrnsId, e.TrnsTypeNmbr, e.GlCode, e.TrnsDate }, "xspd_transaction");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC")
                    .IsFixedLength(true);

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Remark1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark1");

                entity.Property(e => e.Remark2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark2");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<SpdTransactionEmergency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_TRANSACTION_EMERGENCY");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");
            });

            modelBuilder.Entity<SpdTransactionTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SPD_TRANSACTION_TEMP");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC")
                    .IsFixedLength(true);

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Remark1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark1");

                entity.Property(e => e.Remark2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("remark2");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userid");
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

            modelBuilder.Entity<SummaryOfSalesByQuarter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Summary of Sales by Quarter");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.Subtotal).HasColumnType("money");
            });

            modelBuilder.Entity<SummaryOfSalesByYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Summary of Sales by Year");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");

                entity.Property(e => e.Subtotal).HasColumnType("money");
            });

            modelBuilder.Entity<TestSpdJurnalTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_spd_jurnal_temp");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TestSpdJurnalTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_spd_jurnal_temp2");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<TmpJurn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmp_jurn");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<VBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BANK");

                entity.Property(e => e.Alamat)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cabang)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Curr)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KodePos)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Kode Pos");

                entity.Property(e => e.NamaBank)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Nama Bank");

                entity.Property(e => e.NoRekening)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("No. Rekening");

                entity.Property(e => e.Perusahaan)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PIC");

                entity.Property(e => e.Singkatan)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Telepon)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VBankBalance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_BANK_BALANCE");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Debet).HasColumnName("debet");

                entity.Property(e => e.Monthperiod).HasColumnName("monthperiod");

                entity.Property(e => e.Saldo).HasColumnName("saldo");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.Yearperiod).HasColumnName("yearperiod");
            });

            modelBuilder.Entity<VCoaJurnalsetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_COA_JURNALSETUP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Descr)
                    .IsRequired()
                    .HasMaxLength(295)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");
            });

            modelBuilder.Entity<VCrvcdv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CRVCDV");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(334)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TransDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trans_date");

                entity.Property(e => e.TrnsDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsId2)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("trns_id2");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VCrvcdv2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CRVCDV2");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(334)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TrnsDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VCrvcdv3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CRVCDV3");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(307)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TrnsDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsId2)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("trns_id2");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VCrvcdv4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CRVCDV4");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(307)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.Perusahaan)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("perusahaan");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TrnsDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsId2)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("trns_id2");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VCrvcdv5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CRVCDV5");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.CompanyNm)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("company_nm");

                entity.Property(e => e.Dc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(307)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.TrnsDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsId2)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("trns_id2");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VFlpfppCrvcdv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_FLPFPP_CRVCDV");

                entity.Property(e => e.Cer)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("cer");

                entity.Property(e => e.Comp)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("comp");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fund");

                entity.Property(e => e.LastTrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("last_trns_id");

                entity.Property(e => e.Remark1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("remark1");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");
            });

            modelBuilder.Entity<VGlMasterTm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_GL_MASTER_TM");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Lvl1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lvl1");

                entity.Property(e => e.Lvl1a)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lvl1a");

                entity.Property(e => e.Lvl2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lvl2");

                entity.Property(e => e.Lvl2a)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lvl2a");

                entity.Property(e => e.Lvl3)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lvl3");

                entity.Property(e => e.Lvl3a)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lvl3a");

                entity.Property(e => e.Lvl4)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lvl4");

                entity.Property(e => e.Lvl4a)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lvl4a");

                entity.Property(e => e.Lvl5)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lvl5");

                entity.Property(e => e.Lvl5a)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lvl5a");

                entity.Property(e => e.Lvl6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("lvl6");

                entity.Property(e => e.Lvl7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("lvl7");
            });

            modelBuilder.Entity<VGlReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_GL_REPORT");

                entity.Property(e => e.Ccy)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ccy");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("keterangan");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VInvFlpfpp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_INV_FLPFPP");

                entity.Property(e => e.AccAppr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("acc_appr");

                entity.Property(e => e.AccApprDate)
                    .HasColumnType("datetime")
                    .HasColumnName("acc_appr_date");

                entity.Property(e => e.CmAppr)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cm_appr");

                entity.Property(e => e.CmApprDate)
                    .HasColumnType("datetime")
                    .HasColumnName("cm_appr_date");

                entity.Property(e => e.Crvcdv)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("crvcdv");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvDescr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_descr");

                entity.Property(e => e.Old)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("old");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusDescr)
                    .IsRequired()
                    .HasMaxLength(27)
                    .IsUnicode(false)
                    .HasColumnName("status_descr");

                entity.Property(e => e.Thedate)
                    .HasColumnType("datetime")
                    .HasColumnName("thedate");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<VJournalSpdSubsidiarygroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_JOURNAL_SPD_SUBSIDIARYGROUP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<VJurnalMemorialTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_JURNAL_MEMORIAL_TEMP");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.Monthperiod).HasColumnName("monthperiod");

                entity.Property(e => e.SubTrnsNm)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");

                entity.Property(e => e.Yearperiod).HasColumnName("yearperiod");
            });

            modelBuilder.Entity<VJurnalOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_JURNAL_OVERVIEW");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsType).HasColumnName("trns_type");
            });

            modelBuilder.Entity<VJurnalRequestDeleteOverview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_JURNAL_REQUEST_DELETE_OVERVIEW");

                entity.Property(e => e.ApproveDeleteBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveDeleteDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDeleteBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDeleteDate).HasColumnType("datetime");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");
            });

            modelBuilder.Entity<VUnapproveTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UNAPPROVE_TRANSACTION");

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Funds)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("funds");

                entity.Property(e => e.SubTrns).HasColumnName("sub_trns");

                entity.Property(e => e.SubTrnsNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<VUnapproveTransactionBatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UNAPPROVE_TRANSACTION_BATCH");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Batch)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("batch");

                entity.Property(e => e.Company)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Dc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DC")
                    .IsFixedLength(true);

                entity.Property(e => e.Fund)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Funds)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("funds");

                entity.Property(e => e.GlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.SubTrns)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns");

                entity.Property(e => e.SubTrnsNm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_trns_nm");

                entity.Property(e => e.TrnsDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trns_date");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            modelBuilder.Entity<VUndeletedJurnal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_UNDELETED_JURNAL");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.InvTypeNm)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_type_nm");

                entity.Property(e => e.PostedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostedDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsType).HasColumnName("trns_type");
            });

            modelBuilder.Entity<XspdJurnalKonsolidasiMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XSPD_JURNAL_KONSOLIDASI_MAPPING");

                entity.Property(e => e.Approveby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("approveby");

                entity.Property(e => e.Approvedate)
                    .HasColumnType("datetime")
                    .HasColumnName("approvedate");

                entity.Property(e => e.LastTrnsId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("last_trns_id");

                entity.Property(e => e.NewTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("new_trns_id");

                entity.Property(e => e.OldTrnsId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("old_trns_id");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<XspdJurnalTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("XSPD_JURNAL_TEMP");

                entity.Property(e => e.CerNmbr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cer_nmbr");

                entity.Property(e => e.Company)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Correction).HasColumnName("correction");

                entity.Property(e => e.DateJurnal).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GlCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("gl_code");

                entity.Property(e => e.Grp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("grp");

                entity.Property(e => e.Inv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("inv");

                entity.Property(e => e.Slcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("slcode");

                entity.Property(e => e.SubTrnsNmbr).HasColumnName("sub_trns_nmbr");

                entity.Property(e => e.TrnsId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trns_id");

                entity.Property(e => e.TrnsTypeNmbr).HasColumnName("trns_type_nmbr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
