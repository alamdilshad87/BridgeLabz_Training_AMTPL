select * from employee where salary >
( select avg(Salary) from employee);
