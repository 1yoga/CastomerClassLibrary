
CREATE PROCEDURE Customer_Read
	@CustomerID INT
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Customers
	WHERE CustomerID = @CustomerID
END