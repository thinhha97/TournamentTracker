CREATE PROCEDURE [dbo].[GetMatchupEntriesByMatchupId]
	@MatchupId INT
AS
BEGIN
	SET NoCOUNT ON;
	SELECT * FROM [dbo].[MatchupEntries]
	WHERE MatchupId = @MatchupId;
END
