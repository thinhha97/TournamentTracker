CREATE PROCEDURE [dbo].[Tournaments_InsertTournament]
	@TournamentName NVARCHAR(200),
	@EntryFee DECIMAL(18,2),
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[Tournaments](TournamentName, EntryFee)
	VALUES (@TournamentName, @EntryFee);

	SELECT @id = SCOPE_IDENTITY();
END
