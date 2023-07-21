using LearningWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningWebAPI.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly Istudent _student;
        public StudentController(Istudent student)
        {
            _student = student;  
        }
        [HttpPost("NewAdmission")]
        public IActionResult NewStudent([FromBody] student stud)
        {
            var c = _student.NewStudent(stud);
            return Ok(c);
        }
        [HttpGet("GetStudent/{id:int}")]
        public IActionResult GetStudentById([FromRoute]int id)
        {
          var a=  _student.GetStdById(id);
            return Ok(a);
        }
        [HttpGet("AllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = _student.GetAllStds();
            return Ok(students);
        }
        
        [HttpPut ("UpdateData/{id:int}")]
        public IActionResult UpdateStudentDetails([FromRoute]int id, [FromBody] student updatedstudent) 
        {
            var data = _student.UpdateStudent(id,updatedstudent);
            if (data == 1)
            {
               var a = _student.GetStdById(id);
                return Ok(a);

            }
            else
            {
                return Ok("Something went or user does not exist");
            }
            
        }

    }
}