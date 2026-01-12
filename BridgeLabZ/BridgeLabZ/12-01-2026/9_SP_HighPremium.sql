CREATE PROCEDURE usp_HighPremiumPolicies
AS
BEGIN
	SELECT *
	FROM Policies p
	WHERE PremiumAmount > (
	SELECT AVG(PremiumAmount)
	FROM Policies p2
	WHERE p2.PolicyTypeId = p.PolicyTypeId
	AND YEAR(p2.StartDate) = YEAR(p.StartDate)
	);
END;