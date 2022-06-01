CREATE PROCEDURE [dbo].[GetTeamMembersByTeamId]
	@TeamId int
AS
BEGIN
	SET NoCOUNT ON;
	SELECT p.Id, p.FirstName, p.LastName, p.EmailAddress, p.PhoneNumber
	FROM [dbo].[TeamMembers] tm
	INNER JOIN [dbo].[People] p
	ON tm.PersonId = p.Id
	WHERE tm.TeamId = @TeamId;
END
