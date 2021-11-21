
CREATE PROCEDURE Address_Update
	@AddressId INT,
	@CustomerId INT,
	@AddressLine NVARCHAR(100),
	@AddressLine2 NVARCHAR(100),
	@AddressType NVARCHAR(8),
	@City NVARCHAR(50),
	@PostalCode NVARCHAR(6),
	@State NVARCHAR(20),
	@Country NVARCHAR(13)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Addresses
	SET CustomerID = @CustomerID, 
		AddressLine = @AddressLine, 
		AddressLine2 = @AddressLine2, 
		AddressType = @AddressType, 
		City = @City, 
		PostalCode = @PostalCode, 
		State = @State, 
		Country = @Country
	WHERE AddressId = @AddressId
END