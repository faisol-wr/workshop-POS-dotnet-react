
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        // GET: /home
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Welcome to the Home Controller!");
        }
    }
}