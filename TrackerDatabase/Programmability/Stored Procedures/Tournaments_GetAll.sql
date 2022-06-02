CREATE PROCEDURE [dbo].[Tournaments_GetAll]

AS
BEGIN
	SET NoCOUNT ON;
	SELECT * FROM [dbo].[Tournaments]
	WHERE Active = 1;
END