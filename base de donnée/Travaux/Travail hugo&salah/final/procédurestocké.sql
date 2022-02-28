USE travail_1
Go

CREATE PROCEDURE selection2Tables
	
AS

select tbl_identiteNageur2.id, tbl_identiteNageur2.noDeLicence , tbl_identiteNageur2.nom, tbl_identiteNageur2.prenom, tbl_identiteNageur2.adressePostale, tbl_identiteNageur2.adresseMail, tbl_identiteNageur2.noTel,
tbl_niveau.nbCoursDeNatations, tbl_niveau.categories, tbl_niveau.typeDeNiveau, tbl_niveau.niveau
   from [dbo].[tbl_identiteNageur2]
    join tbl_niveau  on tbl_identiteNageur2.id = tbl_niveau.id
    order by tbl_identiteNageur2.nom ;

BEGIN
	
	SET NOCOUNT ON;

END
GO

exec selection2Tables