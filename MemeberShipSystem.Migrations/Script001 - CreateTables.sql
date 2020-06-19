CREATE TABLE Users (
	UserId VARCHAR(200) NOT NULL CONSTRAINT PK_Users PRIMARY KEY,
	EmployeeId VARCHAR(200) NOT NULL,
	Name NVARCHAR(200) NOT NULL,
	Email NVARCHAR(200) NOT NULL,
	Mobile NVARCHAR(200) NOT NULL,
)
GO

CREATE TABLE Employees (
	EmployeeId VARCHAR(200) NOT NULL CONSTRAINT PK_Employees PRIMARY KEY,
	Name NVARCHAR(200) NOT NULL,
    Role NVARCHAR(200) NOT NULL,
	Email NVARCHAR(200) NOT NULL,
	Mobile NVARCHAR(200) NOT NULL,
)
GO

INSERT INTO Users
           (UserId
           ,EmployeeId
           ,Name
           ,Email
           ,Mobile)
     VALUES
           ('1234',
           '123222',
           'John',
            'Test email',
           '01112458')
GO
