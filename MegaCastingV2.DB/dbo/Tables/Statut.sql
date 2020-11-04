CREATE TABLE [dbo].[Statut] (
    [ID_Statut]       INT        IDENTITY (1, 1) NOT NULL,
    [Libellée_Statut] NCHAR (50) NOT NULL,
    CONSTRAINT [PK_Statut] PRIMARY KEY CLUSTERED ([ID_Statut] ASC)
);





