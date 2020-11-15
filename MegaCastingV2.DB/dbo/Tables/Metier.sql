CREATE TABLE [dbo].[Metier] (
    [ID_Metier]       INT           IDENTITY (1, 1) NOT NULL,
    [Libellée_Metier] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Metier] PRIMARY KEY CLUSTERED ([ID_Metier] ASC)
);



