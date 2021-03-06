USE [master]
GO
/****** Object:  Database [SaleTools]    Script Date: 2018/2/27 23:57:51 ******/
CREATE DATABASE [SaleTools]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SaleTools', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SaleTools.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SaleTools_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\SaleTools_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SaleTools] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SaleTools].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SaleTools] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SaleTools] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SaleTools] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SaleTools] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SaleTools] SET ARITHABORT OFF 
GO
ALTER DATABASE [SaleTools] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SaleTools] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SaleTools] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SaleTools] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SaleTools] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SaleTools] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SaleTools] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SaleTools] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SaleTools] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SaleTools] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SaleTools] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SaleTools] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SaleTools] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SaleTools] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SaleTools] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SaleTools] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SaleTools] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SaleTools] SET RECOVERY FULL 
GO
ALTER DATABASE [SaleTools] SET  MULTI_USER 
GO
ALTER DATABASE [SaleTools] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SaleTools] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SaleTools] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SaleTools] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SaleTools] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SaleTools', N'ON'
GO
ALTER DATABASE [SaleTools] SET QUERY_STORE = OFF
GO
USE [SaleTools]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SaleTools]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 2018/2/27 23:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num] [nchar](10) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[ParentNum] [nchar](10) NULL,
	[ParentName] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BrandOfGoodsType]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BrandOfGoodsType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TypeId] [uniqueidentifier] NULL,
	[BandsId] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodInfo]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodInfo](
	[Id] [uniqueidentifier] NOT NULL,
	[GoodsNum] [nchar](50) NULL,
	[BarCode] [nchar](50) NOT NULL,
	[MiddleCode] [nchar](50) NOT NULL,
	[BoxCode] [nchar](50) NOT NULL,
	[SupplierId] [int] NOT NULL,
	[SupplierNum] [nvarchar](50) NOT NULL,
	[SupplierName] [nvarchar](500) NOT NULL,
	[FirstTypeId] [uniqueidentifier] NULL,
	[FirstTypeName] [nvarchar](200) NULL,
	[SecondTypeId] [uniqueidentifier] NULL,
	[SecondTypeName] [nvarchar](200) NULL,
	[ThirdTYypeId] [uniqueidentifier] NULL,
	[ThirdTypeName] [nchar](10) NULL,
	[GoodsTittle] [nvarchar](500) NULL,
	[GoodsSubTittle] [nvarchar](500) NOT NULL,
	[BrandId] [uniqueidentifier] NULL,
	[BrandName] [nvarchar](200) NULL,
	[RetailtPrice] [decimal](18, 2) NULL,
	[MarketPrice] [decimal](18, 2) NULL,
	[CostPrice] [decimal](18, 2) NULL,
	[Stock] [int] NULL,
	[IsLockStork] [bit] NULL,
	[BoxSpec] [nvarchar](100) NULL,
	[Spec] [nvarchar](100) NULL,
	[Unit] [nvarchar](10) NULL,
	[Weight] [int] NULL,
	[Size] [nvarchar](50) NULL,
	[ShelfLife] [int] NULL,
	[MinCount] [int] NULL,
	[LimitCount] [int] NULL,
	[pic1] [nvarchar](500) NULL,
	[pic2] [nvarchar](500) NULL,
	[pic3] [nvarchar](500) NULL,
	[pic4] [nvarchar](500) NULL,
	[pic5] [nvarchar](500) NULL,
	[KeyWord] [nvarchar](500) NULL,
	[Detail] [nvarchar](1000) NULL,
	[CreateUserId] [uniqueidentifier] NULL,
	[CreateUserName] [nvarchar](50) NULL,
	[IsDelete] [bit] NULL,
	[CreateTime] [datetime] NULL,
	[LastUpdateTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsBrand]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsBrand](
	[Id] [uniqueidentifier] NOT NULL,
	[BrandName] [nvarchar](200) NOT NULL,
	[Country] [nvarchar](200) NULL,
	[IsDelete] [bit] NULL,
	[CreateUserId] [uniqueidentifier] NULL,
	[CreateUserName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoodsType]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoodsType](
	[Id] [uniqueidentifier] NOT NULL,
	[TypeName] [nvarchar](200) NOT NULL,
	[ParentId] [uniqueidentifier] NULL,
	[ParentName] [nvarchar](200) NULL,
	[IsDelete] [bit] NULL,
	[CreateUserId] [uniqueidentifier] NULL,
	[CreateUserName] [nvarchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PriceOfUserType]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PriceOfUserType](
	[GoodsId] [uniqueidentifier] NULL,
	[UserTypeId] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[CreateTime] [nchar](10) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SupplierNum] [nvarchar](20) NOT NULL,
	[SupplierName] [nvarchar](500) NOT NULL,
	[SupplierCompany] [nvarchar](500) NOT NULL,
	[Tel] [nchar](20) NOT NULL,
	[CreateUserId] [uniqueidentifier] NOT NULL,
	[CreateUserName] [nvarchar](50) NOT NULL,
	[IsDelete] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [uniqueidentifier] NOT NULL,
	[UserNum] [nvarchar](50) NOT NULL,
	[Account] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[PassWord] [nvarchar](100) NOT NULL,
	[IsLocked] [bit] NULL,
	[IsDelete] [bit] NULL,
	[CreateTime] [datetime] NULL,
	[CreateUser] [nvarchar](100) NULL,
	[CreateUserId] [uniqueidentifier] NULL,
	[TypeId] [int] NULL,
	[TypeName] [nvarchar](100) NULL,
	[Province] [nvarchar](200) NULL,
	[ProvinceNum] [nchar](10) NULL,
	[City] [nvarchar](200) NULL,
	[CityNum] [nchar](10) NULL,
	[Area] [nvarchar](200) NULL,
	[AreaNum] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 2018/2/27 23:57:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](100) NOT NULL,
	[IsAdmin] [bit] NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [SaleTools] SET  READ_WRITE 
GO
