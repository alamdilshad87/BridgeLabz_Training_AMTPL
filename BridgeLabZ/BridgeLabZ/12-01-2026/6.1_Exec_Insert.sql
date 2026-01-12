EXEC usp_InsertPolicyWithFirstPayment
    @CustomerId = 2,
    @PolicyTypeId = 1,
    @StartDate = '2025-01-01',
    @EndDate = '2025-12-31',
    @PremiumAmount = 12000,
    @FirstPaymentAmount = 6000;