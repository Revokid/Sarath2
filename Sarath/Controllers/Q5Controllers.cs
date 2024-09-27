using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
  
        [HttpPost(template: "secret")]
        public string q5([FromBody] int value)
        {

            return $"Shh.. the secret is {value}";
        }
    }
}