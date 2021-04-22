CREATE TABLE [dbo].[Annonce] (
    [Id]               INT            IDENTITY (1, 1) NOT NULL,
    [Nom]              NVARCHAR (125) NOT NULL,
    [Date_Publication] DATE           NOT NULL,
    [Date_Debut]       DATE           NOT NULL,
    [Date_Fin]         DATE           NULL,
    [Description]      NVARCHAR (150) NULL,
    [IdContrat]        INT            NOT NULL,
    [IdPro]            INT            NOT NULL,
    [IdEmp]            INT            NOT NULL,
    [IdVille]          INT            NOT NULL,
    [IdMetier]         INT            NOT NULL,
    CONSTRAINT [PK_Annonce] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Annonce_Contrat] FOREIGN KEY ([IdContrat]) REFERENCES [dbo].[Contrat] ([Id]),
    CONSTRAINT [FK_Annonce_Employe] FOREIGN KEY ([IdEmp]) REFERENCES [dbo].[Employe] ([Id]),
    CONSTRAINT [FK_Annonce_Metier] FOREIGN KEY ([IdMetier]) REFERENCES [dbo].[Metier] ([Id]),
    CONSTRAINT [FK_Annonce_Professionnel] FOREIGN KEY ([IdPro]) REFERENCES [dbo].[Professionnel] ([Id]),
    CONSTRAINT [FK_Annonce_Ville] FOREIGN KEY ([IdVille]) REFERENCES [dbo].[Ville] ([Id])
);











