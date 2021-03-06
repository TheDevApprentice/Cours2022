USE [AH_EXERCICES]
GO
/****** Object:  Table [dbo].[info_etudiant]    Script Date: 2022-02-23 15:22:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[info_etudiant](
	[No_etudiant] [smallint] IDENTITY(1,1) NOT NULL,
	[Nom] [nchar](20) NOT NULL,
	[Prenom] [nchar](20) NOT NULL,
	[Age] [int] NULL,
	[Pays] [nchar](30) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[ajouterEtudiants]    Script Date: 2022-02-23 15:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ajouterEtudiants]
	-- Add the parameters for the stored procedure here
@nom nchar(20),
@prenom nchar(20),
@age int,
@pays nchar(30)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

INSERT INTO [dbo].[info_etudiant]
           ([Nom]
           ,[Prenom]
           ,[Age]
           ,[Pays])
     VALUES
           (@Nom
           ,@Prenom
           ,@Age
           ,@Pays)

END
GO
/****** Object:  StoredProcedure [dbo].[ajouterJeu]    Script Date: 2022-02-23 15:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ajouterJeu]
@nom_jeu nvarchar(50),
@description nvarchar(200)

AS
BEGIN
	INSERT INTO [dbo].[tbl_jeu]
           ([nom_jeu]
           ,[description])
     VALUES
           (@nom_jeu
		   ,@description)
END
GO
/****** Object:  StoredProcedure [dbo].[ajouterJeu9]    Script Date: 2022-02-23 15:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ajouterJeu9]
	@nom_jeu nchar(100),
	@description nchar(1000)

AS
BEGIN
	INSERT INTO [dbo].[tbl_jeu]
           ([nom_jeu]
           ,[description])
     VALUES
           (@nom_jeu
		   ,@description)
END
GO
/****** Object:  StoredProcedure [dbo].[ajouterJeux]    Script Date: 2022-02-23 15:22:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ajouterJeux]
	@nom_jeu nchar(100),
	@description nchar(1000)

AS
BEGIN
	INSERT INTO [dbo].[tbl_jeu]
           ([nom_jeu]
           ,[description])
     VALUES
           (@nom_jeu
		   ,@description)
END
GO
