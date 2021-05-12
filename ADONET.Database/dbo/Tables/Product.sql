CREATE TABLE [dbo].[Product] (
    [id]         INT        primary key    IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (20)   NULL,
    [Date]       DATETIME       NULL,
    [URL]        VARCHAR (30)   NULL,
    [Price]      DECIMAL (5, 2) NULL,
    [RetireDate] DATETIME       NULL
);

