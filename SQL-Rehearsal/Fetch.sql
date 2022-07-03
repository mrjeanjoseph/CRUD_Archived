SELECT * 
FROM sales.customers;

--Selecting a specified number of records
--Using FETCH to fetch recodes
SELECT 
	customer_id AS [Customer ID], 
	first_name + last_name AS [Full Name], 
	zip_code AS [Zip Code]
FROM 
	sales.customers
ORDER BY 
	[Zip Code]
	OFFSET 0 ROWS
FETCH NEXT 10 ROWS ONLY


SELECT TOP 10 customer_id
FROM sales.customers