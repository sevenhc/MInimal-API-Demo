CREATE PROCEDURE [dbo].[GetAllUsers]
AS
BEGIN
	SELECT ID, FirstName, LastName
	FROM Users;
END
