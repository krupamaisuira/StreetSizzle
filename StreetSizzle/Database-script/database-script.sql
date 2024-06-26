Create database  streetsizzledb;
GO
USE [streetsizzledb]
GO
/****** Object:  Table [dbo].[tblContact]    Script Date: 2024-04-01 10:59:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContact](
	[contactID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[emailID] [varchar](100) NULL,
	[subject] [varchar](150) NULL,
	[message] [varchar](max) NULL,
	[createdOn] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblreservation]    Script Date: 2024-04-01 10:59:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblreservation](
	[reservationID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[emailID] [varchar](100) NULL,
	[date] [date] NULL,
	[time] [varchar](10) NULL,
	[guest] [int] NULL,
	[createdOn] [datetime] NULL
) ON [PRIMARY]
GO
