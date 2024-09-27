using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace q2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {

        [HttpGet(template: "greetingname")]
        public string q2(string firstname)
        {
            return "Hi" + " " + firstname + "!";
        }
    }
}