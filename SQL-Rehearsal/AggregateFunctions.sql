USE [AdventureWorks2019]
GO

SELECT 
	SUM(VacationHours) [Total Vacation Hrs],
	COUNT(VacationHours) [Total Vacation Count]
FROM HumanResources.Employee

SELECT VacationHours
FROM HumanResources.Employee

--Counting rows
SELECT COUNT(*) [Total Rows]
FROM HumanResources.Employee