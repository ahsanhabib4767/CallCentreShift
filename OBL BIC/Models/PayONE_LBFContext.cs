using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace OBL.BIC.Models
{
    public partial class PayONE_LBFContext : DbContext
    {
        public PayONE_LBFContext()
        {
        }

        public PayONE_LBFContext(DbContextOptions<PayONE_LBFContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AccBengalInsuranceTransactionLog> AccBengalInsuranceTransactionLogs    { get; set; }   = null!;
        public virtual DbSet<AccBicUser> AccBicUsers { get; set; } = null!;
        public virtual DbSet<AccCbsaccountHead> AccCbsaccountHeads { get; set; } = null!;
        public virtual DbSet<AccCbsaccountProduct> AccCbsaccountProducts { get; set; } = null!;
        public virtual DbSet<AccCbsaccountType> AccCbsaccountTypes { get; set; } = null!;
        public virtual DbSet<AccEwuTransactionLog> AccEwuTransactionLogs { get; set; } = null!;

        public virtual DbSet<AccJournalCbstranactionMaster> AccJournalCbstranactionMasters { get; set; } = null!;
        public virtual DbSet<AccJournalCbstransactionDetail> AccJournalCbstransactionDetails { get; set; } = null!;
        public virtual DbSet<AccTransactionLog> AccTransactionLogs { get; set; } = null!;
        public virtual DbSet<AccTransactionLogArc> AccTransactionLogArcs { get; set; } = null!;
        public virtual DbSet<CfgBank> CfgBanks { get; set; } = null!;
        public virtual DbSet<CfgBranch> CfgBranches { get; set; } = null!;
        public virtual DbSet<CfgInstitute> CfgInstitutes { get; set; } = null!;
        public virtual DbSet<CfgService> CfgServices { get; set; } = null!;
        public virtual DbSet<CfgServiceType> CfgServiceTypes { get; set; } = null!;
        public virtual DbSet<DicDistrictInformation> DicDistrictInformations { get; set; } = null!;
        public virtual DbSet<DicDivisionInformation> DicDivisionInformations { get; set; } = null!;
        public virtual DbSet<HrmDepartment> HrmDepartments { get; set; } = null!;
        public virtual DbSet<HrmDesignation> HrmDesignations { get; set; } = null!;
        //public virtual DbSet<MisEwuConfirmationLog> MisEwuConfirmationLogs { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleClaim> RoleClaims { get; set; } = null!;
        public virtual DbSet<SysModule> SysModules { get; set; } = null!;
        public virtual DbSet<SysScreen> SysScreens { get; set; } = null!;
        public virtual DbSet<SysScreenModule> SysScreenModules { get; set; } = null!;
        public virtual DbSet<SysSystemDictonary> SysSystemDictonaries { get; set; } = null!;
        public virtual DbSet<SysVersionInfo> SysVersionInfos { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserClaim> UserClaims { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserToken> UserTokens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=10.156.0.129; Initial Catalog=PayONE_LBF;User ID=ahsan; Password=ahs@n0470");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccBengalInsuranceTransactionLog>(entity =>
            {
                entity.ToTable("acc_bengalInsurance_TransactionLog");

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationUserId).HasColumnName("AuthorizationUserID");

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChequeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ConvertionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DelayChargeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.ForMonth).HasColumnName("forMonth");

                entity.Property(e => e.ForYear).HasColumnName("forYear");

                entity.Property(e => e.InstitueId).HasColumnName("InstitueID");

                entity.Property(e => e.IsSmsgenerate).HasColumnName("IsSMSGenerate");

                entity.Property(e => e.LastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PaneltyAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PostedUserId).HasColumnName("PostedUserID");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessFeeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TotalPaymentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATAmount")
                    .HasDefaultValueSql("((0.00))");
            });
            modelBuilder.Entity<AccCbsaccountHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_CBSAccountHead");

                entity.Property(e => e.AccountHeadId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AccountHeadID");

                entity.Property(e => e.AccountHeadName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MapCmsaccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MapCMSAccountNumber");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.SysId).HasColumnName("SysID");
            });

            modelBuilder.Entity<AccCbsaccountProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_CBSAccountProduct");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");
            });

            modelBuilder.Entity<AccCbsaccountType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_CBSAccountType");

                entity.Property(e => e.CbstypeId).HasColumnName("CBSTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");
            });

            modelBuilder.Entity<AccEwuTransactionLog>(entity =>
            {
                entity.ToTable("acc_ewu_TransactionLog");

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationUserId).HasColumnName("AuthorizationUserID");

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChequeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ConvertionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DelayChargeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.ForMonth).HasColumnName("forMonth");

                entity.Property(e => e.ForYear).HasColumnName("forYear");

                entity.Property(e => e.InstitueId).HasColumnName("InstitueID");

                entity.Property(e => e.IsSmsgenerate).HasColumnName("IsSMSGenerate");

                entity.Property(e => e.LastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PaneltyAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PostedUserId).HasColumnName("PostedUserID");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessFeeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TotalPaymentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATAmount")
                    .HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<AccEwuUser>(entity =>
            {
                entity.ToTable("acc_ewu_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.Employeeid)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_ON");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(50)
                    .HasColumnName("USERTYPE");
            });

            modelBuilder.Entity<AccJournalCbstranactionMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_JournalCBSTranactionMaster");

                entity.Property(e => e.AuthorizerUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.IsPosted)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobProcessUser)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JournalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SysId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("SysID");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("TransID");
            });

            modelBuilder.Entity<AccJournalCbstransactionDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_JournalCBSTransactionDetails");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AuthorizerUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CbsauthResponse)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CBSAuthResponse");

                entity.Property(e => e.CbsrefId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CBSRefID");

                entity.Property(e => e.CbsresponseCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CBSResponseCode");

                entity.Property(e => e.ConverstionRate).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditAmountBdt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("CreditAmountBDT");

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DebitAmountBdt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DebitAmountBDT");

                entity.Property(e => e.IsAuthorized)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsPosted)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsReversal)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostedUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PurposeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceSysId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceSysID");

                entity.Property(e => e.RelatedAccountNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.TransId)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("TransID");

                entity.Property(e => e.TxnCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TxnType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccTransactionLog>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("acc_TransactionLog");

                entity.Property(e => e.SysId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SysID");

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthorizationUserID");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChequeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DelayChargeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.ForMonth)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("forMonth");

                entity.Property(e => e.ForYear).HasColumnName("forYear");

                entity.Property(e => e.InstitueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("InstitueID");

                entity.Property(e => e.IsSmsgenerate).HasColumnName("IsSMSGenerate");

                entity.Property(e => e.LastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaneltyAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PaymentCurrencyFor)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PostedUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PostedUserID");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessFeeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusID");

                entity.Property(e => e.TotalPaymentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATAmount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.VendorBranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<AccBicUser>(entity =>
            {
                entity.ToTable("AccBicUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_ON");

                entity.Property(e => e.Empbranchcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMPBRANCHCODE");

                entity.Property(e => e.Employeeid)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEEID");

                entity.Property(e => e.Employeename)
                    .HasMaxLength(50)
                    .HasColumnName("EMPLOYEENAME");

                entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasColumnName("MODIFIED_BY");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_ON");

                entity.Property(e => e.Usertype)
                    .HasMaxLength(50)
                    .HasColumnName("USERTYPE");
            });
            modelBuilder.Entity<AccTransactionLogArc>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("acc_TransactionLog_Arc");

                entity.Property(e => e.SysId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SysID");

                entity.Property(e => e.AuthDate).HasColumnType("datetime");

                entity.Property(e => e.AuthorizationUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("AuthorizationUserID");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ChequeAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertionRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DelayChargeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ExecutionDate).HasColumnType("datetime");

                entity.Property(e => e.ForMonth)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("forMonth");

                entity.Property(e => e.ForYear).HasColumnName("forYear");

                entity.Property(e => e.InstitueId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("InstitueID");

                entity.Property(e => e.IsSmsgenerate).HasColumnName("IsSMSGenerate");

                entity.Property(e => e.LastPaymentDate).HasColumnType("datetime");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaneltyAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PaymentCurrencyFor)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PostedUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PostedUserID");

                entity.Property(e => e.PostingDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessFeeAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("StatusID");

                entity.Property(e => e.TotalPaymentAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TranDate).HasColumnType("datetime");

                entity.Property(e => e.TranNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("VATAmount")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.VendorBranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgBank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cfg_Bank");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatorUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreatorUserID");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifierUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ModifierUserID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cfg_Branch");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchManager)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CountryID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SysId).HasColumnName("SysID");
            });

            modelBuilder.Entity<CfgInstitute>(entity =>
            {
                entity.ToTable("cfg_Institute");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgService>(entity =>
            {
                entity.ToTable("cfg_Services");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("InstituteID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CfgServiceType>(entity =>
            {
                entity.ToTable("cfg_ServiceType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DicDistrictInformation>(entity =>
            {
                entity.ToTable("dic_DistrictInformation");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CountryID");

                entity.Property(e => e.DivisionId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("DivisionID");

                entity.Property(e => e.Extcode)
                    .HasMaxLength(255)
                    .HasColumnName("EXTCode");

                entity.Property(e => e.Favorite).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Trans).HasMaxLength(255);

                entity.Property(e => e.Twcode).HasColumnName("TWCode");
            });

            modelBuilder.Entity<DicDivisionInformation>(entity =>
            {
                entity.ToTable("dic_DivisionInformation");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmDepartment>(entity =>
            {
                entity.ToTable("hrm_Department");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatorUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreatorUserID");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifierUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ModifierUserID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrmDesignation>(entity =>
            {
                entity.ToTable("hrm_Designation");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatorUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreatorUserID");

                entity.Property(e => e.ModificationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifierUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ModifierUserID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sl).HasColumnName("SL");
            });

            //modelBuilder.Entity<MisEwuConfirmationLog>(entity =>
            //{
            //    entity.ToTable("mis_ewu_ConfirmationLog");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.CollectionDate).HasColumnType("datetime");

            //    entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            //});

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "Identity");

                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<RoleClaim>(entity =>
            {
                entity.ToTable("RoleClaims", "Identity");

                entity.HasIndex(e => e.RoleId, "IX_RoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<SysModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_Module");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Creator)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CREATOR");

                entity.Property(e => e.Id)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIER");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysScreen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_Screen");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Creator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREATOR");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplaySl).HasColumnName("DisplaySL");

                entity.Property(e => e.Id)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.MenuIconObjectPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MODIFIER");

                entity.Property(e => e.ViewObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysScreenModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_ScreenModule");

                entity.Property(e => e.ModuleId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ModuleID");

                entity.Property(e => e.ScreenId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("ScreenID");
            });

            modelBuilder.Entity<SysSystemDictonary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_SystemDictonary");

                entity.Property(e => e.Id)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.StatusValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysVersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sys_VersionInfo");

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppliedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Dbversion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DBVersion");

                entity.Property(e => e.Description).HasMaxLength(1024);

                entity.Property(e => e.SysId).HasColumnName("SysID");

                entity.Property(e => e.TerminalMessage).HasMaxLength(1024);

                entity.Property(e => e.UpdateMessage).HasMaxLength(1024);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User", "Identity");

                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmed)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.Property(e => e.UserType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "UserRole",
                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<User>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("UserRoles", "Identity");

                            j.HasIndex(new[] { "RoleId" }, "IX_UserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<UserClaim>(entity =>
            {
                entity.ToTable("UserClaims", "Identity");

                entity.HasIndex(e => e.UserId, "IX_UserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.ToTable("UserLogins", "Identity");

                entity.HasIndex(e => e.UserId, "IX_UserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.ToTable("UserTokens", "Identity");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
