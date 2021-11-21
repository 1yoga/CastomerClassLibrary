
CREATE PROCEDURE Address_Create
	@CustomerID INT,
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
	INSERT INTO Addresses(CustomerID, AddressLine, AddressLine2, AddressType, City, PostalCode, State, Country)
	VALUES (@CustomerID, @AddressLine, @AddressLine2, @AddressType, @City, @PostalCode, @State, @Country)
END