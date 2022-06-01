CREATE PROCEDURE [dbo].[Prizes_InsertPrize]
	@PlaceNumber  int,
	@PlaceName nvarchar(50),
	@PrizeAmount decimal(18,2),
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[Prizes](PlaceNumber, PlaceName, PrizeAmount, PrizePercentage) 
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @id = SCOPE_IDENTITY();
END
