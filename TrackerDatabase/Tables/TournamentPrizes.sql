CREATE TABLE [dbo].[TournamentPrizes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [TournamentId] INT NOT NULL, 
    [PrizeId] INT NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_TournamentPrizes_Tournaments] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments](Id) ON DELETE CASCADE, 
    CONSTRAINT [FK_TournamentPrizes_Prizes] FOREIGN KEY ([PrizeId]) REFERENCES [Prizes]([Id]) ON DELETE CASCADE
)

GO

CREATE TRIGGER [dbo].[Trigger_TournamentPrizes_Updated]
    ON [dbo].[TournamentPrizes]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[TournamentPrizes]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id FROM inserted);
    END