CREATE PROCEDURE sp_UpdateEmployeeSalary
    @EmpId INT, @Increment DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Employee
    SET Salary = Salary + @Increment
    WHERE EmpId = @EmpId;
END;
GO
