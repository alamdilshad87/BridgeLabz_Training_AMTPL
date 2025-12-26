SELECT name, type_desc
FROM sys.triggers
WHERE parent_id = OBJECT_ID('dbo.Employee');

EXEC sp_helptext 'trg_EmployeeInsert';

INSERT INTO dbo.Employee
(EmpId, Name, Age, Salary, DeptId, Email, Gender, DOJ, City, IsActive)
VALUES
(9, 'TriggerTest', 25, 30000, 1, 'trigger@test.com', 'M', '2024-01-01', 'TestCity', 1);
