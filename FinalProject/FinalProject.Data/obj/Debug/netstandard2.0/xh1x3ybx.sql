﻿IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
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
    [ExecutionTime] float NOT NULL,
    [ExecutionDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Operations] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200325044052_init', N'2.1.0-rtm-30799');

GO

