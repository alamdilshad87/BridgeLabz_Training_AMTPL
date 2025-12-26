CREATE OR ALTER FUNCTION fn_GetEmployeesByDept
(
    @DeptId INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        EmpId,
        Name,
        Salary,
        City
    FROM dbo.Employee
    WHERE DeptId = @DeptId
);
GO
