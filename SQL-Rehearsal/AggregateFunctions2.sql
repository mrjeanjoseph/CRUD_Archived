--Function Scalar/Single Row
USE [AdventureWorks2019]
GO

--Date and Time
SELECT DATENAME (Weekday, '07/09/2022') AS [Date Name]

SELECT GETDATE() AS [System Date]

SELECT NationalIDNumber, BirthDate, ModifiedDate FROM HumanResources.Employee

--Date computation
SELECT NationalIDNumber, DATEDIFF(DAY, BirthDate, ModifiedDate) [Processing Time]
FROM HumanResources.Employee;

SELECT NationalIDNumber, DATEDIFF(MONTH, BirthDate, ModifiedDate)
FROM HumanResources.Employee;

SELECT NationalIDNumber, DATEDIFF(MONTH, BirthDate, ModifiedDate)
FROM HumanResources.Employee;

SELECT NationalIDNumber, DATEDIFF(YEAR, BirthDate, ModifiedDate)
FROM HumanResources.Employee;

--
SELECT DATEADD (DAY, 50, '2022-07-09') [Add 20 Days]

--Character Modifications
SELECT *
FROM HumanResources.EmployeePayHistory