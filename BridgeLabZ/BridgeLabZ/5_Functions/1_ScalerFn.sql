create or alter function fn_GetSalaryCategory
	( @salary decimal(10,2))
	returns varchar(20)
as begin
	declare @result varchar(20);
	if @salary >=60000
		set @result='High';
	else if @salary >=50000
		set @result='Medium';
	else
		set @result='Low';
	return @result;
end;
