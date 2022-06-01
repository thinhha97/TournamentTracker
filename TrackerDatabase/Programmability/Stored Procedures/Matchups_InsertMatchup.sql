CREATE PROCEDURE [dbo].[Matchups_InsertMatchup]
	@TournamentId INT,
	@WinnerId INT,
	@MatchupRound INT,
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[Matchups]( TournamentId, WinnerId, MatchupRound)
	VALUES (@TournamentId, @WinnerId, @MatchupRound);

	SELECT @id = SCOPE_IDENTITY();
END
