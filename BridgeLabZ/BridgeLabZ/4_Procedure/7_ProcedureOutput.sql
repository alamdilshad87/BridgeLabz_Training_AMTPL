create procedure sp_GetEmployeeCountByDept
	@deptid int,
	@empcount int output

as
begin
	set nocount on;
	select @empcount = count(*)
	from dbo.EMployee
	where deptid=@deptid;
end;
