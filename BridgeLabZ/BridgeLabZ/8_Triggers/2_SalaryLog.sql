CREATE TRIGGER trg_SalaryUpdate
ON dbo.Employee
AFTER UPDATE
AS
BEGIN
    SELECT * FROM inserted;
    SELECT * FROM deleted;
END;