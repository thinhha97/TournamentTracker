CREATE PROCEDURE [dbo].[GetMatchupsByTournamentId]
	@TournamentId INT
AS
BEGIN
	SET NoCOUNT ON;
	SELECT *
	FROM [dbo].[Matchups]
	WHERE TournamentId = @TournamentId;
END
