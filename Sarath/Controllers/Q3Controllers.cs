using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Q3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        //GET localhost:xx/api/q3/cube -> "Cube"
        [HttpGet(template:"cube/{value}")]
        public int q3(int value)
        {
            int cubevalue = value * value * value;
                return cubevalue;
        }
    }
}