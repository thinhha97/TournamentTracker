CREATE PROCEDURE [dbo].[GetTeamsByTournamentId]
	@TournamentId INT
AS
BEGIN 
	SET NoCOUNT ON;
	SELECT t.*
	FROM [dbo].[Teams] t 
	INNER JOIN [dbo].[TournamentEntries] te
	ON t.Id = te.Id
	WHERE te.TournamentId = @TournamentId;
END
