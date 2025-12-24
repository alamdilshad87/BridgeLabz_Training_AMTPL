SELECT name,deptid,age FROM Employee
WHERE Age BETWEEN 25 AND 30;

SELECT * FROM Employee
WHERE DeptId IN (1, 3);

select * from employee where
name like 'a%'; --starts with a