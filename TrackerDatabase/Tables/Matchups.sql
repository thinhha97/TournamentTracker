CREATE TABLE [dbo].[Matchups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [TournamentId] INT NOT NULL,
    [WinnerId] INT NULL, 
    [MatchupRound] INT NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_Matchups_Teams] FOREIGN KEY ([WinnerId]) REFERENCES [Teams]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_Matchups_Tournament] FOREIGN KEY ([TournamentId]) REFERENCES [Tournaments]([Id])
)

GO

CREATE TRIGGER [dbo].[Trigger_Matchups_Updated]
    ON [dbo].[Matchups]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[Matchups]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id FROM inserted);
    END