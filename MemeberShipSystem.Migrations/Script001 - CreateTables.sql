﻿CREATE TABLE Employees (
	EmployeeId VARCHAR(4) NOT NULL CONSTRAINT PK_Employees PRIMARY KEY,
	FirstName NVARCHAR(200) NOT NULL,
	MiddleName NVARCHAR(200) NULL,
    LastName NVARCHAR(200) NOT NULL,
    Role NVARCHAR(200) NOT NULL,
	StartDate DATETIME NOT NULL,
    Grade NVARCHAR(200) NOT NULL,
	Email NVARCHAR(200) NOT NULL,
	Mobile NVARCHAR(200) NOT NULL,
)
GO

CREATE TABLE CardUsers (
	CardId VARCHAR(16) NOT NULL CONSTRAINT PK_CardUsers PRIMARY KEY,
	EmployeeId VARCHAR(4) NOT NULL CONSTRAINT FK_CardUsers FOREIGN KEY (EmployeeId) REFERENCES Employees (EmployeeId),
	Name NVARCHAR(200) NOT NULL,
	Email NVARCHAR(200) NOT NULL,
	Mobile NVARCHAR(200) NOT NULL,
)
GO

