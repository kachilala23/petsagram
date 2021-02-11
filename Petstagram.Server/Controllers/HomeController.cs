using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Petstagram.Server.Controllers
{

    public class HomeController : ApiController
    {
        [Authorize]

        public ActionResult Get()
        {
            return Ok("It works");
        }
    }
}
