USE [master]
GO
/****** Object:  Database [Travail1bis]    Script Date: 09/02/2022 16:22:32 ******/
CREATE DATABASE [Travail1bis]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Travail1bis', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Travail1bis.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Travail1bis_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Travail1bis_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Travail1bis] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Travail1bis].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Travail1bis] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Travail1bis] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Travail1bis] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Travail1bis] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Travail1bis] SET ARITHABORT OFF 
GO
ALTER DATABASE [Travail1bis] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Travail1bis] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Travail1bis] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Travail1bis] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Travail1bis] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Travail1bis] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Travail1bis] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Travail1bis] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Travail1bis] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Travail1bis] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Travail1bis] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Travail1bis] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Travail1bis] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Travail1bis] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Travail1bis] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Travail1bis] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Travail1bis] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Travail1bis] SET RECOVERY FULL 
GO
ALTER DATABASE [Travail1bis] SET  MULTI_USER 
GO
ALTER DATABASE [Travail1bis] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Travail1bis] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Travail1bis] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Travail1bis] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Travail1bis] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Travail1bis] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Travail1bis', N'ON'
GO
ALTER DATABASE [Travail1bis] SET QUERY_STORE = OFF
GO
USE [Travail1bis]
GO
/****** Object:  Table [dbo].[tbl_categorie]    Script Date: 09/02/2022 16:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_categorie](
	[no_categorie] [int] IDENTITY(1,1) NOT NULL,
	[nom_categorie] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_categorie] PRIMARY KEY CLUSTERED 
(
	[no_categorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_cours]    Script Date: 09/02/2022 16:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cours](
	[no_cours] [int] IDENTITY(1,1) NOT NULL,
	[nom_cours] [nvarchar](50) NOT NULL,
	[nbHeureDeCours] [nvarchar](50) NOT NULL,
	[mixte] [nvarchar](10) NULL,
 CONSTRAINT [PK_tbl_cours] PRIMARY KEY CLUSTERED 
(
	[no_cours] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_cours] ADD  CONSTRAINT [DF_tbl_cours_mixte]  DEFAULT (N'oui') FOR [mixte]
GO
ALTER TABLE [dbo].[tbl_categorie]  WITH CHECK ADD  CONSTRAINT [CK_tbl_categorie] CHECK  (([nom_categorie]='senior' OR [nom_categorie]='adulte' OR [nom_categorie]='junior'))
GO
ALTER TABLE [dbo].[tbl_categorie] CHECK CONSTRAINT [CK_tbl_categorie]
GO
ALTER TABLE [dbo].[tbl_cours]  WITH CHECK ADD  CONSTRAINT [CK_tbl_cours] CHECK  (([mixte]='non' OR [mixte]='oui'))
GO
ALTER TABLE [dbo].[tbl_cours] CHECK CONSTRAINT [CK_tbl_cours]
GO
ALTER TABLE [dbo].[tbl_cours]  WITH CHECK ADD  CONSTRAINT [CK_tbl_cours_1] CHECK  (([nom_cours]='requin' OR [nom_cours]='espadon' OR [nom_cours]='nemo' OR [nom_cours]='etoile de mer'))
GO
ALTER TABLE [dbo].[tbl_cours] CHECK CONSTRAINT [CK_tbl_cours_1]
GO
ALTER TABLE [dbo].[tbl_cours]  WITH CHECK ADD  CONSTRAINT [CK_tbl_cours_2] CHECK  (([nbHeureDeCours]>=(0) AND [nbHeureDeCours]<=(600)))
GO
ALTER TABLE [dbo].[tbl_cours] CHECK CONSTRAINT [CK_tbl_cours_2]
GO
/****** Object:  StoredProcedure [dbo].[selection2Tables]    Script Date: 09/02/2022 16:22:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selection2Tables]
	
	
AS

select *
   from [dbo].[tbl_cours]
  
  select *
   from [dbo].[tbl_categorie]


BEGIN
	
	SET NOCOUNT ON;


END
GO
USE [master]
GO
ALTER DATABASE [Travail1bis] SET  READ_WRITE 
GO

USE Travail1bis
Go

exec selection2Tables