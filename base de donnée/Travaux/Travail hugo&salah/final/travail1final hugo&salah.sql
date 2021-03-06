USE [master]
GO
/****** Object:  Database [travail_1]    Script Date: 08/02/2022 21:08:26 ******/
CREATE DATABASE [travail_1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'travail_1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\travail_1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'travail_1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\travail_1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [travail_1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [travail_1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [travail_1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [travail_1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [travail_1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [travail_1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [travail_1] SET ARITHABORT OFF 
GO
ALTER DATABASE [travail_1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [travail_1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [travail_1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [travail_1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [travail_1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [travail_1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [travail_1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [travail_1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [travail_1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [travail_1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [travail_1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [travail_1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [travail_1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [travail_1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [travail_1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [travail_1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [travail_1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [travail_1] SET RECOVERY FULL 
GO
ALTER DATABASE [travail_1] SET  MULTI_USER 
GO
ALTER DATABASE [travail_1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [travail_1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [travail_1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [travail_1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [travail_1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [travail_1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'travail_1', N'ON'
GO
ALTER DATABASE [travail_1] SET QUERY_STORE = OFF
GO
USE [travail_1]
GO
/****** Object:  Table [dbo].[tbl_identiteNageur2]    Script Date: 08/02/2022 21:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_identiteNageur2](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[noDeLicence] [int] NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[adressePostale] [nvarchar](100) NULL,
	[adresseMail] [nvarchar](100) NULL,
	[noTel] [nchar](13) NULL,
 CONSTRAINT [PK_tbl_identiteNageur2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_niveau]    Script Date: 08/02/2022 21:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_niveau](
	[nbCoursDeNatations] [int] NULL,
	[categories] [nvarchar](50) NULL,
	[typeDeNiveau] [nvarchar](50) NULL,
	[niveau] [int] NULL,
	[id] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_niveau] ADD  CONSTRAINT [DF_tbl_niveau_categories]  DEFAULT (N'adulte') FOR [categories]
GO
ALTER TABLE [dbo].[tbl_niveau] ADD  CONSTRAINT [DF_tbl_niveau_typeDeNiveau]  DEFAULT (N'debutant') FOR [typeDeNiveau]
GO
ALTER TABLE [dbo].[tbl_niveau]  WITH CHECK ADD  CONSTRAINT [FK_tbl_niveau_tbl_identiteNageur2] FOREIGN KEY([id])
REFERENCES [dbo].[tbl_identiteNageur2] ([id])
GO
ALTER TABLE [dbo].[tbl_niveau] CHECK CONSTRAINT [FK_tbl_niveau_tbl_identiteNageur2]
GO
ALTER TABLE [dbo].[tbl_identiteNageur2]  WITH CHECK ADD  CONSTRAINT [CK_tbl_identiteNageur2] CHECK  (([adresseMail] like '%@%'))
GO
ALTER TABLE [dbo].[tbl_identiteNageur2] CHECK CONSTRAINT [CK_tbl_identiteNageur2]
GO
ALTER TABLE [dbo].[tbl_niveau]  WITH CHECK ADD  CONSTRAINT [CK_tbl_niveau] CHECK  (([categories]='senior' OR [categories]='adulte' OR [categories]='junior' OR [categories]='prescolaire'))
GO
ALTER TABLE [dbo].[tbl_niveau] CHECK CONSTRAINT [CK_tbl_niveau]
GO
ALTER TABLE [dbo].[tbl_niveau]  WITH CHECK ADD  CONSTRAINT [CK_tbl_niveau_1] CHECK  (([typeDeNiveau]='requin' OR [typeDeNiveau]='espadon' OR [typeDeNiveau]='dauphin' OR [typeDeNiveau]='nemo' OR [typeDeNiveau]='etoile de mer'))
GO
ALTER TABLE [dbo].[tbl_niveau] CHECK CONSTRAINT [CK_tbl_niveau_1]
GO
ALTER TABLE [dbo].[tbl_niveau]  WITH CHECK ADD  CONSTRAINT [CK_tbl_niveau_2] CHECK  (([niveau]>=(0) AND [niveau]<=(5)))
GO
ALTER TABLE [dbo].[tbl_niveau] CHECK CONSTRAINT [CK_tbl_niveau_2]
GO
ALTER TABLE [dbo].[tbl_niveau]  WITH CHECK ADD  CONSTRAINT [CK_tbl_niveau_3] CHECK  (([nbCoursDeNatations]>=(0) AND [nbCoursDeNatations]<=(600)))
GO
ALTER TABLE [dbo].[tbl_niveau] CHECK CONSTRAINT [CK_tbl_niveau_3]
GO
/****** Object:  StoredProcedure [dbo].[selection2Tables8]    Script Date: 08/02/2022 21:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selection2Tables8]
	
	--@id int, @noDeLicence int, @nom nvarchar(50), @prenom nvarchar(50), @adressePostale nvarchar(100), @adresseMail nvarchar(100), @noTel nchar(13),

	----tbl_identiteNageur2.id, tbl_identiteNageur2.noDeLicence , tbl_identiteNageur2.nom, tbl_identiteNageur2.prenom, tbl_identiteNageur2.adressePostale, tbl_identiteNageur2.adresseMail, tbl_identiteNageur2.noTel

AS

select tbl_identiteNageur2.id, tbl_identiteNageur2.noDeLicence , tbl_identiteNageur2.nom, tbl_identiteNageur2.prenom, tbl_identiteNageur2.adressePostale, tbl_identiteNageur2.adresseMail, tbl_identiteNageur2.noTel,
tbl_niveau.nbCoursDeNatations, tbl_niveau.categories, tbl_niveau.typeDeNiveau, tbl_niveau.niveau
   from [dbo].[tbl_identiteNageur2]
    join tbl_niveau  on tbl_identiteNageur2.id = tbl_niveau.id
    order by tbl_identiteNageur2.nom ;

	--tbl_identiteNageur2.id, tbl_identiteNageur2.noDeLicence , tbl_identiteNageur2.nom, tbl_identiteNageur2.prenom, tbl_identiteNageur2.adressePostale, tbl_identiteNageur2.adresseMail, tbl_identiteNageur2.noTel
--SELECT [id]
--      ,[noDeLicence]
--      ,[nom]
--      ,[prenom]
--      ,[adressePostale]
--      ,[adresseMail]
--      ,[noTel]
--  FROM [dbo].[tbl_identiteNageur2]

--SELECT [id]
--      ,[nbCoursDeNatations]
--      ,[categories]
--      ,[typeDeNiveau]
--      ,[niveau]
--  FROM [dbo].[tbl_niveau]

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	--SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO
USE [master]
GO
ALTER DATABASE [travail_1] SET  READ_WRITE 
GO
