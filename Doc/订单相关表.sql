USE [SaleTools]
GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 2018/3/22 0:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderNum] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[Stutas] [int] NULL,
	[SendPeople] [nvarchar](50) NULL,
	[PayTime] [datetime] NULL,
	[SendTime] [datetime] NULL,
	[PayType] [nvarchar](50) NULL,
	[TotalMoney] [decimal](18, 2) NULL,
	[LessMoney] [decimal](18, 2) NULL,
	[RealMoney] [decimal](18, 2) NULL,
	[PayMoney] [decimal](18, 2) NULL,
	[Remark] [nvarchar](500) NULL,
	[RootUserId] [uniqueidentifier] NULL,
	[RootUserName] [nvarchar](50) NULL,
	[CreateUserId] [uniqueidentifier] NOT NULL,
	[CreateUserName] [nvarchar](50) NULL,
	[CreateUserTypeId] [uniqueidentifier] NULL,
	[CreateUserType] [nvarchar](50) NULL,
	[IsDelete] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 2018/3/22 0:24:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[Id] [uniqueidentifier] NULL,
	[OrderId] [uniqueidentifier] NULL,
	[OrderNum] [nvarchar](50) NULL,
	[ProductId] [uniqueidentifier] NULL,
	[ProductTittle] [nvarchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
	[RealPrice] [decimal](18, 2) NOT NULL,
	[Count] [int] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[LessPrice] [decimal](18, 2) NULL,
	[IsDelete] [bit] NULL,
	[IsEffective] [bit] NULL,
	[IsInShoppingCar] [bit] NULL,
	[CreateUserId] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
