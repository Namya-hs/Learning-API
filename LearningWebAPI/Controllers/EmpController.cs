using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningWebAPI.Controllers
{
    [Route("incadea/employee/[controller]/[action]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        [HttpGet]
        public IActionResult getEmployee()
        {
            return Content("Namya");
        }
        [HttpPost]
        public IActionResult gEmployee()
        {
            return Content("Namya");
        }
        [HttpPost("name/{name}")]
        public IActionResult postEmployee([FromRoute] string name)
        {
            if(name=="namya")
            {
                return Content($"{name} is a girl");

            }else if(name=="himanshu")
            {
                return Content($"{name} is a boy");

            }
            else
            {
                return Content("Neither girl nor boy");
            }
           
        }
    }
}
//GET,POST,PUT,PAtch,Delete:-GET:-means Retrive the dta from db.
//POST: Creating new data in db
//PUT: Update in database..
//Patch : similar put partial upadte
//Delete: Delete Data in Db
//api 
//LOCALHOST: INCADEA/
//incadea/getemployyelist return number emplyee get
//incadea/setname/variable  return variable is added successfully post one condition if name == namya then return namya cannot add.
