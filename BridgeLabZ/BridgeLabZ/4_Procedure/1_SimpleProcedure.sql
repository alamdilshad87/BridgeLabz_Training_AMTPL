--Get All Employees
Create Procedure sp_GetAllEmployees
as
begin
	select * from employee;
end;
go

alter procedure sp_GetAllEmployees
as
begin
	select * from dbo.Employee;
end;