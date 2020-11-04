CREATE TABLE [dbo].[Employe] (
    [ID_EMP]     INT         IDENTITY (1, 1) NOT NULL,
    [Prenom_EMP] NCHAR (50)  NOT NULL,
    [Nom_EMP]    NCHAR (50)  NOT NULL,
    [Mail_EMP]   NCHAR (50)  NOT NULL,
    [Pass_EMP]   NCHAR (255) NOT NULL,
    CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED ([ID_EMP] ASC)
);





