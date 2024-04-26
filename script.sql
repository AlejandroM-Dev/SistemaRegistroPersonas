USE [master]
GO
/****** Object:  Database [DbRegistroPrueba]    Script Date: 26/04/2024 1:15:09 a. m. ******/
CREATE DATABASE [DbRegistroPrueba]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbRegistroPrueba', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DbRegistroPrueba.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbRegistroPrueba_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DbRegistroPrueba_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DbRegistroPrueba] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbRegistroPrueba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbRegistroPrueba] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbRegistroPrueba] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbRegistroPrueba] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbRegistroPrueba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbRegistroPrueba] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET RECOVERY FULL 
GO
ALTER DATABASE [DbRegistroPrueba] SET  MULTI_USER 
GO
ALTER DATABASE [DbRegistroPrueba] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbRegistroPrueba] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbRegistroPrueba] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbRegistroPrueba] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbRegistroPrueba] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbRegistroPrueba] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbRegistroPrueba', N'ON'
GO
ALTER DATABASE [DbRegistroPrueba] SET QUERY_STORE = ON
GO
ALTER DATABASE [DbRegistroPrueba] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DbRegistroPrueba]
GO
/****** Object:  Table [dbo].[RegistroPersonas]    Script Date: 26/04/2024 1:15:09 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroPersonas](
	[IdRegistro] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [int] NOT NULL,
	[Nombres] [nvarchar](90) NULL,
	[Apellidos] [nvarchar](90) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Celular] [bigint] NULL,
	[TelefonoAlternativo] [bigint] NULL,
	[CorreoElectronico] [nvarchar](50) NULL,
	[CorreoElectronicoAlternativo] [nvarchar](50) NULL,
	[Direccion] [nvarchar](150) NULL,
	[DireccionAltenativa] [nvarchar](150) NULL,
 CONSTRAINT [PK_RegistroPersonas] PRIMARY KEY CLUSTERED 
(
	[IdRegistro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [DbRegistroPrueba] SET  READ_WRITE 
GO
