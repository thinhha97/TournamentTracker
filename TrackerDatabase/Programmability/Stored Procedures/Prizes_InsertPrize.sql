CREATE PROCEDURE [dbo].[Prizes_InsertPrize]
	@PlaceNumber  int,
	@PlaceName nvarchar(50),
	@PrizeAmount decimal(18,2),
	@PrizePercentage float
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[Prizes](PlaceNumber, PlaceName, PrizeAmount, PrizePercentage) 
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);
END
