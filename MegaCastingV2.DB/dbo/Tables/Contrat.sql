CREATE TABLE [dbo].[Contrat] (
    [ID_Contrat]      INT        IDENTITY (1, 1) NOT NULL,
    [Libelle_Contrat] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_Contrat] PRIMARY KEY CLUSTERED ([ID_Contrat] ASC)
);



