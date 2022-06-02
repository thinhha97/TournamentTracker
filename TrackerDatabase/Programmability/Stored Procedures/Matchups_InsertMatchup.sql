CREATE PROCEDURE [dbo].[Matchups_InsertMatchup]
	@TournamentId INT,
	@MatchupRound INT,
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[Matchups]( TournamentId, MatchupRound)
	VALUES (@TournamentId, @MatchupRound);

	SELECT @id = SCOPE_IDENTITY();
END
