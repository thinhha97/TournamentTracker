CREATE TABLE [dbo].[TeamMembers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1000, 1), 
    [TeamId] INT NOT NULL, 
    [PersonId] INT NOT NULL, 
    [CreatedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    [ModifiedAt] DATETIME2 NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_TeamMembers_Teams] FOREIGN KEY ([TeamId]) REFERENCES [Teams]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_TeamMembers_People] FOREIGN KEY ([PersonId]) REFERENCES [People]([Id]) ON DELETE CASCADE
)

GO

CREATE TRIGGER [dbo].[Trigger_TeamMembers_Updated]
    ON [dbo].[TeamMembers]
    FOR UPDATE
    AS
    BEGIN
        SET NoCount ON;
        UPDATE [dbo].[TeamMembers]
        SET [ModifiedAt] = GETUTCDATE()
        WHERE Id IN (SELECT DISTINCT Id from inserted);
    END