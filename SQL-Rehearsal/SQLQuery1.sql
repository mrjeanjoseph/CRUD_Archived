
/*CREATE TABLE Employee(
	EmpId integer,
	FirstName varchar(20),
	lastname varchar(20),
	Email varchar(25),
	PhoneNo varchar(25),
	Salary integer
);

SELECT * INTO Employee_backup FROM Employee;

ALTER TABLE Employee
ADD middleInitial varchar(1),
	Address VARCHAR(100),
	City VARCHAR(25),
	PinCode INTEGER;


EXEC sp_rename 'Employee.PinCode', 'Employee.ZipCode';



ALTER TABLE Employee ALTER COLUMN PinCode INTEGER;
EXEC sp_rename 'Employee.PinCode', 'ZipCode';

ALTER TABLE Employee
ADD PinCode VARCHAR(30);

SELECT * FROM dbo.emp;

ALTER TABLE Employee DROP COLUMN ZipCode;

EXEC sp_rename Employee, emp;



DROP TABLE Employee_backup;

SELECT * FROM user_info;
DROP TABLE user_info;

*/

CREATE TABLE NFT_LOGIN_USERS (
    LoginID INT NOT NULL IDENTITY(1,1),
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    StreetAddress VARCHAR(255),
    EmailAddress VARCHAR(255) NOT NULL,
    PRIMARY KEY (LoginID)
);

/*INSERT INTO NFT_LOGIN_USERS (FirstName, LastName, EmailAddress, StreetAddress)
	VALUES
	('Louna', 'Jean-Joseph', 'lpjeanjoseph@crud.com','0827 ChittiChatter dr.'),
	('Veleenah', 'Jean-Joseph', 'vjeanjoseph@crud.com','1228 JojoCeeY dr.'),
	('Casteeleaux', 'Jean-Joseph', 'cjeanjoseph@crud.com','0423 ShapesNplanet dr.'),
	('Devereaux', 'Jean-Joseph', 'djeanjoseph@crud.com','0117 MinecraftNroblox dr.');

SELECT * FROM NFT_LOGIN_USERS;
*/

CREATE TABLE NFT_Orders(
       OrderID INT NOT NULL,
       UserID INT,
       ProductID int,
       PRIMARY KEY(OrderID),
       FOREIGN KEY(UserID) REFERENCES NFT_LOGIN_USERS(LoginID),
       --FOREIGN KEY(product_id) REFERENCES products(id)
);

SELECT * FROM NFT_Orders;
SELECT * FROM NFT_LOGIN_USERS;

INSERT INTO NFT_Orders
	VALUES
		(1501, 1, 2000555463),
		(1759, 1, 2000555463),
		(0975, 1, 2000555463);

DELETE FROM NFT_Orders;
SELECT * FROM NFT_LOGIN_USERS;
DELETE FROM NFT_LOGIN_USERS;


SELECT * FROM NFT_LOGIN_USERS, NFT_Orders;
SELECT NFT_LOGIN_USERS.*, NFT_Orders.* FROM NFT_LOGIN_USERS, NFT_Orders;