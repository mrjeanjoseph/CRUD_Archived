SELECT NAME +'('+LEFT(OCCUPATION,1)+')' FROM OCCUPATIONS ORDER BY name ASC;

SELECT 'There are a total of '+rtrim(CAST(COUNT(occupation) AS CHAR))+' '+LOWER(Occupation)+'s.' FROM OCCUPATIONS GROUP BY OCCUPATION ORDER BY COUNT(name) ASC, occupation ASC;

--https://www.hackerrank.com/challenges/the-pads/problem?isFullScreen=true