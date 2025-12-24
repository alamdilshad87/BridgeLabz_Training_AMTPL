SELECT COUNT(*) AS TotalEmployees FROM Employee;

SELECT 
    MIN(Salary) AS MinSalary,
    MAX(Salary) AS MaxSalary,
    AVG(Salary) AS AvgSalary
FROM Employee;

SELECT DeptId, COUNT(*) AS EmpCount
FROM Employee
GROUP BY DeptId;

SELECT DeptId, AVG(Salary) AS AvgSalary
FROM Employee
GROUP BY DeptId;

select deptid, cast(avg(Salary) as decimal(10,2)) as avgsalary
from employee group by deptid having avg(salary) >2000;
