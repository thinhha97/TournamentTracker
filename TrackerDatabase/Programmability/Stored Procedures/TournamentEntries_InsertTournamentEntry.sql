CREATE PROCEDURE [dbo].[TournamentEntries_InsertTournamentEntry]
	@TournamentId INT,
	@TeamId INT,
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[TournamentEntries](TournamentId, TeamId)
	VALUES (@TournamentId, @TeamId);

	SELECT @id = SCOPE_IDENTITY();
END
