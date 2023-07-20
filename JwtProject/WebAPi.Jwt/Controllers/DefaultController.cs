using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPi.Jwt.Models;

namespace WebAPi.Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenCreator() 
        {
            return Ok(new CreateToken().TokenCreate());
        }
        [HttpGet("[action]")]
        public IActionResult AdminTokenCreater()
        {
            return Ok(new CreateToken().TokenCreateAdmin());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Welcome");
        }
        [Authorize(Roles = "Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Token successfully logged in..");
        }
    }
}
