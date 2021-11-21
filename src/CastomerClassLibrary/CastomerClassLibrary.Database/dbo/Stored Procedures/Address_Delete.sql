
CREATE PROCEDURE Address_Delete
	@AddressId INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Addresses
	WHERE AddressId = @AddressId
END