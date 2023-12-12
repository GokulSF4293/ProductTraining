ALTER VIEW vWConfidentialData
AS
	SELECT FirstName, LastName, Email, City, [Name] FROM UserTable
	LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
	LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID]
	WHERE UserTable.[CreatedDate] < '2023-12-12';

SELECT * FROM vWConfidentialData

CREATE VIEW vWSummarizedData
AS
SELECT UserTable.[City], UserTable.[Designation], SUM(Salary) AS TotalSalary 
FROM UserTable
GROUP BY UserTable.[City], UserTable.[Designation];

SELECT * FROM vWSummarizedData

CREATE VIEW vWRetriveUsers
AS
SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID] 

SELECT * FROM vWRetriveUsers;

CREATE VIEW vWRetriveUsersNoNull
AS
SELECT UserTable.[FirstName], GroupTable.[Name] FROM UserTable
LEFT JOIN UserGroup ON UserTable.[ID] = UserGroup.[UserID]
LEFT JOIN GroupTable ON UserGroup.[GroupID] = GroupTable.[ID]
WHERE UserTable.[CreatedDate] < '2023-12-12';

SELECT * FROM vWRetriveUsersNoNull