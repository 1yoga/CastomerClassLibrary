
CREATE PROCEDURE Customer_Delete
	@CustomerId INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Customers
	WHERE CustomerId = @CustomerId
END