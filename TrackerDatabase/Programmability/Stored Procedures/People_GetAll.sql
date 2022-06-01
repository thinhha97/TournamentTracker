CREATE PROCEDURE [dbo].[People_GetAll]
AS
BEGIN
	SET NoCOUNT ON;
	SELECT * FROM [dbo].[People];
END
