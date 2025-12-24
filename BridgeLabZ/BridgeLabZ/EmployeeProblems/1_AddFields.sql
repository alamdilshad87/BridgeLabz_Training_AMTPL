use employeedb;
go

alter table employee
add
gender char(1) check ( gender in ('m','f')),
doj date,
city varchar(50) default 'unknown',
isactive bit default 1;
