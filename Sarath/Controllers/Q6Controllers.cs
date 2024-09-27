using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Q6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        
        [HttpGet(template: "hexagon")]
        public double q6(double xyz)
        {
            double hexavalue = 3 * Math.Sqrt(3) * xyz *  xyz;
            double actvalue = hexavalue / 2;
            return actvalue;
        }
    }
}