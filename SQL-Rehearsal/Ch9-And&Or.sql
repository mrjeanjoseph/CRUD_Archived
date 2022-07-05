SELECT * FROM Sales.Store

--AND & OR Operators
SELECT BusinessEntityID 
FROM Sales.Store
WHERE [Name] = 'Great Bikes' AND SalesPersonID = 283

SELECT BusinessEntityID 
FROM Sales.Store
WHERE [Name] = 'Great Bikes' OR SalesPersonID = 281