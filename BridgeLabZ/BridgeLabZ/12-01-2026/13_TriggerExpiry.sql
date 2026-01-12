CREATE TRIGGER trg_AutoExpirePolicy
ON Policies
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Policies
    SET Status = 'Expired'
    WHERE EndDate < CAST(GETDATE() AS DATE);
END;