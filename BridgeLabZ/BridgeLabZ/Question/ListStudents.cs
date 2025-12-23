using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a list of students, group them by department and find the number of students in each department.
namespace BridgeLabZ.Question
{
    internal class ListStudents
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public static void Main(string[] args)
        {
            List<ListStudents> students = new List<ListStudents>
            {
                new ListStudents { ID= 917, Name="Dilshad", Department="CSE", Age=21 },
                new ListStudents { ID= 919, Name="Kushagra", Department="ECE", Age=22 },
                new ListStudents { ID= 920, Name="Aman", Department="EEE", Age=20 },
                new ListStudents { ID= 921, Name="Gaurav", Department="CSE", Age=23 }
            };
            var groupedStudents = from stu in students
                                  group stu by stu.Department into deptGroupSQL
                                  select new
                                  {
                                      Department = deptGroupSQL.Key,
                                      Count = deptGroupSQL.Count()
                                  };
            Console.WriteLine("Using SQL\n");
            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"Department: {group.Department}, Count: {group.Count}");
            }
            
            var groupedStudentsLINQ = students
                .GroupBy(stu => stu.Department)
                .Select(deptGroupLINQ => new
                {
                    Department = deptGroupLINQ.Key,
                    Count = deptGroupLINQ.Count()
                });
            Console.WriteLine("\nUsing LINQ\n");
            foreach (var group in groupedStudentsLINQ)
            {
                Console.WriteLine($"Department: {group.Department}, Count: {group.Count}");
            }

        }
    }
}
