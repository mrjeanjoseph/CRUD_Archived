SELECT Employees.*,Departments.DeptName 'Dept Name'
FROM Employees
JOIN Departments
ON Departments.DeptID = Employees.DepartmentID;
--Pick up from here!


SELECT 
	Customers.CustFirstName+' '+Customers.CustLastName AS 'Customer Name',
	Cars.CarsID AS 'Customer ID',
	Customers.PhoneNumber,
	Customers.EmailAddress
	
FROM 
	Customers
LEFT JOIN
	Cars ON Cars.CustomerID = Customers.CustomerID

--Using short Aliases
SELECT 
	c.CustFirstName+' '+c.CustLastName AS [Customer Name],
	v.CarsID AS 'Customer ID',
	c.PhoneNumber,
	c.EmailAddress
FROM Customers c
LEFT JOIN 
	Cars as v ON v.CustomerID = c.CustomerID
ORDER BY [Customer Name]


SELECT CarsID, Model, TotalCost
FROM Cars
ORDER BY TotalCost DESC
OFFSET 0 ROWS
FETCH FIRST 6 ROWS ONLY