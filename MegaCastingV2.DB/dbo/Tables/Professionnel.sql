CREATE TABLE [dbo].[Professionnel] (
    [ID_PRO]     INT         IDENTITY (1, 1) NOT NULL,
    [Prenom_PRO] NCHAR (50)  NOT NULL,
    [Nom_PRO]    NCHAR (50)  NOT NULL,
    [Mail_PRO]   NCHAR (50)  NOT NULL,
    [Pass_PRO]   NCHAR (255) NOT NULL,
    CONSTRAINT [PK_Professionnel] PRIMARY KEY CLUSTERED ([ID_PRO] ASC)
);





