CREATE FUNCTION fn_LoyaltyDiscountPercent
(
    @CustomerId INT
)
RETURNS INT
AS
BEGIN
    DECLARE @TotalPaid DECIMAL(12,2);

    SELECT 
        @TotalPaid = ISNULL(SUM(pay.Amount), 0)
    FROM Payments pay
    JOIN Policies p ON pay.PolicyId = p.PolicyId
    WHERE p.CustomerId = @CustomerId;

    RETURN
        CASE
            WHEN @TotalPaid >= 100000 THEN 20
            WHEN @TotalPaid >= 50000 THEN 10
            WHEN @TotalPaid >= 20000 THEN 5
            ELSE 0
        END;
END;