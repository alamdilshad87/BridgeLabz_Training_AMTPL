CREATE PROCEDURE usp_Customers_NoClaims_NoPayments
AS
BEGIN
    SELECT DISTINCT c.CustomerId, c.CustomerName
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    LEFT JOIN Claims cl ON p.PolicyId = cl.PolicyId
    LEFT JOIN Payments pay ON p.PolicyId = pay.PolicyId
    WHERE cl.ClaimId IS NULL
      AND pay.PaymentId IS NULL;
END;
