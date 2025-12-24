USE EmployeeDB;
GO

CREATE TABLE Employee (
    EmpId INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Age INT CHECK (Age >= 18),
    Salary DECIMAL(10,2),
    DeptId INT
);
