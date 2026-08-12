using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using student_system.Dto;
using student_system.Repositories;

namespace student_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IStudentRepositoy _studentRepositoy;

        public SchoolController(IStudentRepositoy studentRepositoy)
        {
            _studentRepositoy = studentRepositoy;
        }

        [HttpGet("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = _studentRepositoy.GetAllStudents();
            return Ok(students);
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent([FromBody] StudentDto student)
        {
            var result = _studentRepositoy.AddStudent(student);
            return Ok(result);
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent([FromBody] StudentDtoUpdate student)
        {
            var result = _studentRepositoy.UpdateStudent(student);
            return Ok(result);
        }
        [HttpDelete("DeleteStudent/{studentId}")]
        public IActionResult DeleteStudent(int studentId)
        {
            var result = _studentRepositoy.DeleteStudent(studentId);
            return Ok(result);
        }

    }
}
