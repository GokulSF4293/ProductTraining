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

INSERT INTO GroupTable VALUES('Gokul','Good and Perfect Software Engineer','2023-12-12','2023-12-12',1);

INSERT INTO UserGroup VALUES(0001,0001,'2023-12-12',1);

SELECT * FROM UserTable
SELECT * FROM GroupTable
SELECT * FROM UserGroup