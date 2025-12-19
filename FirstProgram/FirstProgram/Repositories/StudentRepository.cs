using FirstProgram.Dto;
using FirstProgram.Models;

namespace FirstProgram.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDB _context;
        public StudentRepository(ApplicationDB context)
        {
            _context = context;
            
        }

        public List<Students> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public string AddStudent(StudentDto student)
        {
            _context.Students.Add(new Students
            {
                Name = student.Name,
                Class = student.Class,
                Age = student.Age,
                City = student.City,
                Email = student.Email,
                FatherName = student.FatherName,
                MotherName = student.MotherName,
                DOB = student.DOB

            });
            _context.SaveChanges();
            return "Student Added Succesfully";

        }
    }
}
