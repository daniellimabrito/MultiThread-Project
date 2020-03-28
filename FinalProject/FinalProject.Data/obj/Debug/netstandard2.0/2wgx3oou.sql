IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Operations] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [ExecutionTime] time NOT NULL,
    [ExecutionDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Operations] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200327073830_init', N'2.1.4-rtm-31024');

GO

