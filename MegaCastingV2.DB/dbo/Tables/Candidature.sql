CREATE TABLE [dbo].[Candidature] (
    [ID_CAND]          INT            IDENTITY (1, 1) NOT NULL,
    [Objet_CAND]       NVARCHAR (255) NOT NULL,
    [Date_Pub_CAND]    NVARCHAR (255) NOT NULL,
    [Description_CAND] NVARCHAR (255) NOT NULL,
    [IdAnnonce]        INT            NOT NULL,
    [IdArtiste]        INT            NOT NULL,
    [IdStatut]         INT            NOT NULL,
    CONSTRAINT [PK_Candidature] PRIMARY KEY CLUSTERED ([ID_CAND] ASC),
    CONSTRAINT [FK_Candidature_Annonce] FOREIGN KEY ([IdAnnonce]) REFERENCES [dbo].[Annonce] ([ID_ANN]),
    CONSTRAINT [FK_Candidature_Artiste] FOREIGN KEY ([IdArtiste]) REFERENCES [dbo].[Artiste] ([ID_ART]),
    CONSTRAINT [FK_Candidature_Statut] FOREIGN KEY ([IdStatut]) REFERENCES [dbo].[Statut] ([ID_Statut])
);











