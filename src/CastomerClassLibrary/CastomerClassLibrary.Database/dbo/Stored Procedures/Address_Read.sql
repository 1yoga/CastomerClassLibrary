
CREATE PROCEDURE Address_Read
	@AddressesID INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Addresses
	WHERE AddressID = @AddressesID
END