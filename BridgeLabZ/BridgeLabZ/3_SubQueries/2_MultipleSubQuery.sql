select * from employee
where deptid in
(select deptid from department 
where deptname in('hr','it'));

select e.*, d.deptname
from employee e join department d
on e.DeptId=d.deptid
where e.deptid in 
(select deptid from department 
where deptname in('hr','it'));

select * from employee 
where Salary>any
(select salary 
from employee where deptid=2);

SELECT *
FROM Employee
WHERE Salary > ALL (
    SELECT Salary
    FROM Employee
    WHERE DeptId = 1
);

SELECT *
FROM Employee e
WHERE Salary > (
    SELECT AVG(Salary)
    FROM Employee
    WHERE DeptId = e.DeptId
);

SELECT *
FROM (
    SELECT DeptId, cast(AVG(Salary) as decimal(10,2)) AS AvgSalary
    FROM Employee
    GROUP BY DeptId
) AS DeptAvg
WHERE AvgSalary > 50000;
