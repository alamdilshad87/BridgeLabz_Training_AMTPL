CREATE OR ALTER FUNCTION fn_GetActiveEmployeesByCity
(
    @City VARCHAR(50)
)
RETURNS @Result TABLE
(
    EmpId INT,
    Name VARCHAR(50),
    Salary DECIMAL(10,2),
    DeptId INT
)
AS
BEGIN
    INSERT INTO @Result
    SELECT EmpId, Name, Salary, DeptId
    FROM dbo.Employee
    WHERE City = @City
      AND IsActive = 1;

    RETURN;
END;
GO
