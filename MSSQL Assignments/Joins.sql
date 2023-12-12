CREATE TABLE UserTable
(
ID INT NOT NULL PRIMARY KEY	IDENTITY(1,1),
FirstName VARCHAR(255),
LastName VARCHAR(255),
Email VARCHAR(255),
City VARCHAR(255),
Salary INT,
Designation VARCHAR(255),
CreatedDate DATETIME,
ModifiedDate DATETIME,
IsActive BIT
)

CREATE TABLE GroupTable
(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(255),
Description VARCHAR(1024),
CreatedDate DATETIME,
ModifiedDate DATETIME,
IsActive BIT
)

CREATE TABLE UserGroup 
(
ID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
GroupID INT, FOREIGN KEY(GroupID) REFERENCES GroupTable(ID),
UserID INT, FOREIGN KEY(UserID) REFERENCES UserTable(ID),
ModifiedDate DATETIME,
IsActive BIT
)

INSERT INTO UserTable VALUES('Gokul','Sivakumar','gokulsivakumar@gmail.com','Chennai',20000,'Software Engineer','2023-12-12','2023-12-12',1);
INSERT INTO UserTable VALUES('Ajay','Kumar','ajaykumar@gmail.com','Chengalpattu',40000,'Software Engineer','2023-11-12','2023-11-22',1);
INSERT INTO UserTable VALUES('Dharun','Kadir','dharunkadir@gmail.com','Chennai',200000,'Software Engineer','2023-06-22','2023-07-10',1);
INSERT INTO UserTable VALUES('Karthik','Visnu','krs@gmail.com','Karur',20000,'Software Engineer','2023-12-12','2023-12-12',1);

INSERT INTO GroupTable VALUES('BoldBI','Analyatic Tool','2023-12-12','2023-12-12',1);
INSERT INTO GroupTable VALUES('BoldDesk','Help Tool','2023-11-22','2023-11-25',1);
INSERT INTO GroupTable VALUES('BoldSign','Online Signature','2023-08-10','2023-09-17',1);
INSERT INTO GroupTable VALUES('BoldReport',NULL,'2023-08-10','2023-09-17',1);

INSERT INTO UserGroup VALUES(0001,0001,'2023-12-12',1);
INSERT INTO UserGroup VALUES(0002,0002,'2023-11-12',1);
INSERT INTO UserGroup VALUES(0003,0003,'2023-10-12',1);

SELECT * FROM UserTable
SELECT * FROM UserGroup
SELECT * FROM GroupTable

SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID]
WHERE GroupTable.[CreatedDate] > '2023-12-01';

SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID] 

CREATE PROC spGetDesignation
@Designation NVARCHAR(20)
AS
BEGIN
     SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable WHERE Designation = @Designation 
END

SELECT * FROM UserTable
LEFT JOIN UserTable ON UserTable.[ID] = UserGroup.[UserID]
LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID]