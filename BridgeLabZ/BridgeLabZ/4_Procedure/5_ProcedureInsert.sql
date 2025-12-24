create procedure sp_InsertEmployee
	@empid int, @name varchar(50), @age int,
	@salary decimal(10,2), @deptid int, @email varchar(50),
	@gender char(1), @doj date, @city varchar(50)
as
begin
	set nocount on;
	insert into dbo.Employee
	(empid,name,age,salary,deptid,email,gender,doj,city)
	values
	(@empid,@name,@age,@salary,@deptid,@email,@gender,@doj,@city);
end;