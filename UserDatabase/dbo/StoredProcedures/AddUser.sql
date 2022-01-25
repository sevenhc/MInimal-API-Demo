CREATE PROCEDURE [dbo].[AddUser]
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	INSERT INTO Users(FirstName, LastName)
	VALUES(@FirstName, @LastName)
END