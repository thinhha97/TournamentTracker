CREATE TABLE [dbo].[MatchupEntries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [MatchupId] INT NOT NULL, 
    [ParentMatchupId] INT NULL, 
    [TeamCompetingId] INT NULL, 
    [Score] FLOAT NULL DEFAULT 0, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_MatchupEntries_Matchups_MatchupId] FOREIGN KEY ([MatchupId]) REFERENCES [Matchups](Id) ON DELETE CASCADE,
    CONSTRAINT [FK_MatchupEntries_Matchups_ParentMatchupId] FOREIGN KEY ([ParentMatchupId]) REFERENCES [Matchups](Id) ON DELETE NO ACTION, 
    CONSTRAINT [FK_MatchupEntries_Teams] FOREIGN KEY ([TeamCompetingId]) REFERENCES [Teams]([Id]) ON DELETE NO ACTION
)

GO

CREATE TRIGGER [dbo].[Trigger_MatchupEntries_Updated]
    ON [dbo].[MatchupEntries]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[MatchupEntries]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id FROM inserted);
    END