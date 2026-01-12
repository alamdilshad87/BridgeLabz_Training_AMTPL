CREATE PROCEDURE usp_PolicyType_TotalPremium
AS
BEGIN
    SELECT pt.PolicyTypeName, SUM(p.PremiumAmount) AS TotalPremium
    FROM Policies p
    JOIN PolicyTypes pt ON p.PolicyTypeId = pt.PolicyTypeId
    GROUP BY pt.PolicyTypeName;
END;

CREATE PROCEDURE usp_City_TotalClaims
AS
BEGIN
    SELECT c.City, SUM(cl.ClaimAmount) AS TotalClaims
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    JOIN Claims cl ON p.PolicyId = cl.PolicyId
    GROUP BY c.City;
END;

CREATE PROCEDURE usp_Top5_Customers_By_Payment
AS
BEGIN
    SELECT TOP 5
        c.CustomerName,
        SUM(pay.Amount) AS TotalPaid
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    JOIN Payments pay ON p.PolicyId = pay.PolicyId
    GROUP BY c.CustomerName
    ORDER BY TotalPaid DESC;
END;
