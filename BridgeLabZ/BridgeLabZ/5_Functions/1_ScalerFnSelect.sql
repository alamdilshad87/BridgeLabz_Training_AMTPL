select empid, name, salary,
dbo.fn_GetSalaryCategory(salary) as salarycategory
from dbo.employee;