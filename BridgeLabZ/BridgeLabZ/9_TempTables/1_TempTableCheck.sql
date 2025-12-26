SELECT EmpId, Name
INTO #TempEmployee
FROM dbo.Employee
WHERE Salary > 50000;

SELECT * FROM #TempEmployee;
