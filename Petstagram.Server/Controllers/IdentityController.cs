using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Petstagram.Server.Data.Models;
using Petstagram.Server.Data.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Petstagram.Server.Controllers
{

    public abstract class IdentityController : ApiController
    {

        private readonly UserManager<User> userManager;
        protected IdentityController(UserManager<User> userManager) 
            => this.userManager = userManager; 
        
        public async Task<IActionResult> Register(RegisterUserRequestModel model)
        {
            var user = new User
            {
                Email = model.Email,
                UserName = model.UserName
            };
            var result = await this.userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest(result.Errors);

        }
    }
}
