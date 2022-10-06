USE [Rehearsals]
GO

/****** Object:  StoredProcedure [dbo].[USP_GENERATE_RANDOM_CHARACTER]    Script Date: 9/25/2022 11:12:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER PROC [EXE].[GenerateRandomChars] ( 
	@NO_OF_CHARS INT, 
	@RANDOM_CHAR VARCHAR(40) OUTPUT
) 
AS 
BEGIN
	SELECT @RANDOM_CHAR  = SUBSTRING (REPLACE(CONVERT(VARCHAR(40), NEWID()), '-',''), 1, @NO_OF_CHARS)
	END 


/* USAGE:
DECLARE @OUT VARCHAR(40) 
EXEC [EXE].[GenerateRandomChars] 13,@RANDOM_CHAR = @OUT OUTPUT 
SELECT @OUT 
Make sure to pass at least one param
*/
GO

