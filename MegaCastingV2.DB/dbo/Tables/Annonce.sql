CREATE TABLE [dbo].[Annonce] (
    [ID_ANN]        INT            IDENTITY (1, 1) NOT NULL,
    [Intitulée_ANN] NVARCHAR (125) NOT NULL,
    [Date_Pub_ANN]  DATE           NOT NULL,
    [Date_Deb_ANN]  DATE           NOT NULL,
    [Date_Fin_ANN]  DATE           NULL,
    [IdContrat]     INT            NOT NULL,
    [IdPro]         INT            NOT NULL,
    [IdEmp]         INT            NOT NULL,
    [IdVille]       INT            NOT NULL,
    [IdMetier]      INT            NOT NULL,
    CONSTRAINT [PK_Annonce] PRIMARY KEY CLUSTERED ([ID_ANN] ASC),
    CONSTRAINT [FK_Annonce_Contrat] FOREIGN KEY ([IdContrat]) REFERENCES [dbo].[Contrat] ([ID_Contrat]),
    CONSTRAINT [FK_Annonce_Employe] FOREIGN KEY ([IdEmp]) REFERENCES [dbo].[Employe] ([ID_EMP]),
    CONSTRAINT [FK_Annonce_Metier] FOREIGN KEY ([IdMetier]) REFERENCES [dbo].[Metier] ([ID_Metier]),
    CONSTRAINT [FK_Annonce_Professionnel] FOREIGN KEY ([IdPro]) REFERENCES [dbo].[Professionnel] ([ID_PRO]),
    CONSTRAINT [FK_Annonce_Ville] FOREIGN KEY ([IdVille]) REFERENCES [dbo].[Ville] ([ID_Ville])
);









