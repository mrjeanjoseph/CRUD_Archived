SELECT CONCAT('Hello ', 'World');

SELECT CONCAT('Foo',CAST(42 AS VARCHAR(5)), 'Bar');

SELECT LEN('Hello SQL');
SELECT DATALENGTH('Hello SQL  ');

DECLARE @str VARCHAR(100) = 'Hello '
SELECT DATALENGTH(@str) Result

DECLARE @nstr NVARCHAR(100) = 'Hello SQL'
SELECT DATALENGTH(@Nstr)

SELECT RTRIM('                          HELLO  .')

SELECT UPPER('Hello mssql') [UPPER CASE], LOWER('Hello MSSQL') [lower case];

--String Split
SELECT VALUE FROM STRING_SPLIT('Lorem Ipsum Dolor Sit Amet.',' ');

SELECT REPLACE('Lorem Ipsum Dolor Sit Amet', 'Dolor','Billy');

--Implementation
DECLARE @newWrds VARCHAR(10) = 'Maximus',
		@myStr NVARCHAR(100) = 'Lorem Ipsum Dolor Sit Amet';

DECLARE @replaceStr VARCHAR(100) =  REPLACE (@myStr, 'Dolor',@newWrds);
SELECT VALUE FROM STRING_SPLIT(@replaceStr,' ');