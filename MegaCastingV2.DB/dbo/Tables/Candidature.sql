CREATE TABLE [dbo].[Candidature] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Objet]            NVARCHAR (255) NOT NULL,
    [Date_Publication] NVARCHAR (255) NOT NULL,
    [Description]      NVARCHAR (255) NOT NULL,
    [IdAnnonce]        INT            NOT NULL,
    [IdArtiste]        INT            NOT NULL,
    [IdStatut]         INT            NOT NULL,
    CONSTRAINT [PK_Candidature] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Candidature_Annonce] FOREIGN KEY ([IdAnnonce]) REFERENCES [dbo].[Annonce] ([Id]),
    CONSTRAINT [FK_Candidature_Artiste] FOREIGN KEY ([IdArtiste]) REFERENCES [dbo].[Artiste] ([Id]),
    CONSTRAINT [FK_Candidature_Statut] FOREIGN KEY ([IdStatut]) REFERENCES [dbo].[Statut] ([Id])
);













