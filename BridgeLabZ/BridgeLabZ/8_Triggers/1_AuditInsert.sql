CREATE TRIGGER trg_EmployeeInsert
ON dbo.Employee
AFTER INSERT
AS
BEGIN
    PRINT 'Employee Inserted';
END;
