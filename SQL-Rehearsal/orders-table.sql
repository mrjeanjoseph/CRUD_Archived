CREATE TABLE Departments (
	DeptID INT NOT NULL IDENTITY(10,1) PRIMARY KEY,
	DeptName VARCHAR(25) NOT NULL
);

INSERT INTO Departments ([DeptName])
VALUES 
		('HR'),
		('Tech'),
		('Sales'),
		('Marketing');

SELECT * FROM Departments;
DROP TABLE Departments;

--Creating employee table
CREATE TABLE Employees(
	EmpID INT NOT NULL IDENTITY(500,3),
	EmpFirstName VARCHAR(35) NOT NULL,
	EmpLastName VARCHAR(35) NOT NULL,
	PhoneNumber VARCHAR(11),
	ManagerID INT,
	DepartmentID INT NOT NULL,
	Salary INT NOT NULL,
	HireDate DATETIME NOT NULL,
	PRIMARY KEY (EmpID),
	FOREIGN KEY (ManagerID) REFERENCES Employees(EmpID),
	CONSTRAINT FK_EmpDept FOREIGN KEY (DepartmentID) REFERENCES Departments(DeptID)
);

INSERT INTO Employees ([EmpFirstName],[EmpLastName],[PhoneNumber],[ManagerID],[DepartmentID],[Salary],[HireDate])
VALUES
		('Lafontan','Pierre','5092593438',81531,10,73775,'2022-07-18'), --Year, month days
		('Martine','Moise','5091183554',85231,10,128000,'2009-02-02'),
		('Junior','Duvalier','5093953038',81599,11,298000,'1965-12-27'),
		('Bertrand','Aristide','5092993038',82599,11,511358,'1998-03-29'),
		('Renee','Preval','5093480001',80001,12,115000,'2008-01-06')

ALTER TABLE Employees
ADD CONSTRAINT FK_EmpDept FOREIGN KEY (DepartmentID) REFERENCES Departments(DeptID)

DROP CONSTRAINT FK__Employees__Manag__4D94879B;

SELECT * FROM Employees;

--Creating customer's table
CREATE TABLE Customers(
	CustomerID INT NOT NULL IDENTITY(7,7),
	CustFirstName VARCHAR(35) NOT NULL,
	CustLastName VARCHAR(35) NOT NULL,
	EmailAddress VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(11),
	PrefContact VARCHAR(10) NOT NULL,
	PRIMARY KEY(CustomerID)
);

INSERT INTO Customers ([CustFirstName],[CustLastName],[EmailAddress],[PhoneNumber],[PrefContact])
VALUES
	('Jacques','Sauveur','jacques.s@ht-email.com','5093581122','Email'),
	('Evelyn','Michelle','e.michelle@ht-email.com','5094483985','Phone'),
	('Nixon','Paniague','n.paniague@ht-email.com','5091520012','Phone'),
	('Calvin','Jouthe','cjouthe@us-email.com','5098784552','Email'),
	('Rachelle','Charles','r.charles@us-email.com','5905225887','Phone')

SELECT * FROM Customers;

--Creating product table

CREATE TABLE Cars (
	CarsID INT NOT NULL IDENTITY(1205,3),
	CustomerID INT NOT NULL,
	EmployeeID INT NOT NULL,
	Model VARCHAR(50) NOT NULL,
	ProdStatus VARCHAR(25) NOT NULL,
	TotalCost INT NOT NULL,
	PRIMARY KEY(CarsID),
	FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmpID)
);

SELECT * FROM Customers;
SELECT * FROM Employees;
SELECT * FROM Cars;
INSERT INTO Cars ([CustomerID],[EmployeeID],[Model],[ProdStatus],[TotalCost])
VALUES
	(7,566,'Toyota Tundra','READY','75'),
	(35,578,'Cadillac Escalade','PENDING','112'),
	(14,569,'Tesla Cyber Trunk','PENDING','186'),
	(21,575,'Chevy Avalance','READY','69'),
	(28,572,'Nissa Armada','READY','81');