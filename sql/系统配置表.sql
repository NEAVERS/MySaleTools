USE [SaleTools]
GO

/****** Object:  Table [dbo].[SysConfig]    Script Date: 2018/4/7 23:04:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SysConfig](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Value] [nvarchar](500) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[UpdateUser] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO

