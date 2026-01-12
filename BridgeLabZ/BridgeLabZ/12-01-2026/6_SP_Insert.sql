CREATE PROCEDURE usp_InsertPolicyWithFirstPayment
(
    @CustomerId INT,
    @PolicyTypeId INT,
    @StartDate DATE,
    @EndDate DATE,
    @PremiumAmount DECIMAL(10,2),
    @FirstPaymentAmount DECIMAL(10,2)
)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRAN;

    IF @PremiumAmount < (
        SELECT BasePremium
        FROM PolicyTypes
        WHERE PolicyTypeId = @PolicyTypeId
    )
    BEGIN
        ROLLBACK;
        THROW 50001, 'Premium is below base premium', 1;
    END

    IF EXISTS (
        SELECT 1 FROM Policies
        WHERE CustomerId = @CustomerId
          AND PolicyTypeId = @PolicyTypeId
          AND @StartDate <= EndDate
          AND @EndDate >= StartDate
    )
    BEGIN
        ROLLBACK;
        THROW 50002, 'Policy date overlap detected', 1;
    END

    INSERT INTO Policies
    (CustomerId, PolicyTypeId, StartDate, EndDate, PremiumAmount, Status)
    VALUES
    (@CustomerId, @PolicyTypeId, @StartDate, @EndDate, @PremiumAmount, 'Active');

    DECLARE @PolicyId INT = SCOPE_IDENTITY();

    INSERT INTO Payments (PolicyId, PaymentDate, Amount)
    VALUES (@PolicyId, GETDATE(), @FirstPaymentAmount);

    COMMIT;
END;
