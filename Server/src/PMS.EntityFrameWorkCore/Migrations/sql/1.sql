IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Client] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Adress] nvarchar(max) NULL,
    [Tel] nvarchar(max) NULL,
    [Status] bit NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Client_Id] ON [Client] ([Id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210320022329_0', N'3.1.5');

GO

