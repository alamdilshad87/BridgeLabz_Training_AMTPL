WITH DeptAvg AS (
    SELECT DeptId, AVG(Salary) AvgSal
    FROM dbo.Employee
    GROUP BY DeptId
)
SELECT *
FROM DeptAvg
WHERE AvgSal > 50000;
