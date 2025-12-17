using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students = new List<Student>()
        {
            new Student {Id=1,Name="komal" },
            new Student {Id=2,Name="Aarti" }
        };

        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s=>s.Id==id);
            if(student == null)
            {
                return NotFound("Student not found");
            }

            return Ok(student);
        }

        [HttpGet("Students")]
        public IActionResult GetAllStudents()
        {

            if (students == null | students.Count == 0)
                return NotFound(new ApiResponse
                {
                    Success = false,
                    Message = "Student no data",

                    Data = null
                });



            return Ok(new ApiResponse
            {
                Success = true,
                Message = "student data fetched",
                Data = students
            });
        }
       
        [HttpGet("name")]
        public IActionResult GetStudentByName(String name)
        {
            var student = students.FirstOrDefault(s=>s.Name==name);
            if (student == null | string.IsNullOrWhiteSpace(name))
                return NotFound("Not Found");

            return Ok(student);
        }
        [HttpPost("student")]
        public IActionResult AddStudent(Student student)
        {
    
            if (student == null)
                return NotFound("Not found");
            students.Add(student);
            return Ok(students);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id,Student updatestudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
                if (student == null)
                return NotFound("Not found");

            student.Name = updatestudent.Name;
            return Ok(student);
        }
    }
}
