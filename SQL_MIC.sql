USE [Test]
GO
/****** Object:  Table [dbo].[AccBicUser]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccBicUser](
	[Id] [int] NOT NULL,
	[Employeename] [varchar](255) NULL,
	[Empbranchcode] [varchar](255) NULL,
	[Employeeid] [varchar](255) NULL,
	[Usertype] [varchar](255) NULL,
	[CREATED_ON] [datetime] NULL,
	[CREATED_BY] [varchar](255) NULL,
	[MODIFIED_ON] [datetime] NULL,
	[MODIFIED_BY] [varchar](255) NULL,
	[IS_ACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmpIdentity] [varchar](50) NULL,
	[EmployeeName] [varchar](100) NULL,
	[ManagerID] [int] NULL,
	[Gender] [varchar](50) NULL,
 CONSTRAINT [PK__Employee__7AD04FF1D417B9E5] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeShift]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeShift](
	[EmployeeShiftID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NULL,
	[ShiftTimingID] [int] NULL,
	[ShiftDate] [date] NULL,
 CONSTRAINT [PK__Employee__2FBBBA135077546A] PRIMARY KEY CLUSTERED 
(
	[EmployeeShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[ManagerID] [int] IDENTITY(1,1) NOT NULL,
	[ManagerName] [varchar](100) NULL,
 CONSTRAINT [PK__Manager__3BA2AA8132972196] PRIMARY KEY CLUSTERED 
(
	[ManagerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NonWorkingDay]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NonWorkingDay](
	[NonWorkingDayID] [int] IDENTITY(1,1) NOT NULL,
	[NonWorkingDate] [date] NULL,
	[HoliDayName] [varchar](50) NULL,
 CONSTRAINT [PK__NonWorki__2BB55D44CE520669] PRIMARY KEY CLUSTERED 
(
	[NonWorkingDayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShiftTiming]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShiftTiming](
	[ShiftTimingID] [int] IDENTITY(1,1) NOT NULL,
	[ShiftStartTime] [time](7) NULL,
	[ShiftEndTime] [time](7) NULL,
	[ShiftName] [varchar](50) NULL,
	[ShiftCode] [varchar](20) NULL,
 CONSTRAINT [PK__ShiftTim__8B1F8F9BF69FEE20] PRIMARY KEY CLUSTERED 
(
	[ShiftTimingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShiftWiseEmployeeMigration]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShiftWiseEmployeeMigration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ShiftName] [varchar](50) NULL,
	[ShiftEmployeeLimit] [varchar](50) NULL,
	[ShiftDate] [date] NULL,
 CONSTRAINT [PK_ShiftWiseEmployeeMigration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeekDays]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeekDays](
	[WeekID] [int] IDENTITY(1,1) NOT NULL,
	[WeekStartDate] [date] NULL,
	[WeekEndTime] [date] NULL,
 CONSTRAINT [PK__WeekDays__C814A5E1200AF9E1] PRIMARY KEY CLUSTERED 
(
	[WeekID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AccBicUser] ([Id], [Employeename], [Empbranchcode], [Employeeid], [Usertype], [CREATED_ON], [CREATED_BY], [MODIFIED_ON], [MODIFIED_BY], [IS_ACTIVE]) VALUES (1, N'Ahsan', N'HO', N'021017404335', N'Standard', CAST(N'2023-05-17T00:00:00.000' AS DateTime), N'Ahsan', NULL, NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (18, N'20180910001', N'SADIA ISLAM RATNA-CCE', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (19, N'20180911001', N'RAJIA SULTANA-JA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (20, N'20181025001', N'SALMA AHMED-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (21, N'20181025002', N'FARIDA AHMED-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (22, N'20181031001', N'MD. EMON MIAN-CCE', 1, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (23, N'20190409001', N'NUSRAT RAHMAN-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (24, N'20190424001', N'RAKIB KHAN-JA', 1, N'M')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[EmployeeShift] ON 

INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (13, 18, 2, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (14, 18, 2, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (15, 18, 3, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (18, 18, 6, CAST(N'2023-05-19' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (19, 18, 6, CAST(N'2023-05-21' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (20, 18, 4, CAST(N'2023-05-22' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (28, 18, 3, CAST(N'2023-05-20' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (29, 19, 3, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (30, 19, 3, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (31, 19, 2, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (32, 19, 2, CAST(N'2023-05-19' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (33, 19, 3, CAST(N'2023-05-20' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (34, 19, 6, CAST(N'2023-05-21' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (35, 19, 6, CAST(N'2023-05-22' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (36, 20, 3, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (37, 20, 2, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (38, 20, 2, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (39, 20, 3, CAST(N'2023-05-19' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (40, 20, 6, CAST(N'2023-05-20' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (41, 20, 2, CAST(N'2023-05-21' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (42, 20, 6, CAST(N'2023-05-22' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (43, 21, 3, CAST(N'2023-05-22' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (44, 21, 6, CAST(N'2023-05-21' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (45, 21, 6, CAST(N'2023-05-20' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (46, 21, 5, CAST(N'2023-05-19' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (47, 21, 5, CAST(N'2023-05-18' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (48, 21, 3, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (49, 21, 4, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (50, 22, 2, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (51, 22, 3, CAST(N'2023-05-17' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (52, 23, 6, CAST(N'2023-05-16' AS Date))
INSERT [dbo].[EmployeeShift] ([EmployeeShiftID], [EmployeeID], [ShiftTimingID], [ShiftDate]) VALUES (53, 24, 5, CAST(N'2023-05-16' AS Date))
SET IDENTITY_INSERT [dbo].[EmployeeShift] OFF
GO
SET IDENTITY_INSERT [dbo].[Manager] ON 

INSERT [dbo].[Manager] ([ManagerID], [ManagerName]) VALUES (1, N'Manager Riad')
INSERT [dbo].[Manager] ([ManagerID], [ManagerName]) VALUES (2, N'Manager Rasif')
INSERT [dbo].[Manager] ([ManagerID], [ManagerName]) VALUES (3, N'Manager Iqbal')
SET IDENTITY_INSERT [dbo].[Manager] OFF
GO
SET IDENTITY_INSERT [dbo].[NonWorkingDay] ON 

INSERT [dbo].[NonWorkingDay] ([NonWorkingDayID], [NonWorkingDate], [HoliDayName]) VALUES (1, CAST(N'2023-05-01' AS Date), N'May Day')
INSERT [dbo].[NonWorkingDay] ([NonWorkingDayID], [NonWorkingDate], [HoliDayName]) VALUES (2, CAST(N'2023-07-16' AS Date), N'Eid-Ul-Adha')
SET IDENTITY_INSERT [dbo].[NonWorkingDay] OFF
GO
SET IDENTITY_INSERT [dbo].[ShiftTiming] ON 

INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (2, CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time), N'Morning Shift', N'M')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (3, CAST(N'10:00:00' AS Time), CAST(N'18:00:00' AS Time), N'Late Morning', N'LM')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (4, CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time), N'Evening', N'EV')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (5, CAST(N'23:00:00' AS Time), CAST(N'07:00:00' AS Time), N'Night Shift', N'N')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (6, CAST(N'23:00:00' AS Time), CAST(N'23:00:00' AS Time), N'Duty Off', N'DO')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (7, CAST(N'23:00:00' AS Time), CAST(N'23:00:00' AS Time), N'Advance Duty Off', N'ADO')
SET IDENTITY_INSERT [dbo].[ShiftTiming] OFF
GO
SET IDENTITY_INSERT [dbo].[WeekDays] ON 

INSERT [dbo].[WeekDays] ([WeekID], [WeekStartDate], [WeekEndTime]) VALUES (1, CAST(N'2023-05-16' AS Date), CAST(N'2023-05-22' AS Date))
SET IDENTITY_INSERT [dbo].[WeekDays] OFF
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Manager] FOREIGN KEY([ManagerID])
REFERENCES [dbo].[Manager] ([ManagerID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Manager]
GO
ALTER TABLE [dbo].[EmployeeShift]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeShift_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeShift] CHECK CONSTRAINT [FK_EmployeeShift_Employee]
GO
ALTER TABLE [dbo].[EmployeeShift]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeShift_ShiftTiming] FOREIGN KEY([ShiftTimingID])
REFERENCES [dbo].[ShiftTiming] ([ShiftTimingID])
GO
ALTER TABLE [dbo].[EmployeeShift] CHECK CONSTRAINT [FK_EmployeeShift_ShiftTiming]
GO
/****** Object:  StoredProcedure [dbo].[GetDictionaryData]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetDictionaryData]

	-- Add the parameters for the stored procedure here
	@info varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    if @info = 'Shift' select ShiftTimingID,ShiftCode,ShiftName from ShiftTiming 
	
END
GO
/****** Object:  StoredProcedure [dbo].[GetShiftCountEveryDay]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetShiftCountEveryDay]
@date date
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SELECT
    EmployeeShift.ShiftDate AS Date,
    STUFF(
        (
            SELECT
                ', ' + ShiftTiming.ShiftName + '-' + CONVERT(VARCHAR(10), COUNT(*))
            FROM
                EmployeeShift AS es
            INNER JOIN
                ShiftTiming ON es.ShiftTimingID = ShiftTiming.ShiftTimingID
            WHERE
                es.ShiftDate = @date
            GROUP BY
                ShiftTiming.ShiftName
            FOR XML PATH('')
        ), 1, 2, '') AS ShiftNames,
    COUNT(*) AS ShiftCount
FROM
    EmployeeShift
WHERE
    EmployeeShift.ShiftDate =@date
GROUP BY
    EmployeeShift.ShiftDate;

    --EmployeeShift.ShiftDate = '2023-05-16'


	
END

--exec GetShiftCountEveryDay '2023-05-16'
GO
/****** Object:  StoredProcedure [dbo].[GetShiftInfoData]    Script Date: 5/19/2023 5:50:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[GetShiftInfoData]

	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT        Employee.EmployeeName, Employee.EmployeeID, Employee.Gender, ShiftTiming.ShiftTimingID, ShiftTiming.ShiftName, EmployeeShift.EmployeeShiftID, EmployeeShift.ShiftDate 
                         
FROM            EmployeeShift INNER JOIN
                         ShiftTiming ON EmployeeShift.ShiftTimingID = ShiftTiming.ShiftTimingID INNER JOIN
                         Employee ON EmployeeShift.EmployeeID = Employee.EmployeeID
	
END
GO
