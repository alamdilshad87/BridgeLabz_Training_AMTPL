SELECT * FROM Employee
WHERE (Salary > 0) and
(city='mumbai' or city='delhi') and gender='m';

SELECT name,city FROM Employee
WHERE City <> 'Delhi';

select * from employee where
(city='mumbai' or city='delhi') and (city <> 'pune');