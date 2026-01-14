class Employee {
  constructor(name, salary) {
    this.name = name;
    this.salary = salary;
  }

  getAnnualSalary() {
    return this.salary * 12;
  }
}

const emp = new Employee("Dilshad", 50000);
console.log("Annual Salary :", emp.getAnnualSalary());
