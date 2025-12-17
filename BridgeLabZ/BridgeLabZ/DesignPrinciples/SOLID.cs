using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabZ.DesignPrinciples
{
    internal class SOLID
    {
        // Single Responsibility Principle
        class Student
        {
            public int Id { get; }
            public string Name { get; }
            public string Course { get; }

            public Student(int id, string name, string course)
            {
                Id = id;
                Name = name;
                Course = course;
            }
        }

        // Interface Segregration Principle
        interface IStudentRepository
        {
            void Add(Student student);
            List<Student> GetAll();
        }

        interface INotificationService
        {
            void Notify(string message);
        }

        //Dependency Inversion Principle
        class StudentRepository : IStudentRepository
        {
            private readonly List<Student> students = new();

            public void Add(Student student)
            {
                students.Add(student);
            }

            public List<Student> GetAll()
            {
                return students;
            }
        }

       //OCP & LSP
        class EmailNotification : INotificationService
        {
            public void Notify(string message)
            {
                Console.WriteLine("Email: " + message);
            }
        }

        class SmsNotification : INotificationService
        {
            public void Notify(string message)
            {
                Console.WriteLine("SMS: " + message);
            }
        }

        //Open/Closed Principle & Linskov Substitutional Principle
        class StudentService
        {
            private readonly IStudentRepository repository;
            private readonly INotificationService notification;

            public StudentService(IStudentRepository repository,
                                  INotificationService notification)
            {
                this.repository = repository;
                this.notification = notification;
            }

            public void RegisterStudent(Student student)
            {
                repository.Add(student);
                notification.Notify($"Student {student.Name} registered");
            }

            public void DisplayStudents()
            {
                foreach (var s in repository.GetAll())
                {
                    Console.WriteLine($"{s.Id} - {s.Name} - {s.Course}");
                }
            }
        }

        class Program
        {
            static void Main()
            {
                IStudentRepository repository = new StudentRepository();
                INotificationService notification = new EmailNotification();
                // Change to new SmsNotification() without touching logic

                StudentService service = new StudentService(repository, notification);

                service.RegisterStudent(new Student(1, "Dilshad", "Computer Science"));
                service.RegisterStudent(new Student(2, "Aman", "Electronics"));

                Console.WriteLine("\nAll Students:");
                service.DisplayStudents();
            }
        }
    }

}