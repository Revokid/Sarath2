using Microsoft.AspNetCore.Mvc;

namespace q1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        // GET localhost:xx/api/q1/welcome -> "Welcome to 5125!"
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}