
alter procedure sp_GetAllEmployees
as
begin
	select * from dbo.Employee;
end;