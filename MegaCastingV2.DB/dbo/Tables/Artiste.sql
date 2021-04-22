CREATE TABLE [dbo].[Artiste] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Prenom]         NVARCHAR (50)  NOT NULL,
    [Nom]            NVARCHAR (50)  NOT NULL,
    [Date_Naissance] DATE           NOT NULL,
    [Mail]           NVARCHAR (50)  NOT NULL,
    [Password]       NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Artiste] PRIMARY KEY CLUSTERED ([Id] ASC)
);









