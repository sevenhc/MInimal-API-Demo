CREATE PROCEDURE [dbo].[UpdateUser]
	@ID INT, 
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50)
AS
BEGIN
	UPDATE Users
	SET FirstName = @FirstName,
	LastName = @LastName
	WHERE ID = @ID
END