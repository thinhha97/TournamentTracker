CREATE TABLE [dbo].[TournamentEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [TournamentId] INT NOT NULL, 
    [TeamId] INT NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_TournamentEntries_Tournaments] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_TournamentEntries_Teams] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([Id]) ON DELETE CASCADE
)

GO

CREATE TRIGGER [dbo].[Trigger_TournamentEntries_Updated]
    ON [dbo].[TournamentEntries]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[TournamentEntries]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id FROM inserted);
    END