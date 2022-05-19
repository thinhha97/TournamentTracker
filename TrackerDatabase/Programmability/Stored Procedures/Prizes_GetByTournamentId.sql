CREATE PROCEDURE [dbo].[Prizes_GetByTournamentId]
	@TournamentId int
AS
BEGIN
	SET NoCOUNT ON;
	SELECT p.*
	FROM [dbo].[Prizes] p
	INNER JOIN [dbo].[TournamentPrizes] t ON p.Id = t.PrizeId
	WHERE t.TournamentId = @TournamentId;
END
