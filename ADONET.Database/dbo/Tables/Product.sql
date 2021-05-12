CREATE TABLE [dbo].[Product] (
    [id]         INT        Primary Key    IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (20)   NULL,
    [Date]       DATETIME       NULL,
    [URL]        VARCHAR (30)   NULL,
    [Price]      DECIMAL (5, 2) NULL,
    [RetireDate] DATETIME       NULL
);


GO

CREATE INDEX [IX_Product_Name] ON [dbo].[Product] ([Name])
