
using Microsoft.AspNetCore.Mvc;
using Npgsql;

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

        [HttpGet]
        [Route("[action]")]
        public IActionResult TestConnect()
        {
            try
            {
                using NpgsqlConnection conn = new Connect().GetConnection();
                return Ok(new { message = "connected" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new
                {
                    message = ex.Message
                });
            }
        }
        
    }
}