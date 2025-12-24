create procedure sp_GetEmployees_Filtered
	@deptid int, @city varchar(50), @gender char(1)
as
begin
	set nocount on;
	select * from dbo.employee
	where deptid=@deptid
	and city=@city
	and gender=@gender;
end;
