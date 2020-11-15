CREATE TABLE [dbo].[Artiste] (
    [ID_ART]       INT            IDENTITY (1, 1) NOT NULL,
    [Prenom_ART]   NVARCHAR (50)  NOT NULL,
    [Nom_ART]      NVARCHAR (50)  NOT NULL,
    [Date_Nai_ART] DATE           NOT NULL,
    [Mail_ART]     NVARCHAR (50)  NOT NULL,
    [Pass_ART]     NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Artiste] PRIMARY KEY CLUSTERED ([ID_ART] ASC)
);







