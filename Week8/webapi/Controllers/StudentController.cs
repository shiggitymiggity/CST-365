  
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService, ILoggerFactory loggerFactory)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {

            return Ok(_studentService.GetAllStudents());
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int studentId)
        {
            var student = _studentService.GetStudentById(studentId);

            if (student != null) {
                return Ok(student);
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _studentService.AddStudent(student);

            return CreatedAtAction(nameof(GetStudent), new { id = student.studentId }, student);
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateStudent(int studentId, Student studentUpdate)
        {
            studentUpdate.studentId = studentId;
            _studentService.UpdateStudent(studentUpdate);

            return NoContent();
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);

            return Ok();
        }
    }
}