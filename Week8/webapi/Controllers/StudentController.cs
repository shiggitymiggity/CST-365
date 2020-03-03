using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _dbContext;

        public StudentController(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents()
        {
            var result = _dbContext.Student.ToList();
            return Ok(result);
        }

        [HttpGet("{studentId}")]
        public ActionResult<Student> GetStudent(int student_Id)
        {
            var student = _dbContext.Student
                .SingleOrDefault(p => p.studentId == student_Id);

            if (student != null) {
                return student;
            } else {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            _dbContext.Student.Add(student);
            _dbContext.SaveChanges();

            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status201Created);
        }

        [HttpDelete("{studentId}")]
        public ActionResult DeleteStudent(int student_Id)
        {
            var student = new Student { studentId = student_Id };

            _dbContext.Student.Attach(student);
            _dbContext.Student.Remove(student);
            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut("{studentId}")]
        public ActionResult UpdateStudent(int student_Id, Student studentUpdate)
        {
            var student = _dbContext.Student
                .SingleOrDefault(p => p.studentId == student_Id);

            if (student != null)
            {
                student.studentId = studentUpdate.studentId;
                student.Email_Address = studentUpdate.Email_Address;

                _dbContext.Update(student);

                _dbContext.SaveChanges();
            }

            return NoContent();
        }
    }
}