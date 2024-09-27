using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        [HttpGet(template: "Time")]
        public string timemachine(int days)
        {
            DateTime current = DateTime.Now;
            DateTime modify = current.AddDays(days);
            return modify.ToString("yyyy-MM-dd");
        }
    }
}