
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


SELECT DATENAME (YEAR, GETDATE()) AS [Year],
	DATENAME (QUARTER, GETDATE()) AS [Quarter],
	DATENAME (MONTH, GETDATE()) AS [Month],
	DATENAME (DayOfYear, GETDATE()) AS [DayOfYear],
	DATENAME (DAY, GETDATE()) AS [Day],
	DATENAME (WEEK, GETDATE()) AS [Week],
	DATENAME (WEEKDAY, GETDATE()) AS [Weekday],
	DATENAME (HOUR, GETDATE()) AS [Hour],
	DATENAME (MINUTE, GETDATE()) AS [Minute],
	DATENAME (SECOND, GETDATE()) AS [Second],
	DATENAME (MILLISECOND, GETDATE()) AS [Millisecond],
	DATENAME (MICROSECOND, GETDATE()) AS [Microsecond],
	DATENAME (NANOSECOND, GETDATE()) AS [NanoSecond],
	DATENAME (ISO_WEEK, GETDATE()) AS [ISO Week]

--DATEPART can be used instead of DATENAME