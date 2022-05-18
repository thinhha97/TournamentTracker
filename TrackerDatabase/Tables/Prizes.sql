CREATE TABLE [dbo].[Prizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [PlaceNumber] INT NOT NULL, 
    [PlaceName] NVARCHAR(50) NOT NULL, 
    [PriceAmount] DECIMAL(18, 2) NOT NULL DEFAULT 0, 
    [PricePercentage] FLOAT NOT NULL DEFAULT 0, 
    [CreateAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE()
)

GO

CREATE TRIGGER [dbo].[Trigger_Prizes_Updated]
    ON [dbo].[Prizes]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[Prizes]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id in (SELECT DISTINCT Id FROM inserted);
    END