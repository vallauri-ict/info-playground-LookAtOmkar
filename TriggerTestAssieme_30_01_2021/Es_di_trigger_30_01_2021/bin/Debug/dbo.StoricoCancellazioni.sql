CREATE TABLE [dbo].[StoricoAggiornamenti] (
    [id]                INT           IDENTITY (1, 1) NOT NULL,
	[idStoricoAggiornamenti] INT NULL,
	[NomeCampo] VARCHAR(100) NULL,
	[ValoreCampoOld] VARCHAR(100) NULL,
	[ValoreCampoNew] VARCHAR(100) NULL
    PRIMARY KEY CLUSTERED ([id] ASC)
);

