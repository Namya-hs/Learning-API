using LearningWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningWebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        [HttpGet("gethotel/{HotelName}")] 
        public IActionResult GetHotelName([FromRoute]string HotelName)
        {
            return Content(HotelName);
        }
        [HttpPost("order/{OrderDetails}")]
        public IActionResult MakeOrder([FromRoute] string OrderDetails)
        {
            return Content(OrderDetails);
        }
        [HttpGet("getReceipeList")]
        public IActionResult ReceipesList()
        {

            List<Receipes> receipes = new List<Receipes>() {

                new Receipes {FoodId=1,Name="Poori"},
                new Receipes {FoodId=2,Name="Dosa"},
                new Receipes {FoodId = 3,Name="Idly"},
                new Receipes {FoodId = 4,Name="Roti"},
                new Receipes {FoodId=5,Name="Pulao"}
            
            };

            return Ok(receipes);
        }
        [HttpPost("submitList")]
        public IActionResult getList([FromBody] List<Receipes> rec)
        {
            return Ok(rec);
        }
        [HttpPost("newcust")]
        public IActionResult newCustomer([FromHeader]string custName)
        {
            return Ok(custName);
        }
        [HttpGet("GetPrice")]
        public IActionResult Price([FromQuery]int price)
        {
            return Ok(price);
        }
        [HttpGet("Getdetails")]
        public IActionResult Details([FromForm]Receipes detail)
        { 
            return Ok(detail);
        }
        [HttpPost("AllMethods/{orders}")]
        public IActionResult OrderDetails([FromHeader] string HotelName, [FromForm] student stud, [FromQuery] string totalNum, [FromRoute] string orders)
        {
            return Ok($"From Form {stud.description},From Query {totalNum}, From route {orders},From Header {HotelName}");
        }
    }
}
