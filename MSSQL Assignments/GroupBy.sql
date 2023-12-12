SELECT * FROM UserTable
SELECT Designation, SUM(Salary) AS TotalSalary 
FROM UserTable 
GROUP BY Designation;

SELECT City, Designation, SUM(Salary) AS TotalSalary
FROM UserTable
GROUP BY City,Designation;
