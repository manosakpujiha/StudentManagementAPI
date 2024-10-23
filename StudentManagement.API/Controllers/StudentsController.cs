using Microsoft.AspNetCore.Mvc;
using StudentManagement.Library.Models;
using StudentManagement.Library.Services;

namespace StudentManagement.API.Controllers
{
    [ApiController] // This attribute tells Swagger it's a Web API controller
    [Route("api/[controller]")] // This sets up routing for /api/students
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpGet]
        [Route("GetStudentById/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
               return NotFound($"Student with ID {id} not found.");

            return Ok(student);
        }

        [HttpPost]
        [Route("AddStudent")]
        public IActionResult AddStudent([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return Ok();
        }

        [HttpDelete]
        [Route("RemoveStudent/{id}")]
        public IActionResult RemoveStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
                return NotFound($"Student with ID {id} not found.");

            _studentService.RemoveStudent(id);
            return Ok($"Student with ID {id} has been removed.");

        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");

            }

            student.FirstName = updatedStudent.FirstName;
            student.LastName = updatedStudent.LastName;
            student.Email = updatedStudent.Email;

            _studentService.UpdateStudent(student); 
            return Ok($"Student with ID {id} has been updated.");// Return the updated student
        }
    }
}
