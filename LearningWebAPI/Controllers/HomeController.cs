using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningWebAPI.Controllers
{
    [Route("namya/[controller]/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("getname")]
        public IActionResult GetName()
        {
              return Content("Namya");
          
        }
        [HttpPost("gname")]
        public IActionResult GetName1()
        {
            return Content("namya");
        }
    }
}
