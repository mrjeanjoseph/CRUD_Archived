--CH11: LIKE Operator

SELECT * FROM dbo.AWBuildVersion;
SELECT * FROM dbo.DatabaseLog;
SELECT * FROM dbo.ErrorLog;
SELECT * FROM HumanResources.Department;
SELECT * FROM HumanResources.Employee;

--Match open-ended pattern
SELECT JobTitle, MaritalStatus, Gender
FROM HumanResources.Employee
WHERE JobTitle LIKE '%er%'; --If there's an er within the string, this will find it.

SELECT JobTitle, NationalIDNumber, MaritalStatus, Gender
FROM HumanResources.Employee
WHERE NationalIDNumber LIKE '84%'; --If it starts with 84, this will find it.

SELECT JobTitle, NationalIDNumber, MaritalStatus, Gender
FROM HumanResources.Employee
WHERE NationalIDNumber LIKE '%174'; --If it ends with 174, this will find it.

SELECT JobTitle, NationalIDNumber, MaritalStatus, Gender
FROM HumanResources.Employee
WHERE NationalIDNumber LIKE '__c%'; --If char exit in 3rd index, this will find it.

--Single Character match