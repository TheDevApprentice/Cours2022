USE Travail1bis
Go

CREATE PROCEDURE selection2Tables
	
	
AS

select *
   from [dbo].[tbl_cours]
  
  select *
   from [dbo].[tbl_categorie]


BEGIN
	
	SET NOCOUNT ON;


END
GO

exec selection2Tables