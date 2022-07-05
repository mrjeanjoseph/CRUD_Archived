--DML the adventureWorks209 schema
/*SELECT * FROM person.[Address];
SELECT * FROM person.AddressType;
SELECT * FROM person.CountryRegion;
SELECT * FROM person.BusinessEntity;
SELECT * FROM person.BusinessEntityAddress;
SELECT DISTINCT(ct.[Name]) FROM person.ContactType ct;*/

SELECT pp.PersonType, pp.LastName FROM person.Person pp;
SELECT * FROM person.PersonPhone pp;
SELECT * FROM person.Person pp;

SELECT pp.PersonType, pp.LastName, COUNT(*)
FROM person.Person pp
GROUP BY pp.LastName
HAVING COUNT(*) > 1


SELECT ppp.PhoneNumberTypeID, COUNT(*) 
FROM Person.PersonPhone ppp
GROUP BY ppp.PhoneNumberTypeID