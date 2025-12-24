ALTER PROCEDURE sp_GetEmployeesByDept
    @DeptId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM dbo.Employee
    WHERE DeptId = @DeptId;
END;
GO
