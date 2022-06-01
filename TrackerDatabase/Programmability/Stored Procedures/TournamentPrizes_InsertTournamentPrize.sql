CREATE PROCEDURE [dbo].[TournamentPrizes_InsertTournamentPrize]
	@TournamentId INT,
	@PrizeId INT,
	@id INT = 0 OUTPUT
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[TournamentPrizes](TournamentId, PrizeId)
	VALUES (@TournamentId, @PrizeId);

	SELECT @id = SCOPE_IDENTITY();
END

