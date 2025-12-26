CREATE VIEW vw_ActiveEmployees
AS
SELECT EmpId, Name, Salary, City
FROM dbo.Employee
WHERE IsActive = 1;
go

SELECT * FROM vw_ActiveEmployees;
