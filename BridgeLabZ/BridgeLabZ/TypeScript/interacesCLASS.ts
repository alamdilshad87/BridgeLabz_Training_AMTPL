interface Employee2 {
  id: number;
  name: string;
  salary: number;
  department?: string;
}

class CompanyEmployee implements Employee2 {
  id: number;
  name: string;
  salary: number;
  department?: string;

  constructor(
    id: number,
    name: string,
    salary: number,
    department?: string
  ) {
    this.id = id;
    this.name = name;
    this.salary = salary;
    this.department = department;
  }

  getAnnualSalary(): number {
    return this.salary * 12;
  }
}

const emp1 = new CompanyEmployee(1, "Dilshad", 60000);
console.log(emp1.getAnnualSalary());
