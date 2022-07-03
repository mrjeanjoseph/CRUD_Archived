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