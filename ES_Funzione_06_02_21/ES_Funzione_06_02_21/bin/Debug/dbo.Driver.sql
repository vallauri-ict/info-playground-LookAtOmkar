CREATE TABLE [dbo].[Driver] (
    [number]         INT           NOT NULL,
    [full_name]      VARCHAR (100) NULL,
    [country]        CHAR (2)      NOT NULL,
    [date_birth]     DATE          NULL,
    [team_id]        INT           NULL,
    [podiums_number] INT           NULL,
    [helmet_image]   VARCHAR (100)   NULL,
    [full_image]     VARCHAR (100)   NULL,
    PRIMARY KEY CLUSTERED ([number] ASC)
);

