CREATE PROCEDURE [dbo].[MatchupEntries_InsertMatchupEntry]
	@MatchupId INT,
	@ParentMatchupId INT,
	@TeamCompetingId INT,
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[MatchupEntries](MatchupId, ParentMatchupId, TeamCompetingId)
	VALUES (@MatchupId, @ParentMatchupId, @TeamCompetingId);

	SELECT @id = SCOPE_IDENTITY();
END
