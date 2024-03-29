USE [master]
GO
/****** Object:  Database [SaleManagement]    Script Date: 10/23/2021 6:55:03 PM ******/
CREATE DATABASE [SaleManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SaleManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SaleManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SaleManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SaleManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SaleManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SaleManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SaleManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SaleManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SaleManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SaleManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SaleManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [SaleManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SaleManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SaleManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SaleManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SaleManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SaleManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SaleManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SaleManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SaleManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SaleManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SaleManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SaleManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SaleManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SaleManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SaleManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SaleManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SaleManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SaleManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SaleManagement] SET  MULTI_USER 
GO
ALTER DATABASE [SaleManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SaleManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SaleManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SaleManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SaleManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SaleManagement] SET QUERY_STORE = OFF
GO
USE [SaleManagement]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 10/23/2021 6:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[MemberId] [int] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[CompanyName] [varchar](40) NOT NULL,
	[City] [varchar](15) NOT NULL,
	[Country] [varchar](15) NOT NULL,
	[Password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 10/23/2021 6:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/23/2021 6:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/23/2021 6:55:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[ProductName] [varchar](40) NOT NULL,
	[Weight] [varchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitsInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'phuong@gmail.com', N'KMS', N'Da Nang', N'Viet Nam', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'hanh@gmail.com', N'Dien Luc Tan Thuan', N'Da Nang', N'USA', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (4, N'binh@gmail.com', N'Thanh Da High School', N'Ha Noi', N'UK', N'123')
INSERT [dbo].[Member] ([MemberId], [Email], [CompanyName], [City], [Country], [Password]) VALUES (5, N'phuongnnse150998@fpt.edu.vn', N'FPTU', N'Ho Chi Minh', N'Viet Nam', N'123')
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 125000.0000, 2, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (1, 2, 90000.0000, 3, 10)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 3, 80000.0000, 1, 10)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (2, 4, 100000.0000, 2, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [ProductId], [UnitPrice], [Quantity], [Discount]) VALUES (3, 6, 25000.0000, 5, 0)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 2, CAST(N'2021-10-20T00:00:00.000' AS DateTime), CAST(N'2021-10-22T00:00:00.000' AS DateTime), CAST(N'2021-10-21T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 2, CAST(N'2021-09-20T00:00:00.000' AS DateTime), CAST(N'2021-09-22T00:00:00.000' AS DateTime), CAST(N'2021-09-21T00:00:00.000' AS DateTime), 20000.0000)
INSERT [dbo].[Orders] ([OrderId], [MemberId], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 1, CAST(N'2021-10-23T18:07:42.887' AS DateTime), CAST(N'2021-10-23T18:07:42.993' AS DateTime), CAST(N'2021-10-23T18:07:43.003' AS DateTime), 15000.0000)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'Pork', N'12', 125000.0000, 5)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (2, 1, N'Beef', N'1', 90000.0000, 6)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (3, 2, N'Chicken Meat', N'2', 80000.0000, 7)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'Fish', N'5', 100000.0000, 5)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (5, 3, N'Goat Meat', N'7', 160000.0000, 2)
INSERT [dbo].[Product] ([ProductId], [CategoryId], [ProductName], [Weight], [UnitPrice], [UnitsInStock]) VALUES (6, 1, N'Eggs', N'6', 25000.0000, 5)
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([OrderId])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO
USE [master]
GO
ALTER DATABASE [SaleManagement] SET  READ_WRITE 
GO
