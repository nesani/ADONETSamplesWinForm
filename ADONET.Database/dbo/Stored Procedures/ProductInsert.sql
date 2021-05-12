CREATE PROCEDURE [dbo].[ProductInsert]
@ProductName nvarchar(250),
@IntroductionDate datetime,
@URL nvarchar (250),
@Price decimal(19,2),
@ProductId int OUTPUT

AS

INSERT INTO dbo.Product (Name, Date, URL, Price)
Values(@ProductName, @IntroductionDate, @URL, @Price)

SELECT @ProductId = SCOPE_IDENTITY();