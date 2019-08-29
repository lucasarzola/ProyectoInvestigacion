IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Parkins] (
    [Id] int NOT NULL IDENTITY,
    [HoraInicio] datetime2 NOT NULL,
    [HoraFin] datetime2 NOT NULL,
    CONSTRAINT [PK_Parkins] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Plazas] (
    [Id] int NOT NULL IDENTITY,
    [Posicion] nvarchar(max) NULL,
    [Estado] bit NOT NULL,
    [Tipo] int NOT NULL,
    CONSTRAINT [PK_Plazas] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NULL,
    [Apyn] nvarchar(max) NULL,
    [Pass] nvarchar(max) NULL,
    [Tipo] int NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190812213714_initial', N'2.1.11-servicing-32099');

GO

