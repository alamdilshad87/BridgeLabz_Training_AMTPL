CREATE PROCEDURE usp_PolicyReport
AS
BEGIN
    SELECT
        c.CustomerName,
        pt.PolicyTypeName,
        p.PremiumAmount,
        ISNULL(SUM(pay.Amount),0) AS TotalPaid,
        ISNULL(SUM(cl.ClaimAmount),0) AS TotalClaims,
        pt.CoverageAmount - ISNULL(SUM(cl.ClaimAmount),0) AS RemainingCoverage
    
    FROM Policies p
    
    JOIN Customers c ON p.CustomerId = c.CustomerId
    JOIN PolicyTypes pt ON p.PolicyTypeId = pt.PolicyTypeId
    LEFT JOIN Payments pay ON p.PolicyId = pay.PolicyId
    LEFT JOIN Claims cl ON p.PolicyId = cl.PolicyId
    
    GROUP BY
        c.CustomerName,
        pt.PolicyTypeName,
        p.PremiumAmount,
        pt.CoverageAmount;
END;
