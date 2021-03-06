USE [master]
GO
/****** Object:  Database [Materials]    Script Date: 12/05/2022 12:41:23 p. m. ******/
CREATE DATABASE [Materials]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Materials', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Materials.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Materials_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Materials_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Materials] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Materials].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Materials] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Materials] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Materials] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Materials] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Materials] SET ARITHABORT OFF 
GO
ALTER DATABASE [Materials] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Materials] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Materials] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Materials] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Materials] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Materials] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Materials] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Materials] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Materials] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Materials] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Materials] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Materials] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Materials] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Materials] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Materials] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Materials] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Materials] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Materials] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Materials] SET  MULTI_USER 
GO
ALTER DATABASE [Materials] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Materials] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Materials] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Materials] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Materials] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Materials] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Materials] SET QUERY_STORE = OFF
GO
USE [Materials]
GO
/****** Object:  Table [dbo].[Buildings]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Buildings](
	[PKBuilding] [int] IDENTITY(1,1) NOT NULL,
	[Building] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKBuilding] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[PKCustomers] [int] IDENTITY(1,1) NOT NULL,
	[Customer] [varchar](50) NOT NULL,
	[Prefix] [varchar](5) NOT NULL,
	[FKBuilding] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKCustomers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PartNumbers]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PartNumbers](
	[PKPartNumber] [int] IDENTITY(1,1) NOT NULL,
	[PartNumber] [varchar](50) NOT NULL,
	[Available] [bit] NOT NULL,
	[FKCustomer] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PKPartNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Buildings] ON 

INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (1, N'kolok')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (2, N'Mad. Sq. Garden')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (3, N'Trump Tower')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (4, N'Twin Towers')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (5, N'Torre Latino')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (6, N'Big_Ben')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (9, N'Empire_State')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (10, N'Satple_Center')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (11, N'Edificio Azteca')
INSERT [dbo].[Buildings] ([PKBuilding], [Building]) VALUES (12, N'CNDH')
SET IDENTITY_INSERT [dbo].[Buildings] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (1, N'Alejandro', N'55555', 1)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (2, N'Fernanda', N'29587', 2)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (3, N'Abril', N'46932', 3)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (4, N'Carlos', N'10025', 4)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (5, N'Enrique', N'00001', 5)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (6, N'Manuel', N'66666', 6)
INSERT [dbo].[Customers] ([PKCustomers], [Customer], [Prefix], [FKBuilding]) VALUES (7, N'Joaquin', N'12345', 9)
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[PartNumbers] ON 

INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (1, N'A6969', 1, 1)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (2, N'B1996', 1, 2)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (3, N'C1999', 1, 3)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (4, N'D1968', 1, 4)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (5, N'E3969', 0, 5)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (6, N'F4567', 1, 6)
INSERT [dbo].[PartNumbers] ([PKPartNumber], [PartNumber], [Available], [FKCustomer]) VALUES (8, N'G9999', 0, 7)
SET IDENTITY_INSERT [dbo].[PartNumbers] OFF
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers] FOREIGN KEY([FKBuilding])
REFERENCES [dbo].[Buildings] ([PKBuilding])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers]
GO
ALTER TABLE [dbo].[PartNumbers]  WITH CHECK ADD  CONSTRAINT [FK_PartNumbers] FOREIGN KEY([FKCustomer])
REFERENCES [dbo].[Customers] ([PKCustomers])
GO
ALTER TABLE [dbo].[PartNumbers] CHECK CONSTRAINT [FK_PartNumbers]
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Buiding]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Buiding]
	@Building varchar(50)
AS
Begin
	SET NOCOUNT ON;
	
	BEGIN TRY
		BEGIN TRAN TR1

			INSERT INTO [dbo].[Buildings]
						([Building])
				VALUES
						(@Building)
		COMMIT TRAN TR1
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
			ROLLBACK TRAN TR1
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Customers]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Customers]
	@Customer varchar(50),
	@Prefix varchar(5),
	@FKBuilding int
AS
Begin
	SET NOCOUNT ON;
	
	BEGIN TRY
		BEGIN TRAN TR2

			INSERT INTO [dbo].[Customers]
					   ([Customer]
					   ,[Prefix]
					   ,[FKBuilding])
				 VALUES
					   (@Customer,
					   @Prefix,
					   @FKBuilding)

		COMMIT TRAN TR2
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
			ROLLBACK TRAN TR2
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_PartNumbers]    Script Date: 12/05/2022 12:41:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_PartNumbers]
	@PartNumber varchar(50),
	@Available bit,
	@FKCustomer int
AS
Begin
	SET NOCOUNT ON;
	
	BEGIN TRY
		BEGIN TRAN TR3

			INSERT INTO [dbo].[PartNumbers]
					   ([PartNumber]
					   ,[Available]
					   ,[FKCustomer])
				 VALUES
					   (@PartNumber,
					   @Available,
					   @FKCustomer)

		COMMIT TRAN TR3
	END TRY
	BEGIN CATCH
		IF (@@TRANCOUNT > 0)
			ROLLBACK TRAN TR3
	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [Materials] SET  READ_WRITE 
GO
