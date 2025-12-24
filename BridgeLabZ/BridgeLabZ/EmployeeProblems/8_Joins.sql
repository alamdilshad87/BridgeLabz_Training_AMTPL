select * from employee;
select * from department;

select e.Name, e.Salary, d.DeptName
from employee e
inner join department d
on e.deptid=d.deptid;

select e.empid,e.name, e.salary, d.deptname
from employee e
left join department d
on e.deptid=d.deptid;

select e.name, d.deptname
from employee e
right join department d
on e.DeptId=d.deptid;

SELECT e.Name, d.DeptName
FROM Employee e
FULL OUTER JOIN Department d
ON e.DeptId = d.DeptId;


SELECT *
FROM Employee e
WHERE EXISTS (
    SELECT 1
    FROM Department d
    WHERE d.DeptId = e.DeptId
);
