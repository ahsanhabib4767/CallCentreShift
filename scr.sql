USE [Test]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 16-05-2023 1:49:17 PM ******/
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
/****** Object:  Table [dbo].[EmployeeShift]    Script Date: 16-05-2023 1:49:17 PM ******/
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
/****** Object:  Table [dbo].[Manager]    Script Date: 16-05-2023 1:49:17 PM ******/
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
/****** Object:  Table [dbo].[NonWorkingDay]    Script Date: 16-05-2023 1:49:17 PM ******/
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
/****** Object:  Table [dbo].[ShiftTiming]    Script Date: 16-05-2023 1:49:17 PM ******/
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
/****** Object:  Table [dbo].[WeekDays]    Script Date: 16-05-2023 1:49:17 PM ******/
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
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (18, N'20180910001', N'SADIA ISLAM RATNA-CCE', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (19, N'20180911001', N'RAJIA SULTANA-JA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (20, N'20181025001', N'SALMA AHMED-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (21, N'20181025002', N'FARIDA AHMED-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (22, N'20181031001', N'MD. EMON MIAN-CCE', 1, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (23, N'20190409001', N'NUSRAT RAHMAN-SA', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (24, N'20190424001', N'RAKIB KHAN-JA', 1, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (25, N'20190505001', N'MD. NAFIUZZAMAN-CCE', 1, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (26, N'20190507002', N'SHAMMI AKTER-CCE', 1, N'F')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (27, N'20190507005', N'MD. NAZMUL HUDA-CCE', 2, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (28, N'20200315001', N'MOHAMMAD EASIN KHAN-CCE', 2, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (29, N'20200316001', N'MOHAMMAD SUMON HOSSAIN-SA', 2, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (30, N'20200503001', N'MD. SAZZADUR RAHAMAN TONMOY-CCE', 2, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (31, N'20200503002', N'IQBAL KABIR-CCE', 2, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (32, N'20200503003', N'PROTAP KUMAR BISWAS-CCE', 3, N'M')
INSERT [dbo].[Employee] ([EmployeeID], [EmpIdentity], [EmployeeName], [ManagerID], [Gender]) VALUES (33, N'20200517001', N'MD. RUBEL-CCE', 3, N'M')
SET IDENTITY_INSERT [dbo].[Employee] OFF
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
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (4, CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time), N'Evening', N'E')
INSERT [dbo].[ShiftTiming] ([ShiftTimingID], [ShiftStartTime], [ShiftEndTime], [ShiftName], [ShiftCode]) VALUES (5, CAST(N'23:00:00' AS Time), CAST(N'07:00:00' AS Time), N'Night Shift', N'N')
SET IDENTITY_INSERT [dbo].[ShiftTiming] OFF
GO
SET IDENTITY_INSERT [dbo].[WeekDays] ON 

INSERT [dbo].[WeekDays] ([WeekID], [WeekStartDate], [WeekEndTime]) VALUES (1, CAST(N'2023-05-16' AS Date), CAST(N'2023-07-22' AS Date))
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
