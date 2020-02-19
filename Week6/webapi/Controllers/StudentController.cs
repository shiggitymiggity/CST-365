using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Database;

namespace webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return Ok(getStudents());
        }

        [HttpPost]
        public ActionResult Post([FromBody] Student student)
        {
            student.Id = getNextId();

            InMemory.Students.Add(student);

            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            
            var student = InMemory.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        private List<Student> getStudents()
        {
            return InMemory.Students;
        }  

        private int getNextId()
        {
            return InMemory.Students.Max(p => p.Id) + 1;
        }
    }
}
