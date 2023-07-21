using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LearningWebAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace LearningWebAPI.Controllers
{
    [Route("school/")]
    [ApiController]
    public class SchoolController : ControllerBase
    {

        [HttpGet("getschool/{schoolName}")]
        public IActionResult GetSchoolName(string schoolName)
        {
            return Content(schoolName);
        }
        //always good practice
        [HttpGet("getschool/{schoolName}/{id:int:min(10)}")]
        public IActionResult GetSchoolNameFromRoute([FromRoute] string schoolName, [FromRoute] int id)
        {


            return Content($"{schoolName} and the id is {id}");
        }

        [HttpPost("newadmission")]
        public IActionResult NewAdmission([FromBody] List<student> student)
        {
            return Ok(student);
        }


        [HttpPost("newadmissionform")]
        public IActionResult AdmissionForm([FromForm][Required] Admission admissionForm)
        {
            return Ok(admissionForm);
        }


        [HttpGet("queryform")]
        public IActionResult QueryForm([FromQuery] string name, [FromQuery] string query)
        {
            return Ok($"{name} asked  {query}");
        }

        [HttpGet("header")]
        public IActionResult Header([FromHeader] string name)
        {
            return AcceptedAtAction("newadmission");
          
        }
    }
}
//Httpget post put 
//fromroute fromquery frombody fromform fromheader
//u have collection
//food hotel
//7 routing get/post/put (fromroute fromquery frombody fromform fromheader) all should be there 
//model food 
//1: getoreder 
//food model  - foodname price id
