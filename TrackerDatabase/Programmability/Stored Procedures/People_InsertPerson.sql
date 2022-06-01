CREATE PROCEDURE [dbo].[People_InsertPerson]
	@FirstName nvarchar(20),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(100),
	@CellPhoneNumber varchar(10),
	@id int = 0 output
AS
BEGIN
	SET NoCOUNT ON;
	INSERT INTO [dbo].[People](FirstName, LastName, EmailAddress, PhoneNumber)
	VALUES (@FirstName, @LastName, @EmailAddress, @CellPhoneNumber);

	SELECT @id = SCOPE_IDENTITY();
END
