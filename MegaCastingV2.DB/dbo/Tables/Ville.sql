CREATE TABLE [dbo].[Ville] (
    [ID_Ville]       INT           IDENTITY (1, 1) NOT NULL,
    [Libellée_VILLE] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Ville] PRIMARY KEY CLUSTERED ([ID_Ville] ASC)
);







