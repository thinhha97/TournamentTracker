CREATE TABLE [dbo].[Tournaments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [TournamentName] NVARCHAR(200) NOT NULL, 
    [EntryFee] DECIMAL(18, 2) NOT NULL DEFAULT 0, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE()
)

GO

CREATE TRIGGER [dbo].[Trigger_Tournaments_Updated]
    ON [dbo].[Tournaments]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[Tournaments]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id FROM inserted);
    END