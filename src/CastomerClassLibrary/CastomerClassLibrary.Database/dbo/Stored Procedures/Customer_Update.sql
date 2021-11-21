
CREATE PROCEDURE Customer_Update
	@CustomerId INT,
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@PhoneNumber NVARCHAR(16),
	@Email NVARCHAR(50),
	@Notes NVARCHAR(MAX),
	@TotalPurchasesAmount MONEY
AS
BEGIN
	SET NOCOUNT ON;
		UPDATE Customers
		SET FirstName = @FirstName, 
			LastName = @LastName, 
			PhoneNumber = @PhoneNumber, 
			Email = @Email, 
			Notes = @Notes, 
			TotalPurchasesAmount = @TotalPurchasesAmount
		WHERE CustomerId = @CustomerId
END