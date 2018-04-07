USE [SaleTools]
GO

/****** Object:  Table [dbo].[ImgSet]    Script Date: 2018/4/7 23:05:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ImgSet](
	[Id] [uniqueidentifier] NULL,
	[Ttile] [nvarchar](500) NULL,
	[ImgUrl] [nvarchar](500) NULL,
	[TurnUrl] [nvarchar](500) NULL,
	[ImgType] [nvarchar](50) NULL,
	[SortedId] [int] NULL
) ON [PRIMARY]
GO

