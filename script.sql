USE [PayONE_LBF]
GO
/****** Object:  Table [dbo].[acc_bengalInsurance_TransactionLog]    Script Date: 02-05-2023 12:12:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[acc_bengalInsurance_TransactionLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TranNo] [nvarchar](max) NOT NULL,
	[TranDate] [datetime] NOT NULL,
	[ExecutionDate] [datetime] NULL,
	[BankCode] [nvarchar](max) NOT NULL,
	[BranchID] [int] NULL,
	[BranchCode] [nvarchar](max) NOT NULL,
	[PaymentType] [int] NULL,
	[ChequeNo] [nvarchar](max) NULL,
	[ChequeAmount] [decimal](18, 2) NULL,
	[ChequeDate] [datetime] NULL,
	[forMonth] [nvarchar](max) NULL,
	[forYear] [int] NULL,
	[InstitueID] [nvarchar](max) NULL,
	[IsService] [bit] NULL,
	[ServiceID] [int] NULL,
	[VendorBranchCode] [nvarchar](max) NULL,
	[CustomerID] [nvarchar](max) NULL,
	[CustomerName] [nvarchar](max) NULL,
	[PaymentCurrencyFor] [nvarchar](max) NULL,
	[LastPaymentDate] [datetime] NULL,
	[ConvertionRate] [decimal](18, 2) NULL,
	[BillAmount] [decimal](18, 2) NULL,
	[MinAmount] [decimal](18, 2) NULL,
	[DelayChargeAmount] [decimal](18, 2) NULL,
	[PaneltyAmount] [decimal](18, 2) NULL,
	[ProcessFeeAmount] [decimal](18, 2) NULL,
	[VATAmount] [decimal](18, 2) NULL,
	[TotalPaymentAmount] [decimal](18, 2) NOT NULL,
	[PostedUserID] [nvarchar](max) NULL,
	[PostingDate] [datetime] NULL,
	[AuthorizationUserID] [nvarchar](max) NULL,
	[AuthDate] [datetime] NULL,
	[StatusID] [nvarchar](max) NULL,
	[IsPosted] [bit] NULL,
	[IsDelete] [bit] NULL,
	[IsSMSGenerate] [bit] NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[ModifiedBy] [varchar](15) NULL,
	[ModifiedOn] [datetime] NULL,
	[SessionID] [varchar](50) NULL,
	[RefConfirmNo] [varchar](50) NULL,
	[RefVerifyConfirmNo] [varchar](50) NULL,
 CONSTRAINT [PK_acc_bengalInsurance_TransactionLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[acc_bic_User]    Script Date: 02-05-2023 12:12:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[acc_bic_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EMPLOYEENAME] [nvarchar](50) NULL,
	[EMPBRANCHCODE] [varchar](50) NULL,
	[EMPLOYEEID] [nvarchar](50) NULL,
	[USERTYPE] [nvarchar](50) NULL,
	[CREATED_ON] [datetime] NULL,
	[CREATED_BY] [nvarchar](50) NULL,
	[MODIFIED_ON] [datetime] NULL,
	[MODIFIED_BY] [nvarchar](50) NULL,
	[IS_ACTIVE] [bit] NULL,
 CONSTRAINT [PK_acc_bic_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_BillAmount]  DEFAULT ((0.00)) FOR [BillAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_MinAmount]  DEFAULT ((0.00)) FOR [MinAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_DelayChargeAmount]  DEFAULT ((0.00)) FOR [DelayChargeAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_PaneltyAmount]  DEFAULT ((0.00)) FOR [PaneltyAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_ProcessFeeAmount]  DEFAULT ((0.00)) FOR [ProcessFeeAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_VATAmount]  DEFAULT ((0.00)) FOR [VATAmount]
GO
ALTER TABLE [dbo].[acc_bengalInsurance_TransactionLog] ADD  CONSTRAINT [DF_acc_bengalInsurance_TransactionLog_TotalPaymentAmount]  DEFAULT ((0.00)) FOR [TotalPaymentAmount]
GO
