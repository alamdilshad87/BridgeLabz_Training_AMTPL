CREATE TRIGGER trg_PreventClaimApproval
ON Claims
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Policies p ON i.PolicyId = p.PolicyId
        WHERE i.ClaimStatus = 'Approved'
          AND p.Status = 'Expired'
    )
    BEGIN
        ROLLBACK;
        THROW 50010, 'Cannot approve claim for expired policy', 1;
    END
END;
