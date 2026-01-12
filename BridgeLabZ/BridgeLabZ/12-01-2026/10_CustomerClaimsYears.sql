CREATE PROCEDURE usp_Customers_Claims_2023_2024
AS
BEGIN
    SELECT DISTINCT c.CustomerId, c.CustomerName
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    JOIN Claims cl ON p.PolicyId = cl.PolicyId
    WHERE YEAR(cl.ClaimDate) IN (2023, 2024);
END;

CREATE PROCEDURE usp_Customers_Claims_BothYears
AS
BEGIN
    SELECT c.CustomerId, c.CustomerName
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    JOIN Claims cl ON p.PolicyId = cl.PolicyId
    GROUP BY c.CustomerId, c.CustomerName
    HAVING COUNT(DISTINCT YEAR(cl.ClaimDate)) = 2;
END;

CREATE PROCEDURE usp_Customers_Claims_Only2023
AS
BEGIN
    SELECT c.CustomerId, c.CustomerName
    FROM Customers c
    JOIN Policies p ON c.CustomerId = p.CustomerId
    JOIN Claims cl ON p.PolicyId = cl.PolicyId
    GROUP BY c.CustomerId, c.CustomerName
    HAVING
        SUM(CASE WHEN YEAR(cl.ClaimDate) = 2023 THEN 1 ELSE 0 END) > 0
        AND
        SUM(CASE WHEN YEAR(cl.ClaimDate) = 2024 THEN 1 ELSE 0 END) = 0;
END;