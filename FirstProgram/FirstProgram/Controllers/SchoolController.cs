using FirstProgram.Dto;
using FirstProgram.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstProgram.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public SchoolController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: api/school/GetAllStudents
        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = _studentRepository.GetAllStudent();
            return Ok(students);
        }

        // POST: api/school/AddStudent
        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentDto student)
        {
            var createdStudent = _studentRepository.AddStudent(student);
            return Ok(createdStudent);
        }
    }
}
