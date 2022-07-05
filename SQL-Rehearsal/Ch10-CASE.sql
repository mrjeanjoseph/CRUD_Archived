--Chapter 10: CASE
SELECT * FROM Sales.Store;
SELECT * FROM Sales.SpecialOffer;
SELECT * FROM Sales.SpecialOfferProduct;

--SUM and COUNT
SELECT
	COUNT(MinQty) AS ItemCount,
	SUM(CASE 
			WHEN Category = 'Reseller' THEN 1
			ELSE 0
		END) AS [Expensive Items]
FROM Sales.SpecialOffer;

--Searched CASE in SELECT
SELECT SpecialOfferID id, [Description], DiscountPct,	
	CASE
		WHEN minQty < 5 THEN 'CHEAP'
		WHEN minQty > 5 AND minQty < 25 THEN 'AFFORDABLE'
		ELSE 'EXPENSIVE'
	END AS Pricings
FROM Sales.SpecialOffer;

--Case in a clause ORDER BY
SELECT * 
FROM Sales.SpecialOffer
ORDER BY
	CASE Category
		WHEN 'Reseller' THEN 1
		WHEN 'Customer' THEN 2
		WHEN 'No Discount' THEN 3
		ELSE 4
	END, [Description];

--Shorthand CASE in SELECT
SELECT * FROM Sales.SpecialOffer;

SELECT SpecialOfferID, [Description], MinQty, DiscountPct,
	CASE MinQty WHEN 0 THEN 'Cheap'
				WHEN 11 THEN 'AFF'
				ELSE 'EXP'
	END AS [PriceFixing]
FROM Sales.SpecialOffer;

--Shorthand CASE in UPDATE
SELECT * FROM Sales.SalesTaxRate
select ROUND(RAND(), 2)
select ROUND(RAND(), 2)

UPDATE Sales.SalesTaxRate
SET TaxRate = 
	CASE TaxType
		WHEN 1 THEN 7.98
		WHEN 2 THEN 7.21
		WHEN 3 THEN 8.13
		ELSE 1.00
	END

--CASE use for NULL values
SELECT * FROM Sales.SalesPerson;

SELECT BusinessEntityID, TerritoryID, SalesQuota, Bonus
FROM Sales.SalesPerson
ORDER BY
	CASE WHEN SalesQuota IS NULL THEN 1
		ELSE 0
	END, Bonus;

--CASE in ORDER BY clause to sort
SELECT * FROM Sales.SalesReason;
SELECT * FROM Sales.SalesPersonQuotaHistory;

SELECT BusinessEntityID, QuotaDate, ModifiedDate
FROM Sales.SalesPersonQuotaHistory
ORDER BY CASE
			WHEN COALESCE(QuotaDate, '1950-01-01') = COALESCE(ModifiedDate, '1950-01-01') THEN QuotaDate
			ELSE ModifiedDate
		END;
