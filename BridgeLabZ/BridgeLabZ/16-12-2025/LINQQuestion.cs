using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ
{
    internal class LINQQuestion
    {
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
            public DateTime JoiningDate { get; set; }
            public int Age { get; set; }
            public double Salary { get; set; }
        }

        class Program
        {
            static void Main()
            {
                List<Employee> employees = new List<Employee>()
                {
                    new Employee { Id=1, Name="Gaurav",  Department="IT", JoiningDate=DateTime.Now.AddMonths(-3), Age=25, Salary=60000 },
                    new Employee { Id=2, Name="Pranav",  Department="HR", JoiningDate=DateTime.Now.AddMonths(-10), Age=32, Salary=45000 },
                    new Employee { Id=3, Name="Dilshad", Department="IT", JoiningDate=DateTime.Now.AddMonths(-2), Age=35, Salary=75000 },
                    new Employee { Id=4, Name="Adarsh",  Department="Finance", JoiningDate=DateTime.Now.AddMonths(-5), Age=28, Salary=50000 },
                    new Employee { Id=5, Name="Om",    Department="IT", JoiningDate=DateTime.Now.AddMonths(-1), Age=40, Salary=90000 }
                };

                //1. Filter employees who joined in last 6 months in IT
                var recentIT = from e in employees
                               where e.Department == "IT" &&
                               e.JoiningDate >= DateTime.Now.AddMonths(-6)
                               select e;

                Console.WriteLine("1. Recent IT Employees:");
                foreach (var e in recentIT)
                    Console.WriteLine(e.Name);

                //2. Names sorted by length
                var nameLengthSort = employees
                    .OrderBy(e => e.Name.Length)
                    .Select(e => e.Name);


                Console.WriteLine("\n2. Names sorted by length:");
                foreach (var n in nameLengthSort)
                    Console.WriteLine(n);

                //3️. Group by department & average salary
                var avgSalary = from e in employees
                                group e by e.Department into deptGroup
                                select new
                                {
                                    Department = deptGroup.Key,
                                    AvgSalary = deptGroup.Average(e => e.Salary)
                                };

                Console.WriteLine("\n3. Average Salary per Department:");
                foreach (var a in avgSalary)
                    Console.WriteLine($"{a.Department} - {a.AvgSalary}");

                //4️. Employees with salary > 60000 (alphabetically)
                var highPaid = employees
                    .Where(e => e.Salary > 60000)
                    .OrderBy(e => e.Name)
                    .Select(e => e.Name);

                Console.WriteLine("\n4. High Paid Employees:");
                foreach (var n in highPaid)
                    Console.WriteLine(n);

                //5️. Even employee IDs in descending order
                var evenIds = employees
                    .Where(e => e.Id % 2 == 0)
                    .OrderByDescending(e => e.Id);

                Console.WriteLine("\n5. Even Employee IDs Descending:");
                foreach (var e in evenIds)
                    Console.WriteLine(e.Id);

                //6️. Employee count per department
                var empCount = employees
                    .GroupBy(e => e.Department)
                    .Select(g => new
                    {
                        Dept = g.Key,
                        Count = g.Count()
                    });

                Console.WriteLine("\n6. Employees per Department:");
                foreach (var c in empCount)
                    Console.WriteLine($"{c.Dept} - {c.Count}");

                //7️. Employees whose name starts with 'A'
                var nameA = employees
                    .Where(e => e.Name.StartsWith("A"));

                Console.WriteLine("\n7. Names starting with A:");
                foreach (var e in nameA)
                    Console.WriteLine(e.Name);

                //8️. Highest salary
                double highestSalary = employees.Max(e => e.Salary);
                Console.WriteLine("\n8. Highest Salary: " + highestSalary);

                //9️. Employees older than 30 (Name & Age)
                var above30 = employees
                    .Where(e => e.Age > 30)
                    .Select(e => new { e.Name, e.Age });

                Console.WriteLine("\n9. Employees Age > 30:");
                foreach (var e in above30)
                    Console.WriteLine($"{e.Name} - {e.Age}");

                //10. Group employees by Even / Odd ID
                var evenOdd = employees
                    .GroupBy(e => e.Id % 2 == 0);

                Console.WriteLine("\n10. Group Even & Odd IDs:");
                foreach (var g in evenOdd)
                {
                    Console.WriteLine(g.Key ? "Even" : "Odd");
                    foreach (var e in g)
                        Console.WriteLine(e.Name);
                }

                //11. Remove duplicate departments (case-insensitive)
                var uniqueDepartments = employees
                    .Select(e => e.Department)
                    .Distinct(StringComparer.OrdinalIgnoreCase);

                Console.WriteLine("\n11. Unique Departments:");
                foreach (var d in uniqueDepartments)
                    Console.WriteLine(d);

                //12. Top 3 highest paid employees
                var top3 = employees
                    .OrderByDescending(e => e.Salary)
                    .Take(3);

                Console.WriteLine("\n12. Top 3 Highest Paid Employees:");
                foreach (var e in top3)
                    Console.WriteLine($"{e.Name} - {e.Salary}");

                Console.ReadLine();
            }
        }
    }
}