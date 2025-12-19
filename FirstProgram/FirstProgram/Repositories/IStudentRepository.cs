using FirstProgram.Dto;
using FirstProgram.Models;

namespace FirstProgram.Repositories
{
    public interface IStudentRepository
    {
        List<Students> GetAllStudent();
        string AddStudent(StudentDto student);
    }
}
