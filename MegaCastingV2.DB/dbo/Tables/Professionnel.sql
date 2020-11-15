CREATE TABLE [dbo].[Professionnel] (
    [ID_PRO]     INT            IDENTITY (1, 1) NOT NULL,
    [Prenom_PRO] NVARCHAR (50)  NOT NULL,
    [Nom_PRO]    NVARCHAR (50)  NOT NULL,
    [Mail_PRO]   NVARCHAR (50)  NOT NULL,
    [Pass_PRO]   NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Professionnel] PRIMARY KEY CLUSTERED ([ID_PRO] ASC)
);







