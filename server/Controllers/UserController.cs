
using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(LoginModel user) {
            return Ok();
        }
    }
}