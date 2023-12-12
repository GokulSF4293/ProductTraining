CREATE PROC spGetDesignation
@Designation NVARCHAR(20)
AS
BEGIN
     SELECT * FROM UserTable WHERE Designation = @Designation 
END

spGetDesignation 'Software Engineer'

CREATE PROC spGetCreateDate
@CreatedDate DATETIME,
@City VARCHAR(50)
AS
BEGIN
     SELECT * FROM UserTable WHERE @CreatedDate = CreatedDate AND @City = City
END

spGetCreateDate '2023-12-12','Karur'

CREATE PROC spGetAllUser
AS
BEGIN
	SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
	LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
	LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID] 
END

spGetAllUser

ALTER PROC spGetAllUserNoNull
AS
BEGIN
	SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
	LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
	LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID]
	WHERE UserTable.[CreatedDate] < '2023-12-12';
END

spGetAllUserNoNull