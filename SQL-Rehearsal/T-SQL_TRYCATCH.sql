--TRY/CATCH

BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Cars(CustomerID, EmployeeID, Model, ProdStatus, TotalCost)
		VALUES(35, 566, 'Tesla 90x', 'PENDING', 215)
	INSERT INTO dbo.Cars(CustomerID, EmployeeID, Model, ProdStatus, TotalCost)
		VALUES(35, 566, 'Not a make and model', 'PENDING', 215)
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	THROW
	ROLLBACK TRANSACTION
END CATCH

SELECT * FROM dbo.Cars

BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Cars(CustomerID, EmployeeID, Model, ProdStatus, TotalCost)
		VALUES(35, 566, 'LEXUS 388E', 'PENDING', 63)
	INSERT INTO dbo.Cars(CustomerID, EmployeeID, Model, ProdStatus, TotalCost)
		VALUES(35, 566, 'Toyota Sequoia', 'READY', 76)
	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	THROW
	ROLLBACK TRANSACTION
END CATCH