SELECT *
FROM production.BillOfMaterials;

SELECT * FROM production.ProductCostHistory;

SELECT productID, COUNT(*) [Standard Cost] FROM production.ProductCostHistory
GROUP BY ProductID
ORDER BY [Standard Cost] DESC

SELECT bp.BillOfMaterialsID,bp.ComponentID
FROM Production.BillOfMaterials bp
GROUP BY bp.ComponentID, bp.BillOfMaterialsID

SELECT ppv.ProductID, ppv.OnOrderQty FROM Purchasing.ProductVendor ppv ORDER BY 2;

--Use ORDER BY with TOP
SELECT * FROM Purchasing.PurchaseOrderHeader
SELECT TOP 5 PurchaseOrderID, VendorID FROM Purchasing.PurchaseOrderHeader
SELECT TOP 5 PurchaseOrderID, VendorID 
FROM Purchasing.PurchaseOrderHeader
ORDER BY VendorID DESC

--Customize sorting order
SELECT * FROM Sales.Store;
SELECT * FROM Sales.SpecialOfferProduct;
SELECT * 
FROM Sales.CountryRegionCurrency 
ORDER BY CASE CurrencyCode
			WHEN 'MUR' THEN 1
			WHEN 'BND' THEN 2
			ELSE 3
			END;

SELECT CountryRegionCode 
FROM Sales.CountryRegionCurrency 
WHERE CurrencyCode LIKE 'H%'

