
SELECT SYSDATETIME() as [SYSDATETIME]
SELECT SYSDATETIMEOffset() as [SYSDATETIMEOffset]
SELECT GETUTCDATE() as [GETUTCDATE]
SELECT GETDATE() as [GETDATE]

--This will print current date
DECLARE @GetCurrentDate DATETIME
SET @GetCurrentDate=GETDATE()
PRINT @GetCurrentDate

--Formatting Date/Time
DECLARE @CurrentDate DATETIME
SET @CurrentDate=GETDATE()
SELECT CONVERT(VARCHAR, @CurrentDate, 111)
AS[Date/Time]

--Adding dates to Cars table
ALTER TABLE cars
ADD ShippingDate DATE NOT NULL DEFAULT GetDate(),
	DeliveryDate DATE NULL

SELECT * FROM Cars;

ALTER TABLE cars
DROP COLUMN SalesDate;
