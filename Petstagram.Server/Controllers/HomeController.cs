using Microsoft.AspNetCore.Mvc;

namespace Petstagram.Server.Controllers
{

    public class HomeController : ApiController
    {
        //[Authorize]

        public IActionResult Get()
        {
            return Ok("It works");
        }
    }
}
