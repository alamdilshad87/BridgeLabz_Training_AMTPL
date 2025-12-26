declare @total int;
exec sp_GetEmployeeCountByDept 2,@total Output;
Select @total as EmployeeCount;