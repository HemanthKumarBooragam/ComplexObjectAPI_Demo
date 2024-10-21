using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ComplexObjectAPI.Models;

namespace ComplexObjectAPI.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController
    {
        [HttpGet("details")]
        public List<Student> GetStudent()
        {
            return new List<Student>() {
                    new Student{ID = 1001, Name = "Hemanth", Email = "test@test.com", Address = "Hyderabad, India"},
                    new Student{ID = 1002, Name = "Surendra", Email = "test@test.com", Address = "Bangalore, India"},
                    new Student{ID = 1003, Name = "Shravan", Email = "test@test.com", Address = "Andhrapradesh, India"}
            };
        }
    }
}