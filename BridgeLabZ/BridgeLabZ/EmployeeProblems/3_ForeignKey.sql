use employeedb;
go

alter table employee
add constraint fk_employee_department
foreign key(deptid) references department(deptid);

