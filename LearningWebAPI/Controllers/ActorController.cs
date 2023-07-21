using LearningWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningWebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActor _Actor;

    }
}
