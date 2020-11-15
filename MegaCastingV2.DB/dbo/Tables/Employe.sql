CREATE TABLE [dbo].[Employe] (
    [ID_EMP]     INT            IDENTITY (1, 1) NOT NULL,
    [Prenom_EMP] NVARCHAR (50)  NOT NULL,
    [Nom_EMP]    NVARCHAR (50)  NOT NULL,
    [Mail_EMP]   NVARCHAR (50)  NOT NULL,
    [Pass_EMP]   NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED ([ID_EMP] ASC)
);







