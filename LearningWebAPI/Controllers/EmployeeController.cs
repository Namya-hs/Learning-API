using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace LearningWebAPI.Controllers
{
    [Route("incadea")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet ("getList")]
        public IActionResult EmployeeList()
        {
            return Content("12");
        }
        [HttpPost ("newEmployee/{name}")]
        public IActionResult AddEmployee([FromRoute]string name) 
        {
            if (name == "namya")
            {
                return Content($"{name} cannot be added");
            }
            else
            {
                return Content($"{name} is added");
            }
        }
    }
}
