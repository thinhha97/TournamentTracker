CREATE PROCEDURE [dbo].[TeamMembers_InsertTeamMember]
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[TeamMembers](TeamId, PersonId)
	VALUES (@TeamId, @PersonId);

	SELECT @id = SCOPE_IDENTITY();
END
