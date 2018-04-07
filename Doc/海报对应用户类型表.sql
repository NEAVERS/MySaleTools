USE [SaleTools]
GO

/****** Object:  Table [dbo].[ImgSetOfUserType]    Script Date: 2018/4/7 23:05:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ImgSetOfUserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserType] [int] NULL,
	[ImgSetId] [uniqueidentifier] NULL
) ON [PRIMARY]
GO

