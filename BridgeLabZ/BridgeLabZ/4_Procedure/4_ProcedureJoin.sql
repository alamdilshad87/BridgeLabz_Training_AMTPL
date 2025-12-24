create procedure sp_GetEmployeesWithDept
	@deptname varchar(50)
as
begin
	set nocount on;
	select e.*,d.deptname from dbo.Employee e
	join dbo.department d on e.deptid=d.deptid
	where d.deptname=@deptname;
end;