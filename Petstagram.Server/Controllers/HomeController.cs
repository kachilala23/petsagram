using Microsoft.AspNetCore.Mvc;

namespace Petstagram.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        //[Authorize]

        public IActionResult Get()
        {
            return Ok("It works");
        }
    }
}
