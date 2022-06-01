CREATE PROCEDURE [dbo].[Teams_InsertTeam]
	@TeamName nvarchar(100),
	@id int = 0 output
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].Teams(TeamName)
	VALUES (@TeamName);

	SELECT @id = SCOPE_IDENTITY();
END
